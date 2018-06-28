using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Printing;
using System.Drawing.Printing;

namespace CatalogApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Application.Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;
            InitializeComponent();
        }

        //Afiseaza un mesaj ce contine detaliile erorii atunci cand apare o exceptie, apoi continua rularea aplicatiei.
        private void Current_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        
        {
            MessageBox.Show(e.Exception.ToString(), "Unhandled exception", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }

        List<int> valoriIdProfesori = new List<int>();
        List<int> valoriIdStudenti = new List<int>();
        List<int> valoriIdMaterii = new List<int>();
        List<int> valoriIdSpecializari = new List<int>();
        List<int> valoriIdGrupe = new List<int>();

        int idProfesorAles = 0;
        int idStudentAles = 0;
        int idMaterieAleasa = 0;
        int idGrupaAleasa = 0;
        int idSpecializareAleasa = 0;

        //Goleste continutul campurilor din expander (nume, prenume etc.) atunci cand sunt schimbate tab-urile.
        private void applicationTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl)
            {
                resetCatalog();
                resetGrupe();
                resetMaterii();
                resetProfesori();
                resetSpecializari();
                resetStudenti();
            }
        }

        //Populeaza combo box-ul Profesor din tab-ul Catalog cu o lista de profesori dupa formatul Nume, Prenume din tabela ListaProfesori.
        private void creazaListaProfesori()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM ListaProfesori ORDER BY NumeProfesor, PrenumeProfesor ";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            string s;
            cbxCatalogProfesor.Items.Clear();
            while (dataReader.Read())
            {
                s = dataReader["NumeProfesor"].ToString() + " " + dataReader["PrenumeProfesor"].ToString();

                cbxCatalogProfesor.Items.Add(s);

                valoriIdProfesori.Add(Convert.ToInt32(dataReader["IdProfesor"].ToString()));
            }
            dataReader.Close();
            conn.Close();
        }

        //Populeaza combo box-ul Student din tab-ul Catalog cu o lista de studenti dupa formatul Nume, Prenume din tabela ListaStudenti.
        private void creazaListaStudenti()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM ListaStudenti ORDER BY NumeStudent, PrenumeStudent ";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            string s;
            cbxCatalogStudent.Items.Clear();
            while (dataReader.Read())
            {
                s = dataReader["NumeStudent"].ToString() + " " + dataReader["PrenumeStudent"].ToString();
                cbxCatalogStudent.Items.Add(s);

                valoriIdStudenti.Add(Convert.ToInt32(dataReader["NumarMatricol"].ToString()));
            }
            dataReader.Close();
            conn.Close();
        }

        //Populeaza combo box-ul Materie din tab-ul Catalog cu o lista de materii din tabela ListaMaterii. 
        private void creazaListaMaterii()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM ListaMaterii ORDER BY NumeMaterie";
            cbxCatalogMaterie.Items.Clear();
            cbxProfesorMaterii.Items.Clear();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            string s;

            while (dataReader.Read())
            {
                s = dataReader["NumeMaterie"].ToString();
                cbxCatalogMaterie.Items.Add(s);
                cbxProfesorMaterii.Items.Add(s);
                valoriIdMaterii.Add(Convert.ToInt32(dataReader["IdMaterie"].ToString()));
            }
            dataReader.Close();
            conn.Close();
        }

        //Populeaza combo box-ul Grupe din tab-ul ListaStudenti cu o lista de Grupe din tabela ListaGrupe. 
        private void creazaListaGrupe()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM ListaGrupe ORDER BY NumeGrupa";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            string s;
            cbxStuGrupa.Items.Clear();
            while (dataReader.Read())
            {
                s = dataReader["NumeGrupa"].ToString();
                cbxStuGrupa.Items.Add(s);
                valoriIdGrupe.Add(Convert.ToInt32(dataReader["IdGrupa"].ToString()));
            }
            dataReader.Close();
            conn.Close();
        }

        //populeaza combo box-urile din tab-urile Grupe si Materii cu o lista de specializari din tabela ListaSpecializari
        private void creazaListaSpecializari()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM ListaSpecializari ORDER BY NumeSpecializare";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            string s;
            cbxMatSpecializare.Items.Clear();
            cbxGruSpecializare.Items.Clear();
            while (dataReader.Read())
            {
                s = dataReader["NumeSpecializare"].ToString();
                cbxMatSpecializare.Items.Add(s);
                cbxGruSpecializare.Items.Add(s);
                valoriIdSpecializari.Add(Convert.ToInt32(dataReader["IdSpecializare"].ToString()));
            }
            dataReader.Close();
            conn.Close();
        }

        //la incarcarea ferestrei principale se apeleaza metodele de creare a listelor (materii, studenti etc.)
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            creazaListaProfesori();
            creazaListaStudenti();
            creazaListaMaterii();
            creazaListaGrupe();
            creazaListaSpecializari();
        }

        private void Export (DataGrid dgr)
        {
            Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelWorkBook = excelApplication.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet excelWorkSheet= null;

            //object missingValue = System.Reflection.Missing.Value;
            //excelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkBook.Worksheets.get_Item(1);

            try
            {
                excelWorkSheet = excelWorkBook.ActiveSheet;

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                DataTable dtExport = new DataTable();
                dtExport = ((DataView)dgr.ItemsSource).ToTable();

                for (int i = 0; i <= dtExport.Rows.Count; i++)
                {
                    for (int j = 0; j < dtExport.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            excelWorkSheet.Cells[cellRowIndex, cellColumnIndex] = dtExport.Columns[j].ColumnName;
                        }
                        else
                        {
                            excelWorkSheet.Cells[cellRowIndex, cellColumnIndex] = dtExport.Rows[i-1][j].ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                System.Windows.Forms.SaveFileDialog saveDialog = new System.Windows.Forms.SaveFileDialog(); 
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"; 
                saveDialog.FilterIndex = 1; 
  
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                {
                    excelWorkBook.SaveAs(saveDialog.FileName); 
                    MessageBox.Show("Export realizat cu succes!"); 
                }                

                //excelWorkBook.SaveAs(cale + "Grupe.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, missingValue,
                //    missingValue, missingValue, missingValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                //    missingValue, missingValue, missingValue, missingValue, missingValue);
                //excelWorkBook.Close(true, missingValue, missingValue);
                //excelApplication.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //releaseObject(excelWorkSheet);
                //releaseObject(excelWorkBook);
                //releaseObject(excelApplication);

                excelApplication.Quit();
                excelWorkBook = null;
                excelApplication = null;
            }
        }

        // Profesori ------------------------------------------------------------------------------------------------------

        private void updateDataGrid_Profesori()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "" +
                "SELECT m.IdProfesor as ID, m.NumeProfesor as Nume, m.PrenumeProfesor as Prenume, " +
                  "STUFF(( " +
                    "SELECT ', ' + cast(s.NumeMaterie as varchar(max)) " +
                    "FROM ListaProfesori mat LEFT JOIN MateriiProfesori ma on ma.IdProfesor = mat.IdProfesor " +
                    "FULL join ListaMaterii s on s.IdMaterie = ma.idMaterie" +
                    " WHERE mat.IdProfesor = m.IdProfesor FOR XML PATH(''), TYPE).value('.', 'varchar(max)'),1,2,'') as Materii " +
                "FROM ListaProfesori m " +
                "LEFT JOIN MateriiProfesori ms on m.IdProfesor = MS.IdProfesor " +
                "LEFT JOIN ListaMaterii s on s.IdMaterie = ms.IdMaterie " +
                "Group by m.IdProfesor, M.NumeProfesor, m.PrenumeProfesor; ";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dgr_profesori.ItemsSource = dataTable.DefaultView;

            dataReader.Close();
            conn.Close();
        }

        private void dgr_profesori_Loaded(object sender, RoutedEventArgs e)
        {
            updateDataGrid_Profesori();
        }

        private void dgr_profesori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataRowView dataRowView = dataGrid.SelectedItem as DataRowView;
            if (dataRowView != null)
            {
                txtNumeProfesor.Text = dataRowView["Nume"].ToString();
                txtPrenumeProfesor.Text = dataRowView["Prenume"].ToString();
                txtId.Text = dataRowView["ID"].ToString();
                btnAddProfesor.IsEnabled = false;
                btnUpdateProfesor.IsEnabled = true;
                btnDeleteProfesor.IsEnabled = true;
            }
        }

        private void AUDProfesori(int pOperatie)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();
            status_conn.Background = Brushes.Green;

            String msg = "";
            String sql = "";

            switch (pOperatie)
            {
                case 0:
                    sql = "INSERT INTO ListaProfesori(NumeProfesor, PrenumeProfesor) " +
                        "VALUES('" + txtNumeProfesor.Text + "', '" + txtPrenumeProfesor.Text + "')";
                    msg = "Datele despre profesor au fost adaugate cu suuces.";
                    break;
                case 1:
                    sql = "UPDATE ListaProfesori SET NumeProfesor='" + txtNumeProfesor.Text + "', PrenumeProfesor='" + txtPrenumeProfesor.Text + "' WHERE IdProfesor=" + txtId.Text;
                    msg = "Datele despre profesor au fost actualizate.";
                    break;
                case 2:
                    sql = "DELETE FROM ListaProfesori WHERE IdProfesor=" + txtId.Text;
                    msg = "Datele despre profesor au fost sterse.";
                    break;
            }

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            try
            {              
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    updateDataGrid_Profesori();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                resetProfesori();
                status_conn.Background = Brushes.Red;
                creazaListaProfesori();
            }
        }

        private void btnAddProfesor_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumeProfesor.Text == "")
            {
                MessageBox.Show("Nu ati introdus numele profesorului!");
                txtNumeProfesor.Focus();
                return;
            }
            if (txtPrenumeProfesor.Text == "")
            {
                MessageBox.Show("Nu ati introdus prenumele profesorului!");
                txtPrenumeProfesor.Focus();
                return;
            }
            AUDProfesori(0);
        }

        private void btnUpdateProfesor_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumeProfesor.Text == "")
            {
                MessageBox.Show("Nu ati introdus numele profesorului!");
                txtNumeProfesor.Focus();
                return;
            }
            if (txtPrenumeProfesor.Text == "")
            {
                MessageBox.Show("Nu ati introdus prenumele profesorului!");
                txtPrenumeProfesor.Focus();
                return;
            }

            AUDProfesori(1);
        }

        private void btnDeleteProfesor_Click(object sender, RoutedEventArgs e)
        {

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Properties.Settings.Default.ConnString;
                conn.Open();
                status_conn.Background = Brushes.Green;

                String sql = "";

                // verificare daca are examene in tabela Catalog
                sql = "SELECT * FROM Catalog WHERE IdProfesor=" + txtId.Text;

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    MessageBox.Show("Acest profesor nu poate fi sters, deoarece a sustinut deja minim un examen!");
                    return;
                }

                dr.Close();
                conn.Close();
                status_conn.Background = Brushes.Red;

                AUDProfesori(2);
            }
            //try
            //{
            //    SqlCommand cmd2 = conn.CreateCommand();
            //    cmd2.CommandType = CommandType.Text;

            //    sql = "DELETE FROM MateriiProfesori WHERE IdProfesor=" + txtId.Text;
            //    int n1 = cmd2.ExecuteNonQuery();

            //    sql = "DELETE FROM ListaProfesori WHERE IdProfesor=" + txtId.Text;
            //    msg = "Datele despre profesor au fost sterse.";

            //    int n = cmd2.ExecuteNonQuery();
            //    if (n1>0 && n > 0)
            //    {
            //        MessageBox.Show(msg);
            //        updateDataGrid_Profesori();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Eroare la stergerea profesorului!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}

            //resetProfesori();
        }

        private void btnResetProfesor_Click(object sender, RoutedEventArgs e)
        {
            resetProfesori();
        }

        private void resetProfesori()
        {
            txtNumeProfesor.Text = "";
            txtPrenumeProfesor.Text = "";
            txtId.Text = "";
            cbxProfesorMaterii.Text = "";
            btnAddProfesor.IsEnabled = true;
            btnUpdateProfesor.IsEnabled = false;
            btnDeleteProfesor.IsEnabled = false;
        }

        private void btnExportProfesor_Click(object sender, RoutedEventArgs e)
        {
            Export(dgr_profesori);
        }

        private void btnAdaugaMaterie_Click(object sender, RoutedEventArgs e)
        {
            if (cbxProfesorMaterii.Text == "")
            {
                MessageBox.Show("Nu ati ales nici o materie!");
                return;
            }
            else
            {
                int index = 0;
                index = cbxProfesorMaterii.SelectedIndex;
                idMaterieAleasa = valoriIdMaterii[index];
            }

            DataRowView dataRowView = dgr_profesori.SelectedItem as DataRowView;

            if (dataRowView == null)
            {
                MessageBox.Show("Nu ati ales un profesor!");
                return;
            }
            else
            {
                idProfesorAles = Convert.ToInt32(txtId.Text);
            }

            //verificare daca materia este deja asociata cu profesorul

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM MateriiProfesori WHERE IdProfesor=" + idProfesorAles.ToString() + " AND IdMaterie=" + idMaterieAleasa.ToString();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                MessageBox.Show("Aceasta materie este deja adaugata!");
                dataReader.Close();
                conn.Close();
                return;
            }
            else
            {
                dataReader.Close();
                conn.Close();

                //introducere in baza de date

                query = "INSERT INTO MateriiProfesori (IdProfesor, IdMaterie) VALUES (" + idProfesorAles.ToString() + ", "
                    + idMaterieAleasa.ToString() + ")";
            }

            conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            cmd = new SqlCommand(query, conn);
            int rezultat = cmd.ExecuteNonQuery();

            if (rezultat > 0)
            {
                MessageBox.Show("Datele despre materie au fost adaugate cu succes.");
            }
            else
            {
                MessageBox.Show("Datele nu au fost inserate!");
            }
            dataReader.Close();
            conn.Close();
            updateDataGrid_Profesori();
            resetProfesori();
        }

        private void btnStergeMaterie_Click(object sender, RoutedEventArgs e)
        {
            if (cbxProfesorMaterii.Text == "")
            {
                MessageBox.Show("Nu ati ales nici o materie!");
                return;
            }
            else
            {
                int index = 0;
                index = cbxProfesorMaterii.SelectedIndex;
                idMaterieAleasa = valoriIdMaterii[index];
            }

            DataRowView dataRowView = dgr_profesori.SelectedItem as DataRowView;

            if (dataRowView == null)
            {
                MessageBox.Show("Nu ati ales un profesor!");
                return;
            }
            else
            {
                idProfesorAles = Convert.ToInt32(txtId.Text);
            }

            //verificare daca materia este deja asociata cu profesorul

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM MateriiProfesori WHERE IdProfesor=" + idProfesorAles.ToString() + " AND IdMaterie="
                + idMaterieAleasa.ToString();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                query = "DELETE FROM MateriiProfesori WHERE IdProfesor = " + idProfesorAles.ToString() + " AND " +
                    "IdMaterie= " + idMaterieAleasa.ToString();
                dataReader.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Asociere inexistenta!");
                dataReader.Close();
                conn.Close();
                return;
            }

            conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            cmd = new SqlCommand(query, conn);
            int rezultat = cmd.ExecuteNonQuery();

            if (rezultat > 0)
            {
                MessageBox.Show("Asocierea dintre profesor si materie a fost stearsa cu succes.");
            }
            else
            {
                MessageBox.Show("Datele nu au fost sterse!");
            }
            dataReader.Close();
            conn.Close();
            updateDataGrid_Profesori();
            resetProfesori();
        }

        private void txtId_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtId.Text == "")
            {
                cbxProfesorMaterii.IsEnabled = false;
            }
            else
            {
                cbxProfesorMaterii.IsEnabled = true;
            }
        }

        // Studenti -------------------------------------------------------------------------------------------------------

        //void filtrareStudenti()
        //{
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = Properties.Settings.Default.ConnString;
        //    conn.Open();

        //    string query = "SELECT NumarMatricol as [Numar matricol], NumeStudent AS Nume, PrenumeStudent AS Prenume, NumeGrupa AS Grupa FROM ListaStudenti FULL OUTER JOIN ListaGrupe ON ListaGrupe.IdGrupa=ListaStudenti.IdGrupa WHERE 1=1 ";

        //    if (txtNumarMatricolFiltru.Text != "")  //cautare dupa NumarMatricol
        //    {
        //        query += " AND NumarMatricol=" + txtNumarMatricolFiltru.Text;
        //    }
        //    if (txtNumeFiltru.Text !="")  //cautare dupa Nume
        //    {
        //        query += " AND NumeStudent LIKE '%" + txtNumeFiltru.Text + "%'";
        //    }
        //    if (txtPrenumeFiltru.Text !="")  //cautare dupa Prenume
        //    {
        //        query += " AND PrenumeStudent LIKE '%" + txtPrenumeFiltru.Text + "%'";
        //    }

        //    query += " ORDER BY NumeStudent";

        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    SqlDataReader dataReader = cmd.ExecuteReader();
        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(dataReader);
        //    dgr_studenti.ItemsSource = dataTable.DefaultView;
        //    dgr_studenti.DataContext = dataTable;
        //    dataReader.Close();
        //    conn.Close();
        //}

        private void updateDataGrid_Studenti()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT NumarMatricol as [Numar matricol], NumeStudent AS Nume, PrenumeStudent AS Prenume, NumeGrupa AS Grupa FROM ListaStudenti " +
                "LEFT JOIN ListaGrupe ON ListaGrupe.IdGrupa=ListaStudenti.IdGrupa ORDER BY NumeStudent";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dgr_studenti.ItemsSource = dataTable.DefaultView;
            dgr_studenti.DataContext = dataTable;
            dataReader.Close();
            conn.Close();
        }

        private void dgr_studenti_Loaded(object sender, RoutedEventArgs e)
        {
            updateDataGrid_Studenti();
        }

        private void dgr_studenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataRowView dataRowView = dataGrid.SelectedItem as DataRowView;
            if (dataRowView != null)
            {
                txtNumeStudent.Text = dataRowView["Nume"].ToString();
                txtPrenumeStudent.Text = dataRowView["Prenume"].ToString();
                txtNumarMatricol.Text = dataRowView["Numar matricol"].ToString();
                cbxStuGrupa.Text = dataRowView["Grupa"].ToString();
                btnAddStudent.IsEnabled = false;
                btnUpdateStudent.IsEnabled = true;
                btnDeleteStudent.IsEnabled = true;
            }
        }

        private void AUDStudenti(int pOperatie)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();
            status_conn.Background = Brushes.Green;

            String msg = "";
            String sql = "";

            switch (pOperatie)
            {
                case 0:
                    sql = "INSERT INTO ListaStudenti (NumeStudent, PrenumeStudent) " +
                        "VALUES('" + txtNumeStudent.Text + "', '" + txtPrenumeStudent.Text + "')";

                    if (cbxStuGrupa.Text != "")
                    {
                        sql = "INSERT INTO ListaStudenti (NumeStudent, PrenumeStudent, IdGrupa) " +
                        "VALUES('" + txtNumeStudent.Text + "', '" + txtPrenumeStudent.Text + "', "+ idGrupaAleasa +")";
                    }

                    msg = "Datele despre student au fost adaugate cu succes.";
                    break;
                case 1:
                    sql = "UPDATE ListaStudenti SET NumeStudent='" + txtNumeStudent.Text + "', PrenumeStudent='" + txtPrenumeStudent.Text +
                        "' " + ((!string.IsNullOrEmpty(cbxStuGrupa.Text)) ? (" , IdGrupa =" + idGrupaAleasa  + " ") : "")
                            + " WHERE NumarMatricol=" + txtNumarMatricol.Text;
                    

                    msg = "Datele despre student au fost actualizate.";
                    break;
                case 2:
                    sql = "DELETE FROM ListaStudenti WHERE NumarMatricol=" + txtNumarMatricol.Text;
                    msg = "Datele despre student au fost sterse.";
                    break;
            }

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    updateDataGrid_Studenti();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                status_conn.Background = Brushes.Red;

                resetStudenti();
                creazaListaStudenti();
            }
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumeStudent.Text == "")
            {
                MessageBox.Show("Nu ati introdus numele studentului!");
                txtNumeStudent.Focus();
                return;
            }
            if (txtPrenumeStudent.Text == "")
            {
                MessageBox.Show("Nu ati introdus prenumele studentului!");
                txtPrenumeStudent.Focus();
                return;
            }

            int index = 0;
            if (cbxStuGrupa.Text != "")
            {
                index = cbxStuGrupa.SelectedIndex;
                idGrupaAleasa = valoriIdGrupe[index];
            }

            AUDStudenti(0);
        }

        private void btnUpdateStudent_Click(object sender, RoutedEventArgs e)
        {
            int index = 0;

            if (cbxStuGrupa.Text != "")
            {
                index = cbxStuGrupa.SelectedIndex;
                idGrupaAleasa = valoriIdGrupe[index];
            }

            AUDStudenti(1);
        }

        private void btnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            AUDStudenti(2);
        }

        private void btnResetStudent_Click(object sender, RoutedEventArgs e)
        {
            resetStudenti();
        }

        private void resetStudenti()
        {
            txtNumeStudent.Text = "";
            txtPrenumeStudent.Text = "";
            txtNumarMatricol.Text = "";
            cbxStuGrupa.Text = "";
            btnAddStudent.IsEnabled = true;
            btnUpdateStudent.IsEnabled = false;
            btnDeleteStudent.IsEnabled = false;
        }

        private void btnExportStudent_Click(object sender, RoutedEventArgs e)
        {
            Export(dgr_studenti);
        }

        // Grupe ----------------------------------------------------------------------------------------------------------

        private void updateDataGrid_Grupe()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT IdGrupa AS ID, NumeGrupa AS Grupa, NumeSpecializare AS Specializare " +
                "FROM ListaGrupe INNER JOIN ListaSpecializari ON ListaGrupe.IdSpecializare=ListaSpecializari.IdSpecializare ORDER BY NumeGrupa";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dgr_grupe.ItemsSource = dataTable.DefaultView;

            dataReader.Close();
            conn.Close();
        }

        private void dgr_grupe_Loaded(object sender, RoutedEventArgs e)
        {
            updateDataGrid_Grupe();
        }

        private void dgr_grupe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataRowView dataRowView = dataGrid.SelectedItem as DataRowView;
            if (dataRowView != null)
            {
                txtGruNumeGrupa.Text = dataRowView["Grupa"].ToString();
                txtGruIdGrupa.Text = dataRowView["ID"].ToString();
                cbxGruSpecializare.Text = dataRowView["Specializare"].ToString();
                btnAddGrupa.IsEnabled = false;
                btnUpdateGrupa.IsEnabled = true;
                btnDeleteGrupa.IsEnabled = true;
            }
        }

        private void AUDGrupe(int pOperatie)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();
            status_conn.Background = Brushes.Green;

            String msg = "";
            String sql = "";

            switch (pOperatie)
            {
                case 0:
                    sql = "INSERT INTO ListaGrupe (NumeGrupa, IdSpecializare) " +
                        "VALUES('" + txtGruNumeGrupa.Text + "', '" + idSpecializareAleasa + "')";
                    msg = "Datele despre grupa au fost adaugate cu suuces.";
                    break;
                case 1:
                    sql = "UPDATE ListaGrupe SET NumeGrupa='" + txtGruNumeGrupa.Text + "', IdSpecializare='" + 
                        idSpecializareAleasa + "' WHERE IdGrupa=" + txtGruIdGrupa.Text;
                    msg = "Datele despre grupa au fost actualizate.";
                    break;
                case 2:
                    sql = "DELETE FROM ListaGrupe WHERE IdGrupa=" + txtGruIdGrupa.Text;
                    msg = "Datele despre grupa au fost sterse.";
                    break;
            }

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    updateDataGrid_Grupe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                status_conn.Background = Brushes.Red;

                resetGrupe();
                creazaListaGrupe();
            }
        }

        private void btnAddGrupa_Click(object sender, RoutedEventArgs e)
        {
            if (txtGruNumeGrupa.Text == "")
            {
                MessageBox.Show("Nu ati introdus numele grupei!");
                txtGruNumeGrupa.Focus();
                return;
            }

            if (cbxGruSpecializare.Text == "")
            {
                MessageBox.Show("Nu ati ales o specializare!");
                cbxGruSpecializare.Focus();
                return;
            }

            int index = 0;

            index = cbxGruSpecializare.SelectedIndex;
            idSpecializareAleasa = valoriIdSpecializari[index];

            AUDGrupe(0);
        }

        private void btnUpdateGrupa_Click(object sender, RoutedEventArgs e)
        {
            int index = cbxGruSpecializare.SelectedIndex;
            idSpecializareAleasa = valoriIdSpecializari[index];

            AUDGrupe(1);
        }

        private void btnDeleteGrupa_Click(object sender, RoutedEventArgs e)
        {
            AUDGrupe(2);
        }

        private void btnResetGrupa_Click(object sender, RoutedEventArgs e)
        {
            resetGrupe();
        }

        private void resetGrupe()
        {
            txtGruNumeGrupa.Text = "";
            txtGruIdGrupa.Text = "";
            cbxGruSpecializare.Text = "";
            btnAddGrupa.IsEnabled = true;
            btnUpdateGrupa.IsEnabled = false;
            btnDeleteGrupa.IsEnabled = false;
        }

        private void btnExportGrupa_Click(object sender, RoutedEventArgs e)
        {
            Export(dgr_grupe);
        }

        // Materii --------------------------------------------------------------------------------------------------------

        private void updateDataGrid_Materii()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "" +
                "SELECT m.IdMaterie as ID, m.NumeMaterie as Materie, " +
                  "STUFF(( " +
                    "SELECT ', ' + cast(s.NumeSpecializare as varchar(max)) " +
                    "FROM ListaMaterii mat LEFT JOIN MateriiSpecializari ma on ma.IdMaterie = mat.IdMaterie " +
                    "FULL join ListaSpecializari s on s.IdSpecializare = ma.idspecializare" +
                    " WHERE mat.IdMaterie = m.IdMaterie FOR XML PATH(''), TYPE).value('.', 'varchar(max)'),1,2,'') as Specializari " +
                "FROM ListaMaterii m " +
                "LEFT JOIN MateriiSpecializari ms on m.IdMaterie = MS.IdMaterie " +
                "LEFT JOIN ListaSpecializari s on s.IdSpecializare = ms.IdSpecializare " +
                "Group by m.IdMaterie, M.NumeMaterie; ";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dgr_materii.ItemsSource = dataTable.DefaultView;

            dataReader.Close();
            conn.Close();
        }

        private void dgr_materii_Loaded(object sender, RoutedEventArgs e)
        {
            updateDataGrid_Materii();
        }

        private void dgr_materii_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataRowView dataRowView = dataGrid.SelectedItem as DataRowView;
            if (dataRowView != null)
            {
                txtMatNumeMaterie.Text = dataRowView["Materie"].ToString();
                txtMatIdMaterie.Text = dataRowView["ID"].ToString();
                //cbxMatSpecializare.Text = dataRowView["Specializare"].ToString();
                btnAddMaterie.IsEnabled = false;
                btnUpdateMaterie.IsEnabled = true;
                btnDeleteMaterie.IsEnabled = true;
            }
        }

        private void AUDMaterii(int pOperatie)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();
            status_conn.Background = Brushes.Green;

            String msg = "";
            String sql = "";

            switch (pOperatie)
            {
                case 0:
                    sql = "INSERT INTO ListaMaterii (NumeMaterie) " +
                        "VALUES('" + txtMatNumeMaterie.Text + "')";
                    msg = "Datele despre materie au fost adaugate cu succes.";
                    break;
                case 1:
                    sql = "UPDATE ListaMaterii SET NumeMaterie='" + txtMatNumeMaterie.Text + "' WHERE IdMaterie=" + txtMatIdMaterie.Text;
                    msg = "Datele despre materie au fost actualizate.";
                    break;
                case 2:
                    sql = "DELETE FROM ListaMaterii WHERE IdMaterie=" + txtMatIdMaterie.Text;
                    msg = "Datele despre materie au fost sterse.";
                    break;
            }

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    updateDataGrid_Materii();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                status_conn.Background = Brushes.Red;

                resetMaterii();
                creazaListaMaterii();
            }
        }

        private void btnAddMaterie_Click(object sender, RoutedEventArgs e)
        {
            if (txtMatNumeMaterie.Text == "")
            {
                MessageBox.Show("Nu ati introdus numele materiei!");
                txtMatNumeMaterie.Focus();
                return;
            }

            if (cbxMatSpecializare.Text != "")
            {
                MessageBox.Show("Mai intati adaugati materia, apoi efectuati asocierea cu o specializare.");
                cbxMatSpecializare.Text = "";
                return;
            }

            AUDMaterii(0);
        }

        private void btnUpdateMaterie_Click(object sender, RoutedEventArgs e)
        {
            AUDMaterii(1);
        }

        private void btnDeleteMaterie_Click(object sender, RoutedEventArgs e)
        {
            AUDMaterii(2);
        }

        private void btnResetMaterie_Click(object sender, RoutedEventArgs e)
        {
            resetMaterii();
        }

        private void resetMaterii()
        {
            txtMatNumeMaterie.Text = "";
            txtMatIdMaterie.Text = "";
            cbxMatSpecializare.Text = "";
            btnAddMaterie.IsEnabled = true;
            btnUpdateMaterie.IsEnabled = false;
            btnDeleteMaterie.IsEnabled = false;
        }

        private void btnExportMaterie_Click(object sender, RoutedEventArgs e)
        {
            Export(dgr_materii);
        }

        private void btnStergeSpecializare_Click(object sender, RoutedEventArgs e)
        {
            if (cbxMatSpecializare.Text == "")
            {
                MessageBox.Show("Nu ati ales nici o specializare!");
                return;
            }
            else
            {
                int index = 0;
                index = cbxMatSpecializare.SelectedIndex;
                idSpecializareAleasa = valoriIdSpecializari[index];
            }

            DataRowView dataRowView = dgr_materii.SelectedItem as DataRowView;

            if (dataRowView == null)
            {
                MessageBox.Show("Nu ati ales o materie!");
                return;
            }
            else
            {
                idMaterieAleasa = Convert.ToInt32(txtMatIdMaterie.Text);
            }

            //verificare daca specializarea este deja asociata cu materia

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM MateriiSpecializari WHERE IdMaterie=" + idMaterieAleasa.ToString() + " AND IdSpecializare=" 
                + idSpecializareAleasa.ToString();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                query = "DELETE FROM MateriiSpecializari WHERE IdMaterie = " + idMaterieAleasa.ToString() + " AND " +
                    "IdSpecializare= " + idSpecializareAleasa.ToString();
                dataReader.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Asociere inexistenta!");
                dataReader.Close();
                conn.Close();
                return;
            }

            conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            cmd = new SqlCommand(query, conn);
            int rezultat = cmd.ExecuteNonQuery();

            if (rezultat > 0)
            {
                MessageBox.Show("Asocierea dintre materie si specializare a fost stearsa cu succes.");
            }
            else
            {
                MessageBox.Show("Datele nu au fost sterse!");
            }
            dataReader.Close();
            conn.Close();
            updateDataGrid_Materii();
            resetMaterii();
        }

        private void btnAdaugaSpecializare_Click(object sender, RoutedEventArgs e)
        {
            if (cbxMatSpecializare.Text == "")
            {
                MessageBox.Show("Nu ati ales nici o specializare!");
                return;
            }
            else
            {
                int index = cbxMatSpecializare.SelectedIndex;
                idSpecializareAleasa = valoriIdSpecializari[index];
            }

            DataRowView dataRowView = dgr_materii.SelectedItem as DataRowView;

            //if (dataRowView == null)
            //{
            //    MessageBox.Show("Nu ati ales o materie!");
            //    return;
            //}
            //else
            //{
                idMaterieAleasa = Convert.ToInt32(txtMatIdMaterie.Text);
            //}

            //verificare daca specializarea este deja asociata cu materia

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM MateriiSpecializari WHERE IdMaterie=" + idMaterieAleasa.ToString() + " AND IdSpecializare=" + idSpecializareAleasa.ToString();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                MessageBox.Show("Aceasta specializare este deja adaugata!");
                dataReader.Close();
                conn.Close();
                return;
            }
            else
            {
                dataReader.Close();
                conn.Close();

                //introducere in baza de date

                query = "INSERT INTO MateriiSpecializari (IdMaterie, IdSpecializare) VALUES (" + idMaterieAleasa.ToString() + ", "
                    + idSpecializareAleasa.ToString() + ")";
            }

            conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            cmd = new SqlCommand(query, conn);
            int rezultat = cmd.ExecuteNonQuery();

            if (rezultat > 0)
            {
                MessageBox.Show("Datele despre specializare au fost adaugate cu succes.");
            }
            else
            {
                MessageBox.Show("Datele nu au fost inserate!");
            }
            dataReader.Close();
            conn.Close();
            updateDataGrid_Materii();
            resetMaterii();
        }

        private void txtMatIdMaterie_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtMatIdMaterie.Text == "")
            {
                cbxMatSpecializare.IsEnabled = false;
            }
            else
            {
                cbxMatSpecializare.IsEnabled = true;
            }
        }

        // Specializari ---------------------------------------------------------------------------------------------------

        private void updateDataGrid_Specializari()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT IdSpecializare AS ID, NumeSpecializare AS Specializare FROM ListaSpecializari ORDER BY NumeSpecializare";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dgr_specializari.ItemsSource = dataTable.DefaultView;

            dataReader.Close();
            conn.Close();
        }

        private void dgr_specializari_Loaded(object sender, RoutedEventArgs e)
        {
            updateDataGrid_Specializari();
        }

        private void dgr_specializari_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataRowView dataRowView = dataGrid.SelectedItem as DataRowView;
            if (dataRowView != null)
            {
                txtNumeSpecializare.Text = dataRowView["Specializare"].ToString();
                txtIdSpecializare.Text = dataRowView["ID"].ToString();
                btnAddSpecializare.IsEnabled = false;
                btnUpdateSpecializare.IsEnabled = true;
                btnDeleteSpecializare.IsEnabled = true;
            }
        }

        private void AUDSpecializari(int pOperatie)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();
            status_conn.Background = Brushes.Green;

            String msg = "";
            String sql = "";

            switch (pOperatie)
            {
                case 0:
                    sql = "INSERT INTO ListaSpecializari (NumeSpecializare) " +
                        "VALUES('" + txtNumeSpecializare.Text + "')";
                    msg = "Datele despre specializare au fost adaugate cu succes.";
                    break;
                case 1:
                    sql = "UPDATE ListaSpecializari SET NumeSpecializare='" + txtNumeSpecializare.Text + "' WHERE IdSpecializare=" + txtIdSpecializare.Text;
                    msg = "Datele despre specializare au fost actualizate.";
                    break;
                case 2:
                    sql = "DELETE FROM ListaSpecializari WHERE IdSpecializare=" + txtIdSpecializare.Text;
                    msg = "Datele despre specializare au fost sterse.";
                    break;
            }

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    updateDataGrid_Specializari();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                status_conn.Background = Brushes.Red;

                resetSpecializari();
                creazaListaSpecializari();
            }
        }

        private void btnAddSpecializare_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumeSpecializare.Text == "")
            {
                MessageBox.Show("Nu ati introdus numele specializarii!");
                txtNumeSpecializare.Focus();
                return;
            }
            AUDSpecializari(0);
        }

        private void btnUpdateSpecializare_Click(object sender, RoutedEventArgs e)
        {
            AUDSpecializari(1);
        }

        private void btnDeleteSpecializare_Click(object sender, RoutedEventArgs e)
        {
            AUDSpecializari(2);
        }

        private void btnResetSpecializare_Click(object sender, RoutedEventArgs e)
        {
            resetSpecializari();
        }

        private void resetSpecializari()
        {
            txtNumeSpecializare.Text = "";
            txtIdSpecializare.Text = "";
            btnAddSpecializare.IsEnabled = true;
            btnUpdateSpecializare.IsEnabled = false;
            btnDeleteSpecializare.IsEnabled = false;
        }

        private void btnExportSpecializare_Click(object sender, RoutedEventArgs e)
        {
            Export(dgr_specializari);
        }

        // Catalog --------------------------------------------------------------------------------------------------------

        private void updateDataGrid_Catalog()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM ViewCatalog ";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dgr_catalog.ItemsSource = dataTable.DefaultView;

            dataReader.Close();
            conn.Close();
        }

        private void dgr_catalog_Loaded(object sender, RoutedEventArgs e)
        {
            updateDataGrid_Catalog();
            populareNote();
        }

        private void dgr_catalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataRowView dataRowView = dataGrid.SelectedItem as DataRowView;

            if (dataRowView != null)
            {
                btnAddCatalog.IsEnabled = false;
                btnUpdateCatalog.IsEnabled = true;
                btnDeleteCatalog.IsEnabled = true;
                txtIdCatalog.Text = dataRowView["ID"].ToString();
                dpkCatalogDataExamen.Text = dataRowView["Data examen"].ToString();
                cbxCatalogMaterie.Text = dataRowView["Materie"].ToString();
                cbxCatalogNota.Text = dataRowView["Nota"].ToString();

                int idCatalogSelectat = Convert.ToInt32( dataRowView["ID"].ToString());

                // Extragere id profesor din tabela de date pe baza intrarii din catalog selectata.
                int idProfSelectat = 0;
                String sirSQL = "SELECT IdProfesor FROM Catalog WHERE IdCatalog=" + idCatalogSelectat; 

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.ConnString;
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                SqlCommand comm = new SqlCommand(sirSQL, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    idProfSelectat = Convert.ToInt32(reader["IdProfesor"].ToString());
                    reader.Close();
                }
                conn.Close();


                // Extragere nume si prenume profesori din tabela si incarcare in combo box, avand selectat profesorul actual.
                string sirBazaProfesor = "", sirProfesorSelectat = "";
                sirSQL = "SELECT IdProfesor, NumeProfesor, PrenumeProfesor FROM ListaProfesori ORDER BY NumeProfesor, PrenumeProfesor";

                conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.ConnString;
                conn.Open();

                cmd = conn.CreateCommand();
                comm = new SqlCommand(sirSQL, conn);
                reader = comm.ExecuteReader();

                cbxCatalogProfesor.Items.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sirBazaProfesor = reader["NumeProfesor"].ToString() + " " + reader["PrenumeProfesor"].ToString();
                        cbxCatalogProfesor.Items.Add(sirBazaProfesor);

                        if (idProfSelectat == Convert.ToInt32(reader["IdProfesor"]))
                        {
                            sirProfesorSelectat = sirBazaProfesor;
                        }
                    }
                    reader.Close();
                }
                conn.Close();

                cbxCatalogProfesor.SelectedItem = sirProfesorSelectat;

                // Extragere numar matricol student din tabela de date pe baza intrarii din catalog selectata.
                int numarMatricolStudentSelectat = 0;
                sirSQL = "SELECT NumarMatricol FROM Catalog WHERE IdCatalog=" + idCatalogSelectat;

                conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.ConnString;
                conn.Open();

                cmd = conn.CreateCommand();
                comm = new SqlCommand(sirSQL, conn);
                reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    numarMatricolStudentSelectat = Convert.ToInt32(reader["NumarMatricol"].ToString());
                    reader.Close();
                }
                conn.Close();

                // Extragere nume si prenume studenti din tabela si incarcare in combo box, avand selectat studentul actual.
                string sirBazaStudent = "", sirStudentSelectat = "";
                sirSQL = "SELECT NumarMatricol, NumeStudent, PrenumeStudent FROM ListaStudenti ORDER BY NumeStudent, PrenumeStudent";

                conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.ConnString;
                conn.Open();

                cmd = conn.CreateCommand();
                comm = new SqlCommand(sirSQL, conn);
                reader = comm.ExecuteReader();

                cbxCatalogStudent.Items.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sirBazaStudent = reader["NumeStudent"].ToString() + " " + reader["PrenumeStudent"].ToString();

                        cbxCatalogStudent.Items.Add(sirBazaStudent);

                        if (numarMatricolStudentSelectat == Convert.ToInt32(reader["NumarMatricol"]))
                        {
                            sirStudentSelectat = sirBazaStudent;
                        }
                    }
                    reader.Close();
                }
                conn.Close();

                cbxCatalogStudent.SelectedItem = sirStudentSelectat;
            }
        }

        private void AUDCatalog(int pOperatie)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();
            status_conn.Background = Brushes.Green;

            String msg = "";
            String sql = "";

            switch (pOperatie)
            {
                case 0:
                    sql = "INSERT INTO Catalog (NumarMatricol, IdMaterie, Nota, IdProfesor, DataExamen)" +
                        " VALUES('" + idStudentAles + "', '" + idMaterieAleasa + "', '" + cbxCatalogNota.Text + "', '" +
                        idProfesorAles + "', '" + dpkCatalogDataExamen.Text + "')";

                    msg = "Datele despre examen au fost introduse.";
                    break;
                case 1:
                    sql = "UPDATE Catalog SET IdProfesor='" + idProfesorAles + "', Nota='" + cbxCatalogNota.Text +
                        "', IdMaterie='" + idMaterieAleasa + "', NumarMatricol='" + idStudentAles + "', DataExamen='" +
                        dpkCatalogDataExamen.Text + "' WHERE IdCatalog=" + txtIdCatalog.Text;
                    msg = "Datele despre examen au fost actualizate.";
                    break;
                case 2:
                    sql = "DELETE FROM Catalog WHERE IdCatalog=" + txtIdCatalog.Text;
                    msg = "Datele despre examen au fost sterse.";
                    break;
            }

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show(msg);
                    updateDataGrid_Catalog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                status_conn.Background = Brushes.Red;
                resetCatalog();
            }
        }

        private void btnAddCatalog_Click(object sender, RoutedEventArgs e)
        {
            if (cbxCatalogProfesor.Text == "")
            {
                MessageBox.Show("Nu ati introdus numele profesorului.");
                cbxCatalogProfesor.Focus();
                return;
            }

            if (cbxCatalogMaterie.Text =="")
            {
                MessageBox.Show("Nu ati introdus materia.");
                cbxCatalogMaterie.Focus();
                return;
            }

            if (cbxCatalogStudent.Text == "")
            {
                MessageBox.Show("Nu ati introdus studentul.");
                cbxCatalogStudent.Focus();
                return;
            }

            if (cbxCatalogNota.Text == "")
            {
                MessageBox.Show("Nu ati introdus nota.");
                cbxCatalogNota.Focus();
                return;
            }

            if (dpkCatalogDataExamen.Text == "")
            {
                MessageBox.Show("Nu ati ales o data corecta");
                dpkCatalogDataExamen.Focus();
                return;
            }

            int index = 0;

            index = cbxCatalogProfesor.SelectedIndex;
            idProfesorAles = valoriIdProfesori[index];

            index = cbxCatalogStudent.SelectedIndex;
            idStudentAles = valoriIdStudenti[index];

            index = cbxCatalogMaterie.SelectedIndex;
            idMaterieAleasa = valoriIdMaterii[index];

            AUDCatalog(0);
        }

        private void btnUpdateCatalog_Click(object sender, RoutedEventArgs e)
        {
            int index = 0;

            index = cbxCatalogProfesor.SelectedIndex;
            idProfesorAles = valoriIdProfesori[index];

            index = cbxCatalogStudent.SelectedIndex;
            idStudentAles = valoriIdStudenti[index];

            index = cbxCatalogMaterie.SelectedIndex;
            idMaterieAleasa = valoriIdMaterii[index];

            AUDCatalog(1);
        }

        private void btnDeleteCatalog_Click(object sender, RoutedEventArgs e)
        {
            AUDCatalog(2);
        }

        private void btnResetCatalog_Click(object sender, RoutedEventArgs e)
        {
            resetCatalog();
        }

        private void resetCatalog()
        {
            cbxCatalogProfesor.Text = "";
            cbxCatalogStudent.Text = "";
            txtIdCatalog.Text = "";
            cbxCatalogMaterie.Text = "";
            dpkCatalogDataExamen.Text = "";
            cbxCatalogNota.Text = "";
            btnAddCatalog.IsEnabled = true;
            btnUpdateCatalog.IsEnabled = false;
            btnDeleteCatalog.IsEnabled = false;
        }

        private void populareNote()
        {
            cbxCatalogNota.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                cbxCatalogNota.Items.Add(i.ToString());
            }
        }

        private void btnExportCatalog_Click(object sender, RoutedEventArgs e)
        {
            Export(dgr_catalog);
        }
    }
}
