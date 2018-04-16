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
            InitializeComponent();
        }

        int[] vIdCatalogProfesor = new int[100];
        int dimVIdCatalogProfesor = 0;

        int[] vIdCatalogStudent = new int[100];
        int dimVIdCatalogStudent = 0;

        int[] vIdCatalogMaterie = new int[100];
        int dimVIdCatalogMaterie = 0;

        int idProfesorAles = 0;
        int idStudentAles = 0;
        int idMaterieAleasa = 0;


        // Profesori ------------------------------------------------------------------------------------------------------

        private void updateDataGrid_Profesori()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT IdProfesor, NumeProfesor, PrenumeProfesor FROM ListaProfesori ORDER BY NumeProfesor";

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
                txtNumeProfesor.Text = dataRowView["NumeProfesor"].ToString();
                txtPrenumeProfesor.Text = dataRowView["PrenumeProfesor"].ToString();
                txtId.Text = dataRowView["IdProfesor"].ToString();
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
                resetProfesori();
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
            btnAddProfesor.IsEnabled = true;
            btnUpdateProfesor.IsEnabled = false;
            btnDeleteProfesor.IsEnabled = false;
        }

        // Studenti -------------------------------------------------------------------------------------------------------

        private void updateDataGrid_Studenti()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT NumarMatricol, NumeStudent, PrenumeStudent FROM ListaStudenti ORDER BY NumeStudent";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dgr_studenti.ItemsSource = dataTable.DefaultView;

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
                txtNumeStudent.Text = dataRowView["NumeStudent"].ToString();
                txtPrenumeStudent.Text = dataRowView["PrenumeStudent"].ToString();
                txtNumarMatricol.Text = dataRowView["NumarMatricol"].ToString();
                //cbxStuGrupa.Text = dataRowView["IdGrupa"].ToString(); //de reparat
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
                    sql = "INSERT INTO ListaStudenti(NumeStudent, PrenumeStudent) " +
                        "VALUES('" + txtNumeStudent.Text + "', '" + txtPrenumeStudent.Text + "')";
                    msg = "Datele despre student au fost adaugate cu suuces.";
                    break;
                case 1:
                    sql = "UPDATE ListaStudenti SET NumeStudent='" + txtNumeStudent.Text + "', PrenumeStudent='" + txtPrenumeStudent.Text + "' WHERE NumarMatricol=" + txtNumarMatricol.Text;
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
            AUDStudenti(0);
        }

        private void btnUpdateStudent_Click(object sender, RoutedEventArgs e)
        {
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
                txtGruNumeGrupa.Text = dataRowView["NumeGrupa"].ToString();
                txtGruIdGrupa.Text = dataRowView["IdGrupa"].ToString();
                //cbxGruSpecializare.Text = dataRowView["IdSpecializare"].ToString(); //de reparat
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
                    sql = "INSERT INTO ListaGrupe (NumeGrupa) " +
                        "VALUES('" + txtGruNumeGrupa.Text + "')";
                    msg = "Datele despre grupa au fost adaugate cu suuces.";
                    break;
                case 1:
                    sql = "UPDATE ListaGrupe SET NumeGrupa='" + txtGruNumeGrupa.Text + "' WHERE IdGrupa=" + txtGruIdGrupa.Text;
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

                resetStudenti();
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
            //AUDGrupe(0); //de reparat IDSpecializare cbx source

        }

        private void btnUpdateGrupa_Click(object sender, RoutedEventArgs e)
        {
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

        // Materii --------------------------------------------------------------------------------------------------------

        private void updateDataGrid_Materii()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT IdMaterie, NumeMaterie FROM ListaMaterii ORDER BY NumeMaterie";

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
                txtMatNumeMaterie.Text = dataRowView["NumeMaterie"].ToString();
                txtMatIdMaterie.Text = dataRowView["IdMaterie"].ToString();
                //cbxMatSpecializare.Text = dataRowView["IdSpecializare"].ToString(); //de reparat
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
                    msg = "Datele despre materie au fost adaugate cu suuces.";
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
            //AUDGrupe(0); //de reparat IDSpecializare cbx source
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

        // Specializari ---------------------------------------------------------------------------------------------------

        private void updateDataGrid_Specializari()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT IdSpecializare, NumeSpecializare FROM ListaSpecializari ORDER BY NumeSpecializare";

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
                txtNumeSpecializare.Text = dataRowView["NumeSpecializare"].ToString();
                txtIdSpecializare.Text = dataRowView["IdSpecializare"].ToString();
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
                    msg = "Datele despre specializare au fost adaugate cu suuces.";
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
        }

        private void dgr_catalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataRowView dataRowView = dataGrid.SelectedItem as DataRowView;
            if (dataRowView != null)
            {
                //cbxCatalogProfesor.Text = dataRowView["NumeSpecializare"].ToString();
                //txtIdSpecializare.Text = dataRowView["IdSpecializare"].ToString();
                btnAddSpecializare.IsEnabled = false;
                btnUpdateSpecializare.IsEnabled = true;
                btnDeleteSpecializare.IsEnabled = true;
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
                        " VALUES('" + idStudentAles + "', '" + idMaterieAleasa + "', '" + cbxCatalogNota.Text + "', '" + idProfesorAles + "', '" + dpkCatalogDataExamen.Text + "')";
                    // msg = "Datele despre specializare au fost adaugate cu succes.";
                    msg = sql;
                    break;
                case 1:
                    sql = "UPDATE ListaSpecializari SET NumeSpecializare='" + txtNumeSpecializare.Text + "' WHERE IdSpecializare=" + 
                        txtIdSpecializare.Text; //to be fixed
                    msg = "Datele despre specializare au fost actualizate.";
                    break;
                case 2:
                    sql = "DELETE FROM ListaSpecializari WHERE IdSpecializare=" + txtIdSpecializare.Text; //to be fixed
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
                MessageBox.Show("Nu ati introdus numele profesorului!");
                cbxCatalogProfesor.Focus();
                return;
            }

            //de adaugat cate un if pentru fiecare camp din tab
            int index = 0;

            index = cbxCatalogProfesor.SelectedIndex;
            idProfesorAles = vIdCatalogProfesor[index];

            index = cbxCatalogStudenti.SelectedIndex;
            idStudentAles = vIdCatalogStudent[index];

            index = cbxCatalogMaterie.SelectedIndex;
            idMaterieAleasa = vIdCatalogMaterie[index];

            AUDCatalog(0);
        }

        private void btnUpdateCatalog_Click(object sender, RoutedEventArgs e)
        {
            //AUDCatalog(1);
        }

        private void btnDeleteCatalog_Click(object sender, RoutedEventArgs e)
        {
            //AUDCatalog(2);
        }

        private void btnResetCatalog_Click(object sender, RoutedEventArgs e)
        {
            resetCatalog();
        }

        private void resetCatalog()
        {
            cbxCatalogProfesor.Text = "";
            cbxCatalogStudenti.Text = "";
            btnAddCatalog.IsEnabled = true;
            btnUpdateCatalog.IsEnabled = false;
            btnDeleteCatalog.IsEnabled = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM ListaProfesori ORDER BY NumeProfesor, PrenumeProfesor ";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            string s;
            int n = 0;
            while (dataReader.Read())
            {
                s = dataReader["NumeProfesor"].ToString() + " " + dataReader["PrenumeProfesor"].ToString();
                cbxCatalogProfesor.Items.Add(s);

                vIdCatalogProfesor[n] = Convert.ToInt32(dataReader["IdProfesor"].ToString());
                n++;
            }
            dataReader.Close();
            conn.Close();
            dimVIdCatalogProfesor = n;

            // ==================Studenti

            conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            query = "SELECT * FROM ListaStudenti ORDER BY NumeStudent, PrenumeStudent ";

            cmd = new SqlCommand(query, conn);
            dataReader = cmd.ExecuteReader();
            n = 0;
            while (dataReader.Read())
            {
                s = dataReader["NumeStudent"].ToString() + " " + dataReader["PrenumeStudent"].ToString();
                cbxCatalogStudenti.Items.Add(s);

                vIdCatalogStudent[n] = Convert.ToInt32(dataReader["NumarMatricol"].ToString());
                n++;
            }
            dataReader.Close();
            conn.Close();
            dimVIdCatalogStudent = n;

            // ==================Materii

            conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            query = "SELECT * FROM ListaMaterii ORDER BY NumeMaterie";

            cmd = new SqlCommand(query, conn);
            dataReader = cmd.ExecuteReader();
            n = 0;
            while (dataReader.Read())
            {
                s = dataReader["NumeMaterie"].ToString();
                cbxCatalogMaterie.Items.Add(s);

                vIdCatalogMaterie[n] = Convert.ToInt32(dataReader["IdMaterie"].ToString());
                n++;
            }
            dataReader.Close();
            conn.Close();
            dimVIdCatalogMaterie = n;

        }

        private void btnAfisareProfesor_Click(object sender, RoutedEventArgs e)
        {
            FormProfesorAfisare frm = new FormProfesorAfisare();
            frm.ShowDialog();
        }

        private void btnAfisareStudent_Click(object sender, RoutedEventArgs e)
        {
            FormStudentAfisare frm = new FormStudentAfisare();
            frm.ShowDialog();
        }
    }
}
