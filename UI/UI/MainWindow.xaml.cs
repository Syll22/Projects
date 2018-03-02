using System;
using System.Collections.Generic;
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

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            catalogTab.Content = new ContentDisplayTab("Catalog");
            profesoriTab.Content = new ContentDisplayTab("Profesori");
            studentiTab.Content = new ContentDisplayTab("Studenti");
            materiiTab.Content = new ContentDisplayTab("Materii");
            specializariTab.Content = new ContentDisplayTab("Specializari");
            grupeTab.Content = new ContentDisplayTab("Grupe");
        }
        
    }
}
