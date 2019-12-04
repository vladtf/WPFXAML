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
    /// Interaction logic for ExpenseReportPage.xaml
    /// </summary>
    public partial class ExpenseReportPage : Page
    {
        public ExpenseReportPage()
        {
            InitializeComponent();


        }

        // Custom constructor to pass expense report data
        public ExpenseReportPage(object data) : this()
        {
            // Datele primite sunt transformate in PersonModel
            PersonModel person = (PersonModel) data;


            //Definim datele care vor fi afisate.
            nameLabel.Content = person.FullName;
            departmentLabel.Content = person.email;

        }

    }
}
