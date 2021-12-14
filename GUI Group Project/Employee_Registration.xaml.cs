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
using System.Data;

namespace GUI_Group_Project
{
    /// <summary>
    /// Interaction logic for Employee_Registration.xaml
    /// </summary>
    public partial class Employee_Registration : Window
    {
        dbmodel _db = new dbmodel();
        public Employee_Registration()
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

        private void ID_Emp(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Your Employer ID :");
        }
        private void Load()
        {
            EmpDataGrid.ItemsSource = _db.Employers.ToList();

        }
        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            Employer newemp = new Employer()
            {
            Firstname = Firstname.Text,
            Lastname = Lastname.Text,
            NIC = NIC.Text,
            Contact = Contact.Text,
            EmpRole = EmpRole.Text

            };
            _db.Employers.Add(newemp);
            _db.SaveChanges();
            EmpDataGrid.ItemsSource = _db.Employers.ToList();
            MessageBox.Show("New Employer is added successfully!");
        }
        private void btnupdte_Click(object sender, RoutedEventArgs e)
        {
            int Id = (EmpDataGrid.SelectedItem as Employer).EmployerID;


            Employer updateEmployer = (from em in _db.Employers
                                       where em.EmployerID == Id
                                       select em).Single();

            updateEmployer.Firstname = Firstname.Text;
            updateEmployer.Lastname = Lastname.Text;
            updateEmployer.NIC = NIC.Text;
            updateEmployer.Contact = Contact.Text;
            updateEmployer.EmpRole = EmpRole.Text;

            _db.SaveChanges();
            EmpDataGrid.ItemsSource = _db.Employers.ToList();
            MessageBox.Show("An employer is updated successfully!");
        }

        

        private void btndlt_Click(object sender, RoutedEventArgs e)
        {
            int Id = (EmpDataGrid.SelectedItem as Employer).EmployerID;
            var deleteEmployer = _db.Employers.Where(em => em.EmployerID == Id).Single();
            _db.Employers.Remove(deleteEmployer);
            _db.SaveChanges();
            EmpDataGrid.ItemsSource = _db.Employers.ToList();
            MessageBox.Show("An employer is deleted successfully!");
        }

       
    }
}
