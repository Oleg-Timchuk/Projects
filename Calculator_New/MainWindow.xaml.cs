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
using System.Data;

namespace Calculator_New
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement c in Grid1.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs a)
        {

            string data = (string)((Button)a.OriginalSource).Content;
            if (data == "CE")
            {
                text.Text = "";
            }
            else if (data == "=")
            {
                string v = new DataTable().Compute(text.Text, null).ToString();
                text.Text = v;
            }
            else
            {
                text.Text += data;
            }

           

        }

    }   
}
