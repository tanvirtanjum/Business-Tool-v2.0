using BTv2._0.entity;
using BTv2._0.repository;
using System;
using System.Windows;
using BTv2._0.EssentialFunction;


namespace BTv2._0
{
    /// <summary>
    /// Interaction logic for EmpListWindow.xaml
    /// </summary>
    public partial class EmpListWindow : Window
    {
        Login L;
        public EmpListWindow()
        {
            ///InitializeComponent();
        }

        public EmpListWindow(Login L)
        {
            InitializeComponent();
            this.L = L;
            addbyTB.Text = L.getLID();
            updateBTN.IsEnabled = false;
            deleteBTN.IsEnabled = false;
        }

        private void searchBTN_Click(object sender, RoutedEventArgs e)
        {
            EmployeeRepo er = new EmployeeRepo();

            try
            {
                Employee emp = er.getEmployee(searchidTB.Text);
                if (emp != null)
                {
                    insertBTN.IsEnabled = false;
                    updateBTN.IsEnabled = true;
                    deleteBTN.IsEnabled = true;

                    empidTB.IsEnabled = false;
                    empidTB.Text = emp.getEmpID();
                    empnameTB.Text = emp.getE_NAME();
                    desigCB.SelectedIndex = emp.getDID();
                    salaryTB.Text = emp.getSAL().ToString();
                    mobTB.Text = emp.getE_MOB();
                    joindateTB.Text = emp.getJoin_Date().ToString();
                    addbyTB.Text = emp.getAdded_By().ToString();

                }

                else
                {
                    MessageBox.Show("No Such User");
                    empidTB.Clear();
                    empnameTB.Clear();
                    desigCB.SelectedIndex = 0;
                    salaryTB.Clear();
                    mobTB.Clear();
                    joindateTB.Text = "           Auto Generation ";
                    addbyTB.Text = L.getLID();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                empidTB.Text = null;
                empnameTB.Text = null;
                desigCB.SelectedIndex = 0;
                salaryTB.Text = null;
                mobTB.Text = null;
                joindateTB.Text = "           Auto Generation ";
                addbyTB.Text = null;
            }
            
        }

        private void refreshBTN_Click(object sender, RoutedEventArgs e)
        {
            insertBTN.IsEnabled = true;
            updateBTN.IsEnabled = false;
            deleteBTN.IsEnabled = false;

            empidTB.IsEnabled = true;
            searchidTB.Text = null;
            empidTB.Text = null;
            empnameTB.Text = null;
            desigCB.SelectedIndex = 0;
            salaryTB.Text = null;
            mobTB.Text = null;
            joindateTB.Text = "           Auto Generation ";
            addbyTB.Text = L.getLID();
        }

        private void insertBTN_Click(object sender, RoutedEventArgs e)
        {
            LoginRepo lcheckuser = new LoginRepo();
            EmployeeRepo echeckuser = new EmployeeRepo(); 
            Login luser = lcheckuser.checkUser(empidTB.Text);
            Employee euser = echeckuser.checkUser(empidTB.Text);

            if (L.getSID() == 1)
            {
                if (luser == null && euser == null)
                {
                    if ((string.IsNullOrEmpty(empidTB.Text) == false) && (string.IsNullOrWhiteSpace(empidTB.Text) == false) && (string.IsNullOrEmpty(empnameTB.Text) == false) && (string.IsNullOrWhiteSpace(empnameTB.Text) == false) && (desigCB.SelectedIndex != 0) && (string.IsNullOrEmpty(salaryTB.Text )== false) && (string.IsNullOrWhiteSpace(salaryTB.Text) == false) && (string.IsNullOrEmpty(mobTB.Text) == false) && (string.IsNullOrWhiteSpace(mobTB.Text) == false))
                    {
                        Logic numberCheck = new Logic();
                        if(numberCheck.CheckNumber(salaryTB.Text) == true)
                        {
                            if (Convert.ToDouble(salaryTB.Text) > 0)
                            {
                                if (mobTB.Text.Length > 10 && mobTB.Text.Length < 15)
                                {
                                    LoginRepo lr = new LoginRepo();
                                    EmployeeRepo er = new EmployeeRepo();
                                    PasswordGenerator pg = new PasswordGenerator();
                                    string pass = pg.Password();

                                    try
                                    {
                                        lr.insertLogin(empidTB.Text, desigCB.SelectedIndex, pass);
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }

                                    try
                                    {
                                        er.insertEmployee(empidTB.Text, empnameTB.Text, desigCB.SelectedIndex, Convert.ToDouble(salaryTB.Text), mobTB.Text, addbyTB.Text);
                                        MessageBox.Show("Employee Assigned." + "\nLogIn ID.: " + empidTB.Text + "\nPassword: " + pass + "");
                                        showtableBTN_Click(sender, e);
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        try
                                        {
                                            lr.deleteLogin(empidTB.Text);
                                            MessageBox.Show("LogIn Access Deleted.");
                                        }

                                        catch (Exception exp)
                                        {
                                            MessageBox.Show(exp.Message);
                                        }
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("Fill Contact Number Correctly.");
                                }
                            }

                            else
                            {
                                MessageBox.Show("Invalid Salary.");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Correct Salary.");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Fill Correctly");

                    }
                }

                else
                {
                    MessageBox.Show("Try again with another Employee ID.");
                }
            }

            else
            {
                MessageBox.Show("You are not allowed do this operation");
            }
        }

        private void updateBTN_Click(object sender, RoutedEventArgs e)
        {
            updateBTN.IsEnabled = false;
            deleteBTN.IsEnabled = false;

            LoginRepo lcheckuser = new LoginRepo();
            EmployeeRepo echeckuser = new EmployeeRepo();
            Login luser = lcheckuser.checkUser(empidTB.Text);
            Employee euser = echeckuser.checkUser(empidTB.Text);

            if (L.getSID() == 1)
            {
                if (luser != null && euser != null)
                {
                    if ((string.IsNullOrEmpty(empidTB.Text) == false) && (string.IsNullOrWhiteSpace(empidTB.Text) == false) && (string.IsNullOrEmpty(empnameTB.Text) == false) && (string.IsNullOrWhiteSpace(empnameTB.Text) == false) && (desigCB.SelectedIndex != 0) && (string.IsNullOrEmpty(salaryTB.Text) == false) && (string.IsNullOrWhiteSpace(salaryTB.Text) == false) && (string.IsNullOrEmpty(mobTB.Text) == false) && (string.IsNullOrWhiteSpace(mobTB.Text) == false))
                    {
                        Logic numberCheck = new Logic();
                        if (numberCheck.CheckNumber(salaryTB.Text) == true)
                        {
                            if (Convert.ToDouble(salaryTB.Text) > 0)
                            {
                                if (mobTB.Text.Length > 10 && mobTB.Text.Length < 15)
                                {
                                    LoginRepo lr = new LoginRepo();
                                    EmployeeRepo er = new EmployeeRepo();
                                    
                                    try
                                    {
                                        lr.updateLoginSID(empidTB.Text, desigCB.SelectedIndex);
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }

                                    try
                                    {
                                        er.updateEmployee(empidTB.Text, empnameTB.Text, desigCB.SelectedIndex, Convert.ToDouble(salaryTB.Text), mobTB.Text);
                                        MessageBox.Show("Information Updated");
                                        showtableBTN_Click(sender, e);
                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }

                                else
                                {
                                    MessageBox.Show("Fill Contact Number Correctly.");
                                }
                            }

                            else
                            {
                                MessageBox.Show("Invalid Salary.");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Correct Salary.");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Fill Correctly");

                    }
                }

                else
                {
                    MessageBox.Show("User Not Exist.");
                }
            }

            else
            {
                MessageBox.Show("You are not allowed do this operation");
            }

        }

        private void deleteBTN_Click(object sender, RoutedEventArgs e)
        {
            if(L.getSID()==1)
            {
                if(!L.getLID().Equals(empidTB.Text))
                {
                    LoginRepo lr = new LoginRepo();
                    EmployeeRepo er = new EmployeeRepo();

                    try
                    {
                        er.deleteEmployee(empidTB.Text);
                        lr.deleteLogin(empidTB.Text);

                        MessageBox.Show("User Deleted.");
                        showtableBTN_Click(sender, e);
                        refreshBTN_Click(sender, e);

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("Self Destruction Not Allowed.");
                }
            }
        }

        private void showtableBTN_Click(object sender, RoutedEventArgs e)
        {
            EmployeeRepo er = new EmployeeRepo();
            try
            {
                empDG.ItemsSource = er.getTable().DefaultView;

                empDG.Columns[0].Header = "ID";
                empDG.Columns[1].Header = "Name";
                empDG.Columns[2].Header = "Desig. ID";
                empDG.Columns[3].Header = "Salary";
                empDG.Columns[4].Header = "Mobile No";
                empDG.Columns[5].Header = "Join Date";
                empDG.Columns[6].Header = "Added by";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
