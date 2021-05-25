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
using System.Collections.ObjectModel;

namespace RegistrationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> Persons = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();
            var person1 = new Person { Name = "Ivan", Age = 18, Birthday = new DateTime(2002, 12, 3), SurName = "Prilipov" };
            var person2 = new Person { Name = "Valeriy", Age = 15, Birthday = new DateTime(2005, 2, 8), SurName = "Andropov" };
            Persons.Add(person1);
            Persons.Add(person2);
            List.ItemsSource = Persons;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var PopUps = new System.Windows.Controls.Primitives.Popup[5] { NamePopUp, SurnamePopUp, AgePopUp, BirthdayPopUp, PassswordPopUp };
            string[] TextBoxes = new string[5] { NameBox.Text, SurnameBox.Text, AgeBox.Text, BirthdayBox.Text, PasswordBox.Password };
            for (int i = 0; i < TextBoxes.Length; i++)
            {
                if (String.IsNullOrEmpty(TextBoxes[i]))
                {
                    PopUps[i].IsOpen = true;

                }
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Tooltip.IsOpen = false;
            var PopUps = new System.Windows.Controls.Primitives.Popup[5] { NamePopUp, SurnamePopUp, AgePopUp, BirthdayPopUp, PassswordPopUp };
            string[] TextBoxes = new string[5] { NameBox.Text, SurnameBox.Text, AgeBox.Text, BirthdayBox.Text, PasswordBox.Password };
            for (int i = 0; i < PopUps.Length; i++)
            {
                PopUps[i].StaysOpen = false;
            }
        }
    }
}
