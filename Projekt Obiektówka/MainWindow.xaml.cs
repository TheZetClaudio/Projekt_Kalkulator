using Projekt_Obiektówka.ViewsModels;
using MahApps.Metro.Controls;
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

namespace Projekt_Obiektówka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            TextResult.Text = string.Empty;
            Math.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextResult.Text = string.Empty;

            var button = sender as Button;
            var currentNumber = button.Content;
            Math.Text += currentNumber;
        }




        private void Button_Clear(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Result(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Add(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Mult(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Minus(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Div(object sender, RoutedEventArgs e)
        {

        }

    }
}
