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

        // Profesori --------------------------------------------------------------------------------------------------------

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
                    this.updateDataGrid_Profesori();
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
            this.AUDProfesori(0);
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

            this.AUDProfesori(1);
        }

        private void btnDeleteProfesor_Click(object sender, RoutedEventArgs e)
        {

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Properties.Settings.Default.ConnString;
                conn.Open();
                status_conn.Background = Brushes.Green;


                //String msg = "";
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
            //        this.updateDataGrid_Profesori();
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

        // Studenti --------------------------------------------------------------------------------------------------------

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
                //cbxStuGrupa.Text = dataRowView["IdGrupa"].ToString();
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
                    msg = "Datele despre Student au fost adaugate cu suuces.";
                    break;
                case 1:
                    sql = "UPDATE ListaStudenti SET NumeStudent='" + txtNumeStudent.Text + "', PrenumeStudent='" + txtPrenumeStudent.Text + "' WHERE NumarMatricol=" + txtNumarMatricol.Text;
                    msg = "Datele despre Student au fost actualizate.";
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
                    this.updateDataGrid_Studenti();
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

        // Grupe --------------------------------------------------------------------------------------------------------

    }
}
