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
    public partial class FormProfesorAfisare: Form
    {
        private string sirProfesori = "";

        public FormProfesorAfisare()
        {
            InitializeComponent();
        }

        private void FormProfesori_Load(object sender, EventArgs e)
        {
            

        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            int rand = dgvProfesori.CurrentCell.RowIndex;
            int CodProfesor = Convert.ToInt32(dgvProfesori.Rows[rand].Cells[0].Value.ToString());
            // MessageBox.Show(CodProfesor.ToString());

            FormProfesorModificare frm = new FormProfesorModificare();
            frm.IdProfesorSelectat = CodProfesor;
            frm.ShowDialog();

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            int rand = dgvProfesori.CurrentCell.RowIndex;
            int CodProfesor = Convert.ToInt32(dgvProfesori.Rows[rand].Cells[0].Value.ToString());
            // MessageBox.Show(CodProfesor.ToString());

            var result = MessageBox.Show("Sterge profesorul cu codul" + CodProfesor, "Esti sigur?", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                //Sterge profu cu codu
                MessageBox.Show("Profu sters");
                return;
            }

            FormProfesorStergere frm = new FormProfesorStergere();
            frm.IdProfesorSelectat = CodProfesor;
            frm.ShowDialog();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProfesorAfisare_Activated(object sender, EventArgs e)
        {
            String sirSQL;
            sirSQL = "SELECT IdProfesor, NumeProfesor, PrenumeProfesor FROM ListaProfesori ORDER BY NumeProfesor, PrenumeProfesor";


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            SqlCommand comm = new SqlCommand(sirSQL, conn);
            SqlDataReader reader = comm.ExecuteReader();

            dgvProfesori.Rows.Clear();
            dgvProfesori.Columns.Clear();

            if (!reader.HasRows)
                MessageBox.Show("Nu exista date in baza!");
            else
            {
                dgvProfesori.Columns.Add("Id", "Id");
                dgvProfesori.Columns.Add("Nume", "Nume");
                dgvProfesori.Columns.Add("Prenume", "Prenume");

                sirProfesori = "Profesori \n";
                while (reader.Read())
                {
                    dgvProfesori.Rows.Add(reader["IdProfesor"].ToString(), reader["NumeProfesor"].ToString(), reader["PrenumeProfesor"].ToString());
                    sirProfesori += reader["NumeProfesor"].ToString() + " " + reader["PrenumeProfesor"].ToString() + "\n";
                }
                reader.Close();
            }
            conn.Close();
        }
         
         
        private void preluare_date(object o, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(sirProfesori, new Font("Arial", 20), Brushes.Blue, 10, 25);
        }

        private void btnPrint_Click(object sender, EventArgs e)
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
    }
}
