using System;
using System.Windows;
using System.Windows.Controls;

namespace Kinderbijslag
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Public Variables
        public int Input_Aantal;
        #endregion
        #region Constructor
        public MainWindow()
        {            
            InitializeComponent();
            Container.Visibility = Visibility.Hidden;
        }
        #endregion
        #region Amount of children
        private void Aantal_TextChanged(object sender, TextChangedEventArgs e)
        {
            #region Input_Aantal != ""
            if (Aantal.Text != "")
            {
                Input_Aantal = int.Parse(Aantal.Text);
                Container.Visibility = Visibility.Visible;
            }
            else
            {
                Container.Visibility = Visibility.Hidden;
            }
            #endregion
            #region Input_Aantal Number
            if (Input_Aantal == 1)
            {
                Row2.Height = new GridLength(0);
                Row3.Height = new GridLength(0);
                Row4.Height = new GridLength(0);
                Row5.Height = new GridLength(0);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 2)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(0);
                Row4.Height = new GridLength(0);
                Row5.Height = new GridLength(0);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 3)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(0);
                Row5.Height = new GridLength(0);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 4)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(0);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 5)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(0);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 6)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(0);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 7)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(63);
                Row8.Height = new GridLength(0);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 8)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(63);
                Row8.Height = new GridLength(63);
                Row9.Height = new GridLength(0);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 9)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(63);
                Row8.Height = new GridLength(63);
                Row9.Height = new GridLength(63);
                Row10.Height = new GridLength(0);
            }
            if (Input_Aantal == 10)
            {
                Row2.Height = new GridLength(63);
                Row3.Height = new GridLength(63);
                Row4.Height = new GridLength(63);
                Row5.Height = new GridLength(63);
                Row6.Height = new GridLength(63);
                Row7.Height = new GridLength(63);
                Row8.Height = new GridLength(63);
                Row9.Height = new GridLength(63);
                Row10.Height = new GridLength(63);
            }
            #endregion
        }
        #endregion
        #region Populate Class1.ListBirth with year of birth
        private void BirthYears()
        {
            Class1.ListBirth.Clear();
            if (Input_Aantal > 0)
            {
                Class1.ListBirth.Add(((DateTime)Birth_1.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 1)
            {
                Class1.ListBirth.Add(((DateTime)Birth_2.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 2)
            {
                Class1.ListBirth.Add(((DateTime)Birth_3.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 3)
            {
                Class1.ListBirth.Add(((DateTime)Birth_4.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 4)
            {
                Class1.ListBirth.Add(((DateTime)Birth_5.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 5)
            {
                Class1.ListBirth.Add(((DateTime)Birth_6.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 6)
            {
                Class1.ListBirth.Add(((DateTime)Birth_7.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 7)
            {
                Class1.ListBirth.Add(((DateTime)Birth_8.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 8)
            {
                Class1.ListBirth.Add(((DateTime)Birth_9.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }
            if (Input_Aantal > 9)
            {
                Class1.ListBirth.Add(((DateTime)Birth_10.SelectedDate.Value).Date);
            }
            else
            {
                return;
            }           
        }
        #endregion
        #region Button Bereken
        private void Bereken_Click(object sender, RoutedEventArgs e)
        {
            #region Local Variables
            int i = 0;
            Double Cost = 0;
            BirthYears();
            #endregion
            #region Calculate Age and the associated Cost (with Class1.ListBirth)
            do
            {
                var age = DateTime.Today.Year - Class1.ListBirth[i].Year;
                if (Class1.ListBirth[i] > DateTime.Today.AddYears(-age))
                {
                    age--;
                }

                if (age < 12)
                {
                    Cost += 150;
                }
                else if (age < 18)
                {
                    Cost += 235;
                }
                else
                {
                    MessageBox.Show(age + " jaar is te oud voor de kinderopvang");
                }
                i++;
            }
            while (i < Input_Aantal);
            #endregion
            #region Calculate Cost on the basis of the amount of children
            if (Input_Aantal == 3 || Input_Aantal == 4)
            {
                Cost *= 1.02;
            }
            else if (Input_Aantal == 5)
            {
                Cost *= 1.03;
            }
            else if(Input_Aantal > 5)
            {
                Cost *= 1.035;
            }
            #endregion
            #region Display Cost
            Kosten_txt.Content = "De totale kinderbijslag is:";
            Kosten_int.Content = Cost.ToString("C2");
            #endregion
        }
        #endregion
    }
}
