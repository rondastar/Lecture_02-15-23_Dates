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

namespace Lecture_02_15_23_Dates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DateTime date = new DateTime(2023, 2, 15);
            DateTime date2 = date.AddMonths(7);

            DateTime now = DateTime.Now;

            string shortTime = now.ToShortTimeString();
            string longTime = now.ToLongTimeString();

            string formatString = $"{shortTime}\n" +
                $"{longTime}\n" +
                $"";

            DateTime nowPlus7Months = now.AddMonths(7);

            TimeSpan differenceInDaysFor7Months = nowPlus7Months - now;

            runDisplay.Text = differenceInDaysFor7Months.Duration().ToString();
         
        }

        private void btnEnterBirthdate_Click(object sender, RoutedEventArgs e)
        {
            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);
        }
    }
}
// HW Questions:

