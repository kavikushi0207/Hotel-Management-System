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
using System.Data;

namespace GUI_Group_Project
{
    /// <summary>
    /// Interaction logic for Customer_Registration.xaml
    /// </summary>
    public partial class Customer_Registration : Window
    {
        Dmodel _db =new Dmodel();
       

        public Customer_Registration()
        {
            InitializeComponent();
            Load();
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
        private void Load()
        {
            CustomerDataGrid.ItemsSource = _db.Customers.ToList();
            
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            Customer newcustomer = new Customer()
            {
                First_Name = txtfname.Text,
                Second_Name =txtlname.Text,
                NIC = txtnic.Text,
                Contact_No = txtcontact.Text

            };
            _db.Customers.Add(newcustomer);
            _db.SaveChanges();
            CustomerDataGrid.ItemsSource = _db.Customers.ToList();
            MessageBox.Show("New customer is added successfully!");
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            int Id = (CustomerDataGrid.SelectedItem as Customer).CustomerId;
           

            Customer updateCustomer = (from c in _db.Customers
                                       where c.CustomerId == Id 
                                       select c).SingleOrDefault();

            updateCustomer.First_Name = txtfname.Text;
            updateCustomer.Second_Name = txtlname.Text;
            updateCustomer.NIC = txtnic.Text;
            updateCustomer.Contact_No = txtcontact.Text;

            _db.SaveChanges();
            CustomerDataGrid.ItemsSource = _db.Customers.ToList();
            MessageBox.Show("A customer is updated successfully!");
        }
       


        private void delete_Click(object sender, RoutedEventArgs e)
        {

            int Id = (CustomerDataGrid.SelectedItem as Customer).CustomerId;
            var deleteCustomer = _db.Customers.Where(c => c.CustomerId == Id).Single();
            _db.Customers.Remove(deleteCustomer);
            _db.SaveChanges();
            CustomerDataGrid.ItemsSource = _db.Customers.ToList();
            MessageBox.Show("A customer is deleted successfully!");
        }

        

        
    }
}
