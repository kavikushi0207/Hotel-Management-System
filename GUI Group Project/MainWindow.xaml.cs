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

namespace GUI_Group_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int accessLevel;
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtuser.Text == "c" && ppassword.Password == "c")
            {
                accessLevel = 1;
                if (accessLevel == 1)
                {
                    DashBoard db = new DashBoard();
                    db.Show();
                    db.imgaccess.Source = new BitmapImage(new Uri(@"images/cash.png", UriKind.Relative));
                    db.lblaccess.Content = db.lblaccess.Content + "Food Cashier";
                    //db.btnpay.IsEnabled = false;
                    db.btnreg.IsEnabled = false;
                    db.btnres.IsEnabled = false;
                    this.Close();
                }
            }
            else if (txtuser.Text == "r" && ppassword.Password == "r")
            {

                accessLevel = 2;
                if (accessLevel == 2)
                {
                    DashBoard db = new DashBoard();
                    db.Show();
                    db.imgaccess.Source = new BitmapImage(new Uri(@"images/r.png", UriKind.Relative));
                    db.lblaccess.Content = db.lblaccess.Content + "Hall Receptionist";
                    Registration reg = new Registration();
                    reg.btnemp.IsEnabled = false;
        
                    db.btnmenu.IsEnabled = false;
                    this.Close();
                }
            }
            else if (txtuser.Text == "a" && ppassword.Password == "a")
            {

                accessLevel = 3;
                if (accessLevel == 3)
                {
                    DashBoard db = new DashBoard();
                    db.Show();
                    db.imgaccess.Source = new BitmapImage(new Uri(@"images/owner.png",UriKind.Relative));
                    db.lblaccess.Content = db.lblaccess.Content + "Owner";
                    
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                txtuser.Clear();
                ppassword.Clear();
                txtuser1.Text = "Username";
                txtpassword.Text = "Password";
            }


        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ppassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            txtpassword.Text = "";
        }

        private void txtuser_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtuser1.Text = "";
        }
    }
}
