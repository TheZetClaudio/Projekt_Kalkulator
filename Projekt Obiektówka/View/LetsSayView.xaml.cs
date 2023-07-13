using Projekt_Obiektówka.ViewModels;
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

namespace Projekt_Obiektówka.View
{
    /// <summary>
    /// Logika interakcji dla klasy LetsSayView.xaml
    /// </summary>
    public partial class LetsSayView : UserControl 
    {
        public LetsSayView()
        {
            InitializeComponent();
        }


        private void AddItem_Clicked(object sender, RoutedEventArgs e)
        {
           
            listBox1.Items.Add(textBox1.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
        }
        private void XDD(object sender, RoutedEventArgs e)
        {
            
        }


    }

}



