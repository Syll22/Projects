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
    public partial class FormProfesorAfisare: Form
    {
        public FormProfesorAfisare()
        {
            InitializeComponent();
        }

        private void FormProfesori_Load(object sender, EventArgs e)
        {
            String sirSQL;
            sirSQL = "SELECT IdProfesor FROM ListaProfesori ORDER BY NumeProfesor, PrenumeProfesor";

            DataTable dt = DBFunctions.Get_DataTable(sirSQL);

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {

                }
            }
        }
    }
}
