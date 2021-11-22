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
using System.Data.SqlClient;

namespace GUI_Group_Project
{
    /// <summary>
    /// Interaction logic for Customer_Registration.xaml
    /// </summary>
    public partial class Customer_Registration : Window
    {
        public Customer_Registration()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Close();
        }

      
    }
}
