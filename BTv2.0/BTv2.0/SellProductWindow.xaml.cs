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
    /// Interaction logic for SellProductWindow.xaml
    /// </summary>
    public partial class SellProductWindow : Window
    {
        Login L;
        public SellProductWindow()
        {
            InitializeComponent();
        }

        public SellProductWindow(Login L)
        {
            InitializeComponent();
            this.L = L;
            selleridTB.Text = L.getLID();
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

        private void sellBTN_Click(object sender, RoutedEventArgs e)
        {
           if(L.getSID() == 2 || L.getSID() == 3)
            {
                if (string.IsNullOrEmpty(pidTB.Text) == false && string.IsNullOrEmpty(pquantTB.Text) == false && string.IsNullOrEmpty(priceTB.Text) == false && string.IsNullOrEmpty(cusnameTB.Text) == false && string.IsNullOrEmpty(cusmobTB.Text) == false && string.IsNullOrWhiteSpace(pidTB.Text) == false && string.IsNullOrWhiteSpace(pquantTB.Text) == false && string.IsNullOrWhiteSpace(priceTB.Text) == false && string.IsNullOrWhiteSpace(cusnameTB.Text) == false && string.IsNullOrWhiteSpace(cusmobTB.Text) == false)
                {
                    ProductRepo pr = new ProductRepo();

                    Product p = pr.getProduct(pidTB.Text);

                    if (p != null)
                    {
                        Logic l = new Logic();

                        if (l.CheckIntNumber(pquantTB.Text) == true && l.CheckNumber(priceTB.Text) == true)
                        {
                            if (Convert.ToInt32(pquantTB.Text) > 0 && Convert.ToInt32(pquantTB.Text) <= p.getQUANTITY())
                            {
                                if (Convert.ToDouble(priceTB.Text) >= 0 && Convert.ToDouble(priceTB.Text) >= p.getBUYPRICE())
                                {
                                    if (Convert.ToDouble(priceTB.Text) <= p.getSELLPRICE())
                                    {
                                        SalesRepo sr = new SalesRepo();

                                        try
                                        {
                                            sr.insertSales(pidTB.Text, Convert.ToInt32(pquantTB.Text), l.getObtainedAmmout(Convert.ToInt32(pquantTB.Text), Convert.ToDouble(priceTB.Text)), l.getProfit(Convert.ToInt32(pquantTB.Text), Convert.ToDouble(priceTB.Text), p.getBUYPRICE()), cusnameTB.Text, cusmobTB.Text, selleridTB.Text);
                                            pr.updateProductOnSell(pidTB.Text, l.getNewQuantity(p.getQUANTITY(), Convert.ToInt32(pquantTB.Text)));

                                            MessageBox.Show("Succesfully Sold.\nPurchase ID: " + sr.getLastID() + "\n\nTake Recit.");

                                            string recit = "Purchase ID: " + sr.getLastID() + "\nProduct ID: " + pidTB.Text + "\nQuantity: " + pquantTB.Text + "\nPrice (/unit): " + priceTB.Text + " BDT" + "\nCustomer Name :" + cusnameTB.Text + "\nCustomer Contact: " + cusmobTB.Text + "\nSold By: " + selleridTB.Text + "\nDate: " + sr.getDateTime(sr.getLastID()) + "\n\nAmmount To Pay:" + l.getObtainedAmmout(Convert.ToInt32(pquantTB.Text), Convert.ToDouble(priceTB.Text)) + " BDT" + "\n\n\n--------------------\nSignature";

                                            PrintText pt = new PrintText();

                                            pt.SaveRecit(sr.getLastID().ToString(), recit);
                                        }

                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }

                                    }

                                    else
                                    {
                                        MessageBox.Show("Not Selled.\nOver Priced.");
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("Can't sell on loss.");
                                }
                            }

                            else
                            {
                                MessageBox.Show("Invalid Quantity Ammount.");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Check Number Fields Again.");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid Product.");
                    }
                }

                else
                {
                    MessageBox.Show("Fill Properly.");
                }
            }

           else
            {
                MessageBox.Show("You are not allowed to perform this task.");
            }
        }

        private void discardBTN_Click(object sender, RoutedEventArgs e)
        {
            pidTB.Clear();
            pquantTB.Clear();
            priceTB.Clear();
            cusnameTB.Clear();
            cusmobTB.Clear();
        }

        private void showtableBTN_Click(object sender, RoutedEventArgs e)
        {
            ProductRepo pr = new ProductRepo();
            try
            {
                prodDG.ItemsSource = pr.getTable().DefaultView;

                prodDG.Columns[0].Header = "ID";
                prodDG.Columns[1].Header = "Name";
                prodDG.Columns[2].Header = "Type";
                prodDG.Columns[3].Header = "Quantity";
                prodDG.Columns[4].Header = "Buying Price";
                prodDG.Columns[5].Header = "Selling Price";
                prodDG.Columns[6].Header = "Modified By";
                prodDG.Columns[7].Header = "Adding Date";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchbytypeBTN_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(searchbytypeTB.Text) == false && string.IsNullOrWhiteSpace(searchbytypeTB.Text) == false)
            {
                ProductRepo pr = new ProductRepo();

                Product ck = pr.checkProductByType(searchbytypeTB.Text);
                
                if(ck != null)
                {
                    try
                    {
                        prodDG.ItemsSource = pr.getTableByType(searchbytypeTB.Text).DefaultView;

                        prodDG.Columns[0].Header = "ID";
                        prodDG.Columns[1].Header = "Name";
                        prodDG.Columns[2].Header = "Type";
                        prodDG.Columns[3].Header = "Quantity";
                        prodDG.Columns[4].Header = "Buying Price";
                        prodDG.Columns[5].Header = "Selling Price";
                        prodDG.Columns[6].Header = "Modified By";
                        prodDG.Columns[7].Header = "Adding Date";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid Type.");
                }
            }

            else
            {
                MessageBox.Show("Type Correctly.");
            }
        }

        private void saleshistoryBTN_Click(object sender, RoutedEventArgs e)
        {
            SalesHistoryWindow shw = new SalesHistoryWindow(L);
            shw.Show();
            this.Close();
        }
    }
}
