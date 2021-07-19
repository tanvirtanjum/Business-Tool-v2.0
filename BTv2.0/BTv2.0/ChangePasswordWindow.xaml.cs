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
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Data;
using BTv2._0.entity;
using BTv2._0.repository;

namespace BTv2._0
{
    /// <summary>
    /// Interaction logic for ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        Login L;
        public ChangePasswordWindow()
        {
            ///InitializeComponent();
        }

        public ChangePasswordWindow(Login L)
        {
            this.L = L;
            InitializeComponent();
            userTB.Text = L.getLID();
        }

        private void saveBTN_Click(object sender, RoutedEventArgs e)
        {
            if ((string.IsNullOrEmpty(oldpassPB.Password.ToString()) == false && string.IsNullOrWhiteSpace(oldpassPB.Password.ToString()) == false) || (string.IsNullOrEmpty(newpassPB.Password.ToString()) == false && string.IsNullOrWhiteSpace(newpassPB.Password.ToString()) == false) || (string.IsNullOrEmpty(conpassPB.Password.ToString()) == false && string.IsNullOrWhiteSpace(conpassPB.Password.ToString()) == false)) 
            {
                if (newpassPB.Password.Length >= 4 && conpassPB.Password.Length == newpassPB.Password.Length)
                {
                   if(oldpassPB.Password.Equals(L.getPASS()))
                    {
                        if (newpassPB.Password.Equals(conpassPB.Password))
                        {
                            try
                            {
                                LoginRepo lr = new LoginRepo();
                                lr.updateLoginPass(userTB.Text, conpassPB.Password.ToString());
                                MessageBox.Show("LogIn Again.");
                                LogInWindow lw = new LogInWindow();
                                lw.Show();
                                this.Close();
                            }

                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                        else
                        {
                            MessageBox.Show("New Pass and Confirm Pass do not match");
                        }
                    }

                   else
                    {
                        MessageBox.Show("Fill Old Password Correctly");
                    }
                }

                else
                { 
                    MessageBox.Show("Fill Requirements"); 
                }
            }

            else
            {
                MessageBox.Show("Fill Correctly");
            }

        }

        private void discardBTN_Click(object sender, RoutedEventArgs e)
        {
            oldpassPB.Clear();
            newpassPB.Clear();
            conpassPB.Clear();

            oldpassTB.Clear();
            newpassTB.Clear();
            conpassTB.Clear();
        }

        private void backBTN_Click(object sender, RoutedEventArgs e)
        {
            AboutMeWindow amw = new AboutMeWindow(L);
            amw.Show();
            this.Close();
        }

        private void logoutBTN_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow lw = new LogInWindow();
            lw.Show();
            this.Close();
        }

        private void oldCB_Checked(object sender, RoutedEventArgs e)
        {
            oldpassTB.Text = oldpassPB.Password.ToString();
            oldpassPB.Visibility = Visibility.Hidden;
            oldpassTB.Visibility = Visibility.Visible;
        }

        private void newCB_Checked(object sender, RoutedEventArgs e)
        {
            newpassTB.Text = newpassPB.Password.ToString();
            newpassPB.Visibility = Visibility.Hidden;
            newpassTB.Visibility = Visibility.Visible;
        }

        private void conCB_Checked(object sender, RoutedEventArgs e)
        {
            conpassTB.Text = conpassPB.Password.ToString();
            conpassPB.Visibility = Visibility.Hidden;
            conpassTB.Visibility = Visibility.Visible;
        }

        private void oldCB_Unchecked(object sender, RoutedEventArgs e)
        {
            oldpassPB.Visibility = Visibility.Visible;
            oldpassTB.Visibility = Visibility.Hidden;
        }

        private void newCB_Unchecked(object sender, RoutedEventArgs e)
        {
            newpassPB.Visibility = Visibility.Visible;
            newpassTB.Visibility = Visibility.Hidden;
        }

        private void conCB_Unchecked(object sender, RoutedEventArgs e)
        {
            conpassPB.Visibility = Visibility.Visible;
            conpassTB.Visibility = Visibility.Hidden;
        }
    }
}
