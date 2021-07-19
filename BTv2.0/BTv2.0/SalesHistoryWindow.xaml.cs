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
using BTv2._0.entity;
using BTv2._0.repository;
using BTv2._0.EssentialFunction;

namespace BTv2._0
{
    /// <summary>
    /// Interaction logic for SalesHistoryWindow.xaml
    /// </summary>
    public partial class SalesHistoryWindow : Window
    {
        Login L;
        public SalesHistoryWindow()
        {
            InitializeComponent();
        }

        public SalesHistoryWindow(Login L)
        {
            InitializeComponent();
            this.L = L;
        }

        private void backBTN_Click(object sender, RoutedEventArgs e)
        {
            SellProductWindow spw = new SellProductWindow(L);
            spw.Show();
            this.Close();
        }

        private void logoutBTN_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow lw = new LogInWindow();
            lw.Show();
            this.Close();
        }

        private void showtableBTN_Click(object sender, RoutedEventArgs e)
        {
            SalesRepo sr = new SalesRepo();
            try
            {
                salesDG.ItemsSource = sr.getTable().DefaultView;

                salesDG.Columns[0].Header = "Sales ID";
                salesDG.Columns[1].Header = "Product ID";
                salesDG.Columns[2].Header = "Selling Quantity";
                salesDG.Columns[3].Header = "Obtained Ammount";
                salesDG.Columns[4].Header = "Profit";
                salesDG.Columns[5].Header = "Customer Name";
                salesDG.Columns[6].Header = "Customer Contact";
                salesDG.Columns[7].Header = "Sold By";
                salesDG.Columns[8].Header = "Date";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBTN_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(searchTB.Text) == false && string.IsNullOrWhiteSpace(searchTB.Text) == false)
            {
                Logic l = new Logic();
                if(l.CheckIntNumber(searchTB.Text) == true)
                {
                    SalesRepo sr = new SalesRepo();

                    Sales s = sr.getSale(Convert.ToInt32(searchTB.Text));

                    if(s != null)
                    {
                        slidTB.Text = s.getSLID().ToString();
                        pidTB.Text = s.getPID();
                        quantTB.Text = s.getQUANT().ToString();
                        obtamntTB.Text = s.getOB_AMMOUNT().ToString();
                        profitTB.Text = s.getPROFIT().ToString();
                        cusnameTB.Text = s.getC_NAME();
                        cuscontactTB.Text = s.getC_MOB();
                        soldbyTB.Text = s.getSOLD_BY();
                        selldateTB.Text = s.getSell_SDate().ToString();
                    }

                    else
                    {
                        MessageBox.Show("No Such Sale.");
                    }
                }

                else
                {
                    MessageBox.Show("No Such Sale.");
                }
            }

            else
            {
                MessageBox.Show("Fill Correctly.");
            }
        }

        private void refreshBTN_Click(object sender, RoutedEventArgs e)
        {
            slidTB.Clear();
            pidTB.Clear();
            quantTB.Clear();
            obtamntTB.Clear();
            profitTB.Clear();
            cusnameTB.Clear();
            cuscontactTB.Clear();
            soldbyTB.Clear();
            selldateTB.Clear();
        }
    }
}
