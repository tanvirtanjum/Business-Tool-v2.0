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
    /// Interaction logic for AboutMeWindow.xaml
    /// </summary>
    public partial class AboutMeWindow : Window
    {
        Login L;
        public AboutMeWindow()
        {
            ///InitializeComponent();
        }

        public AboutMeWindow(Login L)
        {
            InitializeComponent();
            this.L = L;

            EmployeeRepo er = new EmployeeRepo();

            Employee e = er.getEmployee(L.getLID());

            idTB.Text = e.getEmpID().ToString();
            nameTB.Text = e.getE_NAME();
            if (e.getDID() == 1)
            {
                disgTB.Text = "ADMIN";
            }

            else if(e.getDID() == 2)
            {
                disgTB.Text = "MANAGER";
            }

            else if(e.getDID() == 3)
            {
                disgTB.Text = "SALESMAN";
            }
            
            else
            {
                disgTB.Text = "UNKNOWN";
            }
            salTB.Text = e.getSAL().ToString();
            mobileTB.Text = e.getE_MOB();
            joindateTB.Text = e.getJoin_Date().ToString();
            addedbyTB.Text = e.getAdded_By();
        }
        private void changepassBTN_Click(object sender, RoutedEventArgs e)
        {
            ChangePasswordWindow cpw = new ChangePasswordWindow(L);
            cpw.Show();
            this.Close();
        }

        private void backBTN_Click(object sender, RoutedEventArgs e)
        {
            OptionWindow ow = new OptionWindow(L);
            ow.Show();
            this.Close();
        }

        private void logoutBTN_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow lw = new LogInWindow();
            lw.Show();
            this.Close();
        }
    }
}
