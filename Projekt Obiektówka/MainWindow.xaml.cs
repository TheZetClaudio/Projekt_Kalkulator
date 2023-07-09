using ControlzEx.Standard;
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
using System.Data; //< DataBase Add>
using Projekt_Obiektówka.ViewModels;

namespace Projekt_Obiektówka
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Math.Text = "0";
        }
        #region Button_Click
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var currentNumber = button.Content;
            Math.Text += currentNumber;
        }
        #endregion

        #region Button_Clear
        private void Button_Clear(object sender, RoutedEventArgs e)
        {  
            Math.Text = "0";
        }
        #endregion

        #region Button_Result
        private void Button_Result(object sender, RoutedEventArgs e)
        {
            var operation = Math.Text;

            if(operation.Contains('+'))
            {
                var element = operation.Split('+');
                var result = double.Parse(element[0]) + double.Parse(element[1]);
                Math.Text = result.ToString();
            }

            if (operation.Contains('-'))
            {
                var element = operation.Split('-');
                var result = double.Parse(element[0]) - double.Parse(element[1]);
                Math.Text = result.ToString();
            }

            if (operation.Contains('*'))
            {
                var element = operation.Split('*');
                var result = double.Parse(element[0]) * double.Parse(element[1]);
                Math.Text = result.ToString();
            }

            if (operation.Contains('/'))
            {
                var element = operation.Split('/');
                var result = double.Parse(element[0]) / double.Parse(element[1]);
                Math.Text = result.ToString();
            }
        }
        #endregion

        #region AllOperation
        private bool ContainstOperation(string operation)
        {
            return operation.Contains("+") || operation.Contains("-") || operation.Contains("*") || operation.Contains("/");
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            var operation = Math.Text;


            if (ContainstOperation(operation))
            {
                Math.Text = Math.Text.Replace("-", "+");
                Math.Text = Math.Text.Replace("*", "+");
                Math.Text = Math.Text.Replace("/", "+");
            }
            else
            {
                Math.Text += "+";
            }
        }
        private void Button_Mult(object sender, RoutedEventArgs e)
        {
            var operation = Math.Text;

            if (ContainstOperation(operation))
            {
                Math.Text = Math.Text.Replace("+", "*");
                Math.Text = Math.Text.Replace("-", "*");
                Math.Text = Math.Text.Replace("/", "*");
            }
            else
            {
                Math.Text += "*";
            }
        }
        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            var operation = Math.Text;

            if (ContainstOperation(operation))
            {
                Math.Text = Math.Text.Replace("+", "-");
                Math.Text = Math.Text.Replace("*", "-");
                Math.Text = Math.Text.Replace("/", "-");
            }
            else
            {
                Math.Text += "-";
            }
        }
        private void Button_Div(object sender, RoutedEventArgs e)
        {
            var operation = Math.Text;

            if (ContainstOperation(operation))
            {
                Math.Text = Math.Text.Replace("-", "/");
                Math.Text = Math.Text.Replace("*", "/");
                Math.Text = Math.Text.Replace("+", "/");
            }
            else
            {
                Math.Text += "/";
            }
        }
        #endregion
        
        private void bd_Updata(string sURL, string sTitle)
        {

        }

        private void History_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new HistoryViewModel();
        }

        private void Calculator_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = null;
        }
    }
}
