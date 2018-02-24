using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogApp
{
    public partial class FormStudentIntroducere: Form
    {
        public FormStudentIntroducere()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            // verificare daca datele introduse in forma sunt corecte

            if (txtNume.Text == "")
            {
                MessageBox.Show("Nu ati introdus numele studentului!");
                txtNume.Focus();
                return;
            }
            if (txtPrenume.Text == "")
            {
                MessageBox.Show("Nu ati introdus prenumele studentului!");
                txtPrenume.Focus();
                return;
            }

            // verificare daca studentul exista deja in baza de date

            String sirSQL;
            sirSQL = "SELECT NumarMatricol FROM ListaStudenti WHERE NumeStudent='" + txtNume.Text + "' AND PrenumeStudent='" + txtPrenume.Text + "'";

            DataTable dt = DBFunctions.Get_DataTable(sirSQL);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Acest student a fost deja introdus in baza de date!");
                DBFunctions.Close_DB_Connection();
                return;
            }

            // nu exista studentul in baza de date, deci se insereaza

            sirSQL = "INSERT INTO ListaStudenti (NumeStudent, PrenumeStudent, IdGrupa, Enabled) VALUES ('" + txtNume.Text + "', '" + txtPrenume.Text + "', 1)";
            int rez = DBFunctions.Execute_SQL(sirSQL);

            if (rez == 0)
            {
                MessageBox.Show("Eroare la salvarea datelor despre student!");
            }
            else
            {
                MessageBox.Show("Datele despre student au fost salvate in baza!");
            }

            DBFunctions.Close_DB_Connection();
        }
    }

        private void FormStudentIntroducere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'catalogDataSet.ListaGrupe' table. You can move, or remove it, as needed.
            this.listaGrupeTableAdapter.Fill(this.catalogDataSet.ListaGrupe);

        }
    }
}
