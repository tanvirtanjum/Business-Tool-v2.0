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
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Data;
using BTv2._0.entity;
using BTv2._0.repository;

namespace BTv2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        Login L = new Login();
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void showpassCB_Checked(object sender, RoutedEventArgs e)
        {
            passTB.Text = passPB.Password.ToString();
            passPB.Visibility = Visibility.Hidden;
            passTB.Visibility = Visibility.Visible;

        }

        private void showpassCB_Unchecked(object sender, RoutedEventArgs e)
        {
            passTB.Visibility = Visibility.Hidden;
            passPB.Visibility = Visibility.Visible;

        }
        private void loginBTN_Click(object sender, RoutedEventArgs e)
        {
            LoginRepo lr = new LoginRepo();
            
            try
            {
                L = lr.getLogin(lidTB.Text, passPB.Password.ToString());

                if (L != null)
                {
                    OptionWindow ow = new OptionWindow(L);
                    ow.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Check ID. and Password");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
