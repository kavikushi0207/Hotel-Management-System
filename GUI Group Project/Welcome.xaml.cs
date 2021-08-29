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
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            /*pbar.Visibility = Visibility.Visible;
            btnLoad.Content = "Loading...";
            pbar.Value = 0;
            Task.Run(() =>
            {
                for(int i=0;i<100;i++)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        pbar.Value = i;

                    }
                        );
                }
            }

                );*/
          
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();

        }
    }
}
