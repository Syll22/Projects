﻿using System;
using System.Collections.Generic;
using System.Data;
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

        private void btnAdaugareStudenti_Click(object sender, RoutedEventArgs e)
        {
            FormStudentAdaugare frm = new FormStudentAdaugare();
            frm.ShowDialog();
        }

        private void btnAdaugareProfesorii_Click(object sender, RoutedEventArgs e)
        {
            FormProfesorAdaugare frm = new FormProfesorAdaugare();
            frm.ShowDialog();
        }
    }
}