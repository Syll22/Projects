using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogApp
{
    public partial class FormStudentAfisare: Form
    {
        public FormStudentAfisare()
        {
            InitializeComponent();
        }

        public string sirStudenti = "";

        private void FormStudentAfisare_Load(object sender, EventArgs e)
        {
            String sirSQL;
            sirSQL = "SELECT NumarMatricol, NumeStudent, PrenumeStudent, NumeGrupa " +
                "FROM ListaStudenti INNER JOIN ListaGrupe ON ListaStudenti.IdGrupa=ListaGrupe.IdGrupa ORDER BY NumeStudent";


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            SqlCommand comm = new SqlCommand(sirSQL, conn);
            SqlDataReader reader = comm.ExecuteReader();

            dgvStudenti.Rows.Clear();
            dgvStudenti.Columns.Clear();

            if (!reader.HasRows)
                MessageBox.Show("Nu exista date in baza!");
            else
            {
                dgvStudenti.Columns.Add("NumarMatricol", "Numar Matricol");
                dgvStudenti.Columns.Add("Nume", "Nume");
                dgvStudenti.Columns.Add("Prenume", "Prenume");
                dgvStudenti.Columns.Add("NumeGrupa", "Grupa");


                sirStudenti = "Grupa: \t \t Studenti: \n";
                while (reader.Read())
                {
                    dgvStudenti.Rows.Add(reader["NumarMatricol"].ToString(), reader["NumeStudent"].ToString(), 
                        reader["PrenumeStudent"].ToString(), reader["NumeGrupa"].ToString());
                    sirStudenti += reader["NumeGrupa"].ToString() +"\t \t" + reader["NumeStudent"].ToString() + " " + reader["PrenumeStudent"].ToString() 
                          + "\n";
                }
                reader.Close();
            }
            conn.Close();


            // Incarcare grupe in cboGrupa
            sirSQL = "SELECT IdGrupa, NumeGrupa FROM ListaGrupe ORDER BY NumeGrupa";


            conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            cmd = conn.CreateCommand();
            comm = new SqlCommand(sirSQL, conn);
            reader = comm.ExecuteReader();

            cboGrupa.Items.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cboGrupa.Items.Add(reader["NumeGrupa"].ToString());
                }
                reader.Close();
            }
            conn.Close();
        }

        private void preluare_date(object o, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(sirStudenti, new Font("Arial", 20), Brushes.Blue, 10, 25);
        }

        private void btnPrintStudent_Click(object sender, EventArgs e)
        {
            PrintDocument pd2 = new PrintDocument();
            pd2.PrintPage += new PrintPageEventHandler(this.preluare_date);

            PrintDialog pdlg = new PrintDialog();
            PrintPreviewDialog ppd = new PrintPreviewDialog();

            ppd.Document = pd2;
            ppd.ShowDialog();

            pdlg.Document = pd2;

            if (pdlg.ShowDialog() == DialogResult.OK)
            {
                pd2.Print();
            }
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            if(cboGrupa.Text == "")
            {
                MessageBox.Show("Nu ati ales nicio grupa!");
                cboGrupa.Focus();
                return;
            }

            String sirSQL;
            sirSQL = "SELECT NumarMatricol, NumeStudent, PrenumeStudent, NumeGrupa " +
                "FROM ListaStudenti INNER JOIN ListaGrupe ON ListaStudenti.IdGrupa=ListaGrupe.IdGrupa " +
                "WHERE NumeGrupa='" + cboGrupa.Text + "'" +
                "ORDER BY NumeStudent";


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            SqlCommand comm = new SqlCommand(sirSQL, conn);
            SqlDataReader reader = comm.ExecuteReader();

            dgvStudenti.Rows.Clear();
            dgvStudenti.Columns.Clear();

            if (!reader.HasRows)
                MessageBox.Show("Nu exista date in baza!");
            else
            {
                dgvStudenti.Columns.Add("NumarMatricol", "Numar Matricol");
                dgvStudenti.Columns.Add("Nume", "Nume");
                dgvStudenti.Columns.Add("Prenume", "Prenume");
                dgvStudenti.Columns.Add("NumeGrupa", "Grupa");

                sirStudenti = "Grupa: \t \t Studenti: \n";
                while (reader.Read())
                {
                    dgvStudenti.Rows.Add(reader["NumarMatricol"].ToString(), reader["NumeStudent"].ToString(),
                        reader["PrenumeStudent"].ToString(), reader["NumeGrupa"].ToString());
                    sirStudenti += reader["NumeGrupa"].ToString() + "\t \t" + reader["NumeStudent"].ToString() + " " + reader["PrenumeStudent"].ToString()
                          + "\n";
                }
                reader.Close();
            }
            conn.Close();
        }
    }
}
