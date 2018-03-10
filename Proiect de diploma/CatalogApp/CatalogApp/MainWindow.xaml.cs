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

            //lblIdProfesor.Text += ": " + dataReader["IdProfesor"].ToString();
            //txtNume.Text = dataReader["NumeProfesor"].ToString();
            //txtPrenume.Text = dataReader["PrenumeProfesor"].ToString();

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
            }
        }

        private void AUDProfesori(int pOperatie)
        {
            String msg = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

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
            }
        }

        private void btnAddProfesor_Click(object sender, RoutedEventArgs e)
        {
            this.AUDProfesori(0);
            resetProfesori();
        }

        private void btnUpdateProfesor_Click(object sender, RoutedEventArgs e)
        {
            this.AUDProfesori(1);
            resetProfesori();
        }

        private void btnDeleteProfesor_Click(object sender, RoutedEventArgs e)
        {

            String msg = "";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            String sql = "";
            // verificare daca are examene in tabela Catalog
            sql = "SELECT * FROM Catalog WHERE IdProfesor=" + txtId.Text;

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            // cmd.CommandType = CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Acest profesor nu poate fi sters, deoarece a sustinut deja minim un examen!");
                return;
            }


            try
            {
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;

                sql = "DELETE FROM MateriiProfesori WHERE IdProfesor=" + txtId.Text;
                int n1 = cmd2.ExecuteNonQuery();

                sql = "DELETE FROM ListaProfesori WHERE IdProfesor=" + txtId.Text;
                msg = "Datele despre profesor au fost sterse.";

                int n = cmd2.ExecuteNonQuery();
                if (n1>0 && n > 0)
                {
                    MessageBox.Show(msg);
                    this.updateDataGrid_Profesori();
                }
                else
                {
                    MessageBox.Show("Eroare la stergerea profesorului!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            resetProfesori();
        }

        private void resetProfesori()
        {
            txtNumeProfesor.Text = "";
            txtPrenumeProfesor.Text = "";
            txtId.Text = "";
        }
    }
}
