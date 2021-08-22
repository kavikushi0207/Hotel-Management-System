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
using System.Windows.Shapes;

namespace GUI_Group_Project
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Close();

        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btncus_Click(object sender, RoutedEventArgs e)
        {
            Customer_Registration cr = new Customer_Registration();
            cr.Show();
            this.Close();
        }

       

        private void btnemp_Click_1(object sender, RoutedEventArgs e)
        {
            Employee_Registration er = new Employee_Registration();
            er.Show();
            this.Close();
        }
    }
}
