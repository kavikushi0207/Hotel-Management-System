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
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Window
    {
        public DashBoard()
        {
            InitializeComponent();
        }

     

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            login.txtpassword.Clear();
            login.txtuser.Clear();
            this.Close();

        }

        

        private void btnmenu_Click(object sender, RoutedEventArgs e)
        {
            Restaurant_Menu menu = new Restaurant_Menu();
            menu.Show();
            this.Close();
        }

        private void btnres_Click(object sender, RoutedEventArgs e)
        {
            Reservation res = new Reservation();
            res.Show();
            this.Close();
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }

        private void btnpay_Click(object sender, RoutedEventArgs e)
        {
            Payments pay = new Payments();
            pay.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
