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
    /// Interaction logic for Restaurant_Menu.xaml
    /// </summary>
    public partial class Restaurant_Menu : Window
    {

        dbmodel _db = new dbmodel();
        public Restaurant_Menu()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            
          ItemDataGrid.ItemsSource = _db.MenuItems.ToList();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add_New_Menu_Item addmenu = new Add_New_Menu_Item();
            addmenu.Show();
            this.Close();
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

        
    }
}
