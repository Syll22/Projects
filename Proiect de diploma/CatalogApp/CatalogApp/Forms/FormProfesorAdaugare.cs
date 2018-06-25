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
    public partial class FormProfesorAdaugare: Form
    {
        public FormProfesorAdaugare()
        {
            InitializeComponent();
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
            if (txtPrenume.Text=="")
            {
                MessageBox.Show("Nu ati introdus prenumele!");
                txtPrenume.Focus();
                return;
            }


            // verificare daca profesorul exista deja in baza de date

            String sirSQL;
            sirSQL = "SELECT IdProfesor FROM ListaProfesori WHERE NumeProfesor='" + txtNume.Text + "' AND PrenumeProfesor='" + txtPrenume.Text + "'";
            
            DataTable dt = DBFunctions.Get_DataTable(sirSQL);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Acest profesor a fost deja introdus in baza de date!");
                DBFunctions.Close_DB_Connection();
                return;
            }

            // nu exista profesorul in baza de date, deci se insereaza
            sirSQL = "INSERT INTO ListaProfesori (NumeProfesor, PrenumeProfesor, Enabled) VALUES ('" + txtNume.Text + "', '" + txtPrenume.Text + "', 1)";
            int rez = DBFunctions.Execute_SQL(sirSQL);

            if (rez == 0)
            {
                MessageBox.Show("Eroare la salvarea datelor despre profesor!");
            }
            else
            {
                MessageBox.Show("Datele despre profesor au fost salvate in baza!");
            }

            DBFunctions.Close_DB_Connection();
        }

        private void FormProfesorAdaugare_Load(object sender, EventArgs e)
        {

        }
    }
}
