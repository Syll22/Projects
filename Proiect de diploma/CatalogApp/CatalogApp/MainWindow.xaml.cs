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

        private void profesori_data_grid_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ConnString;
            conn.Open();

            string query = "SELECT * FROM ListaProfesori";
            //WHERE idProfesor=" + IdProfesorSelectat.ToString();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            profesori_data_grid.ItemsSource = dataTable.DefaultView;

            //lblIdProfesor.Text += ": " + dataReader["IdProfesor"].ToString();
            //txtNume.Text = dataReader["NumeProfesor"].ToString();
            //txtPrenume.Text = dataReader["PrenumeProfesor"].ToString();

            dataReader.Close();
            conn.Close();
        }
    }
}
