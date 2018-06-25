using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogApp
{
    public partial class FormProfesorModificare: Form
    {
        public int IdProfesorSelectat = 0;

        public FormProfesorModificare()
        {
            InitializeComponent();
        }

        private void FormProfesorModificare_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM ListaProfesori WHERE idProfesor=" + IdProfesorSelectat.ToString();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();

            dataReader.Read();

            lblIdProfesor.Text += ": " + dataReader["IdProfesor"].ToString();
            txtNume.Text = dataReader["NumeProfesor"].ToString();
            txtPrenume.Text = dataReader["PrenumeProfesor"].ToString();

            dataReader.Close();
            conn.Close();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            // verificare daca datele introduse in forma sunt corecte

            if (txtNume.Text == "")
            {
                MessageBox.Show("Nu ati introdus numele profesorului!");
                txtNume.Focus();
                return;
            }
            if (txtPrenume.Text == "")
            {
                MessageBox.Show("Nu ati introdus prenumele!");
                txtPrenume.Focus();
                return;
            }


            // se modifica datele profesorului
            String sirSQL;
            sirSQL = "UPDATE ListaProfesori " +
                " SET NumeProfesor='" + txtNume.Text + "', " +
                " PrenumeProfesor='" + txtPrenume.Text + "' " +
                " WHERE IdProfesor=" + this.IdProfesorSelectat.ToString();
            int rez = DBFunctions.Execute_SQL(sirSQL);

            if (rez == 0)
            {
                MessageBox.Show("Eroare la salvarea datelor despre profesor!");
            }
            else
            {
                MessageBox.Show("Datele despre profesor au fost modificate!");
                this.Close();
            }

            DBFunctions.Close_DB_Connection();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
