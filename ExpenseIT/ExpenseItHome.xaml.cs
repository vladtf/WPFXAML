using ExpenseIT.Models;
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

namespace ExpenseIT
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        //Definesc o lista de persoane.
        private List<PersonModel> people;
        public ExpenseItHome()
        {
            InitializeComponent();

            //Populez lista de persone cu datele din baza de date.
            people = DataAcces.GetPeople();


            //Setez sursa de data pentru peopleListBox
            peopleListBox.ItemsSource = people;

            //Definesc membrul afisast (first_name,last_name,id ... )
            peopleListBox.DisplayMemberPath = "last_name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);

        }
    }
}
