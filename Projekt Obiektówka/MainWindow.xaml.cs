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
using System.Data.Entity;
using System.Data; //< DataBase Add>
using Projekt_Obiektówka.ViewModels;

namespace Projekt_Obiektówka
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MathText.Text = "0";
            ResultText.Text = "0";
        }

        #region Button_Click
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var currentNumber = button.Content;
            MathText.Text += currentNumber;
        }
        #endregion

        #region Button_Clear
        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            MathText.Text = "0";
            ResultText.Text= "0";
        }
        #endregion

        #region Button_Result
        private void Button_Result(object sender, RoutedEventArgs e)
        {
            var operation = MathText.Text;
            var result = ResultText.Text;

            try
            {
                if (operation.Contains('+'))
                {

                    var element = operation.Split('+');
                    ResultText.Text = (int.Parse(element[0]) + int.Parse(element[1])).ToString();
                }
                if (operation.Contains('-'))
                {
                    var element = operation.Split('-');
                    ResultText.Text = (int.Parse(element[0]) - int.Parse(element[1])).ToString();
                }

                if (operation.Contains('*'))
                {
                    var element = operation.Split('*');
                    ResultText.Text = (int.Parse(element[0]) * int.Parse(element[1])).ToString();
                }

                if (operation.Contains('/'))
                {
                    var element = operation.Split('/');
                    ResultText.Text = (int.Parse(element[0]) / int.Parse(element[1])).ToString();
                }
            }
            catch (System.FormatException)
            {
                MathText.Text = "0";
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
            var operation = MathText.Text;


            if (ContainstOperation(operation))
            {
                MathText.Text = MathText.Text.Replace("-", "+");
                MathText.Text = MathText.Text.Replace("*", "+");
                MathText.Text = MathText.Text.Replace("/", "+");
            }
            else
            {
                MathText.Text += "+";
            }
        }
        private void Button_Mult(object sender, RoutedEventArgs e)
        {
            var operation = MathText.Text;

            if (ContainstOperation(operation))
            {
                MathText.Text = MathText.Text.Replace("+", "*");
                MathText.Text = MathText.Text.Replace("-", "*");
                MathText.Text = MathText.Text.Replace("/", "*");
            }
            else
            {
                MathText.Text += "*";
            }
        }
        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            var operation = MathText.Text;

            if (ContainstOperation(operation))
            {
                MathText.Text = MathText.Text.Replace("+", "-");
                MathText.Text = MathText.Text.Replace("*", "-");
                MathText.Text = MathText.Text.Replace("/", "-");
            }
            else
            {
                MathText.Text += "-";
            }
        }
        private void Button_Div(object sender, RoutedEventArgs e)
        {
            var operation = MathText.Text;

            if (ContainstOperation(operation))
            {
                MathText.Text = MathText.Text.Replace("-", "/");
                MathText.Text = MathText.Text.Replace("*", "/");
                MathText.Text = MathText.Text.Replace("+", "/");
            }
            else
            {
                MathText.Text += "/";
            }
        }
        #endregion
        
        private void bd_Updata(string sURL, string sTitle)
        {

        }

        #region View_Change
        private void History_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new HistoryViewModel();
        }

        private void Calculator_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = null;
        }

        private void Lets_say_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new LetsSayViewModel();
        }
        #endregion

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            var context = new BazaDanychEntities();
            var tabela = new Obliczenia()
            {
                Obliczenia1 = MathText.Text,
                Wyniki = ResultText.Text
            };
            context.Obliczenia.Add(tabela);
            context.SaveChanges();
        }
    }

}
