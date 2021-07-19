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
    /// Interaction logic for ProductListWindow.xaml
    /// </summary>
    public partial class ProductListWindow : Window
    {
        Login L;
        public ProductListWindow()
        {
            ///InitializeComponent();
        }

        public ProductListWindow(Login L)
        {
            InitializeComponent();
            this.L = L;
            modifyTB.Text = L.getLID();
            updateBTN.IsEnabled = false;
            deleteBTN.IsEnabled = false;
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

        private void searchBTN_Click(object sender, RoutedEventArgs e)
        {
            ProductRepo pr = new ProductRepo();

            try
            {
                Product p = pr.getProduct(searchTB.Text);
                if (p != null)
                {
                    insertBTN.IsEnabled = false;
                    updateBTN.IsEnabled = true;
                    deleteBTN.IsEnabled = true;

                    idTB.IsEnabled = false;
                    idTB.Text = p.getPID();
                    nameTB.Text = p.getP_NAME();
                    typeTB.Text = p.getTYPE();
                    quantTB.Text = p.getQUANTITY().ToString();
                    buyTB.Text = p.getBUYPRICE().ToString();
                    sellTB.Text = p.getSELLPRICE().ToString();
                    modifyTB.Text = p.getMod_By().ToString();
                    adddateTB.Text = p.getAdd_PDate().ToString();

                }

                else
                {
                    MessageBox.Show("No Such Product");
                    idTB.Clear();
                    nameTB.Clear();
                    typeTB.Clear();
                    quantTB.Clear();
                    buyTB.Clear();
                    sellTB.Clear();
                    modifyTB.Text = L.getLID();
                    adddateTB.Text = "  Auto Generation ";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                idTB.Clear();
                nameTB.Clear();
                typeTB.Clear();
                quantTB.Clear();
                buyTB.Clear();
                sellTB.Clear();
                modifyTB.Text = L.getLID();
                adddateTB.Text = "  Auto Generation ";
            }
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

        private void refreshBTN_Click(object sender, RoutedEventArgs e)
        {
            insertBTN.IsEnabled = true;
            updateBTN.IsEnabled = false;
            deleteBTN.IsEnabled = false;

            idTB.IsEnabled = true;
            idTB.Clear();
            nameTB.Clear();
            typeTB.Clear();
            quantTB.Clear();
            buyTB.Clear();
            sellTB.Clear();
            modifyTB.Text = L.getLID();
            adddateTB.Text = "  Auto Generation ";
        }

        private void insertBTN_Click(object sender, RoutedEventArgs e)
        {
            if(L.getSID() == 1 || L.getSID() == 2)
            {
                if ((string.IsNullOrEmpty(idTB.Text) == false && string.IsNullOrEmpty(nameTB.Text) == false && string.IsNullOrEmpty(typeTB.Text) == false && string.IsNullOrEmpty(quantTB.Text) == false && string.IsNullOrEmpty(buyTB.Text) == false && string.IsNullOrEmpty(sellTB.Text) == false && string.IsNullOrEmpty(modifyTB.Text) == false) && (string.IsNullOrWhiteSpace(idTB.Text) == false && string.IsNullOrWhiteSpace(nameTB.Text) == false && string.IsNullOrWhiteSpace(typeTB.Text) == false && string.IsNullOrWhiteSpace(quantTB.Text) == false && string.IsNullOrWhiteSpace(buyTB.Text) == false && string.IsNullOrWhiteSpace(sellTB.Text) == false && string.IsNullOrWhiteSpace(modifyTB.Text) == false))
                {
                    ProductRepo pr = new ProductRepo();
                    Product check = pr.checkProduct(idTB.Text);

                    if (check == null)
                    {
                        Logic l = new Logic();

                        if (l.CheckIntNumber(quantTB.Text) == true && Convert.ToInt32(quantTB.Text) >= 0)
                        {
                            if (l.CheckNumber(buyTB.Text) == true && l.CheckNumber(sellTB.Text) == true)
                            {
                                double buy = Convert.ToDouble(buyTB.Text);
                                double sell = Convert.ToDouble(sellTB.Text);
                                if (buy >= 0 && sell >= 0)
                                {
                                    if (sell >= buy)
                                    {
                                        try
                                        {
                                            pr.insertProduct(idTB.Text, nameTB.Text, typeTB.Text, Convert.ToInt32(quantTB.Text), Convert.ToDouble(buyTB.Text), Convert.ToDouble(sellTB.Text), L.getLID());
                                            MessageBox.Show("Product Inserted.");
                                            showtableBTN_Click(sender, e);
                                        }

                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }

                                    else
                                    {
                                        MessageBox.Show("Selling Price should be greater or equals Buying Price");
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("Invalid Price");
                                }
                            }

                            else
                            {
                                MessageBox.Show("Invalid Price");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Invalid Quantity");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Try Another ID.");
                    }

                }

                else
                {
                    MessageBox.Show("Fill Up Properly.");
                }

            }

            else
            {
                MessageBox.Show("You are not allowed to perform this task");
            }
        }

        private void updateBTN_Click(object sender, RoutedEventArgs e)
        {
            if (L.getSID() == 1 || L.getSID() == 2)
            {
                if ((string.IsNullOrEmpty(idTB.Text) == false && string.IsNullOrEmpty(nameTB.Text) == false && string.IsNullOrEmpty(typeTB.Text) == false && string.IsNullOrEmpty(quantTB.Text) == false && string.IsNullOrEmpty(buyTB.Text) == false && string.IsNullOrEmpty(sellTB.Text) == false && string.IsNullOrEmpty(modifyTB.Text) == false) && (string.IsNullOrWhiteSpace(idTB.Text) == false && string.IsNullOrWhiteSpace(nameTB.Text) == false && string.IsNullOrWhiteSpace(typeTB.Text) == false && string.IsNullOrWhiteSpace(quantTB.Text) == false && string.IsNullOrWhiteSpace(buyTB.Text) == false && string.IsNullOrWhiteSpace(sellTB.Text) == false && string.IsNullOrWhiteSpace(modifyTB.Text) == false))
                {
                    ProductRepo pr = new ProductRepo();
                    Product check = pr.checkProduct(idTB.Text);

                    if (check != null)
                    {
                        Logic l = new Logic();

                        if (l.CheckIntNumber(quantTB.Text) == true && Convert.ToInt32(quantTB.Text) >= 0)
                        {
                            if (l.CheckNumber(buyTB.Text) == true && l.CheckNumber(sellTB.Text) == true)
                            {
                                double buy = Convert.ToDouble(buyTB.Text);
                                double sell = Convert.ToDouble(sellTB.Text);
                                if (buy >= 0 && sell >= 0)
                                {
                                    if (sell >= buy)
                                    {
                                        try
                                        {
                                            pr.updateProduct(idTB.Text, nameTB.Text, typeTB.Text, Convert.ToInt32(quantTB.Text), Convert.ToDouble(buyTB.Text), Convert.ToDouble(sellTB.Text), L.getLID());
                                            MessageBox.Show("Product Updated.");
                                            showtableBTN_Click(sender, e);
                                            searchBTN_Click(sender, e);
                                        }

                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }

                                    else
                                    {
                                        MessageBox.Show("Selling Price should be greater or equals Buying Price");
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("Invalid Price");
                                }
                            }

                            else
                            {
                                MessageBox.Show("Invalid Price");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Invalid Quantity");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Try Another ID.");
                    }

                }

                else
                {
                    MessageBox.Show("Fill Up Properly.");
                }
            }

            else
            {
                MessageBox.Show("You are not allowed to perform this task");
            }
        }
            
        private void deleteBTN_Click(object sender, RoutedEventArgs e)
        {
            if(L.getSID() == 1)
            {
                if(string.IsNullOrEmpty(idTB.Text) == false && string.IsNullOrWhiteSpace(idTB.Text) == false)
                {
                    ProductRepo pr = new ProductRepo();

                    try
                    {
                        pr.deleteProduct(idTB.Text);
                        MessageBox.Show("Product Deleted.");
                        refreshBTN_Click(sender, e);
                        showtableBTN_Click(sender, e);
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid ID.");
                }
            }

            else
            {
                MessageBox.Show("You are not allowed to perform this task.");
            }
        }
    }
}
