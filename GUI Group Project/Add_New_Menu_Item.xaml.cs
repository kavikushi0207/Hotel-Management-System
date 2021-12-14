
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
    /// Interaction logic for Add_New_Menu_Item.xaml
    /// </summary>
    public partial class Add_New_Menu_Item : Window
    {
        dbmodel _db = new dbmodel();

        public Add_New_Menu_Item()
        {
            InitializeComponent();
           
        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
       
        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            Restaurant_Menu menu = new Restaurant_Menu();
            menu.Show();
            this.Close();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            Restaurant_Menu rm = new Restaurant_Menu();
            MenuItem newitem = new MenuItem()
            {
                Meal_Type = cmbmealtype.Text,
                Item_Type = cmbitemtype.Text,
                Item_Name = txtname.Text,
              Item_Price = txtprice.Text

            };
            _db.MenuItems.Add(newitem);
            _db.SaveChanges();
            rm.ItemDataGrid.ItemsSource = _db.MenuItems.ToList();
            MessageBox.Show("New Item is added successfully!");
            txtname.Clear();
            txtprice.Clear();
            cmbitemtype.Text = "";
            cmbmealtype.Text = "";
        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            Restaurant_Menu menu = new Restaurant_Menu();
            menu.Show();
            this.Close();
        }
    }
}
