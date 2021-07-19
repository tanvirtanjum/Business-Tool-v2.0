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
    /// Interaction logic for TakeNoteWindow.xaml
    /// </summary>
    public partial class TakeNoteWindow : Window
    {
        Login L;
        public TakeNoteWindow()
        {
            ///InitializeComponent();
        }

        public TakeNoteWindow(Login L)
        {
            InitializeComponent();
            deleteBTN.IsEnabled = false;
            this.L = L;
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

        private void showtableBTN_Click(object sender, RoutedEventArgs e)
        {
            NoteRepo er = new NoteRepo();
            try
            {
                noteDG.ItemsSource = er.getTable(L.getLID()).DefaultView;

                noteDG.Columns[0].Header = "Note ID";
                noteDG.Columns[1].Header = "Notes Name";
                noteDG.Columns[2].Header = "Owner ID";
                noteDG.Columns[0].Width = 70;
                noteDG.Columns[1].Width = 140;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void loadBTN_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(noteidTB.Text) == false && string.IsNullOrWhiteSpace(noteidTB.Text) == false)
            {
                Logic l = new Logic();
                if(l.CheckIntNumber(noteidTB.Text) == true)
                {
                    NoteRepo nr = new NoteRepo();
                    
                    try
                    {
                        Note n = nr.getNote(Convert.ToInt32(noteidTB.Text), L.getLID());

                        if (n != null)
                        {
                            savebynameTB.Text = n.getNoteName();
                            noteTB.Text = n.getText();
                            noteidTB.IsEnabled = false;
                            deleteBTN.IsEnabled = true;
                        }

                        else
                        {
                            MessageBox.Show("Open Your Own Note. \nCheck Note ID Again.");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("Invalid Note ID.");
                }
            }

            else
            {
                MessageBox.Show("Fill Note ID. Field Properly.");
            }
        }

        private void refreshBTN_Click(object sender, RoutedEventArgs e)
        {
            noteTB.Clear();
            noteidTB.Clear();
            noteidTB.IsEnabled = true;
            savebynameTB.Clear();

            deleteBTN.IsEnabled = false;
        }

        private void uploadBTN_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(savebynameTB.Text) == false && string.IsNullOrWhiteSpace(savebynameTB.Text) == false)
            {
                if(string.IsNullOrWhiteSpace(noteTB.Text) == false && string.IsNullOrEmpty(noteTB.Text) == false)
                {
                    NoteRepo nr = new NoteRepo();

                    try
                    {
                        nr.insertNote(savebynameTB.Text, L.getLID(), noteTB.Text);
                        MessageBox.Show("Note Successfully Uploaded.");
                        showtableBTN_Click(sender, e);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("Write Something.");
                }
            }

            else
            {
                MessageBox.Show("Saving Name Required.");
            }
        }

        private void updateBTN_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(savebynameTB.Text) == false && string.IsNullOrWhiteSpace(savebynameTB.Text) == false)
            {
                if (string.IsNullOrWhiteSpace(noteTB.Text) == false && string.IsNullOrEmpty(noteTB.Text) == false)
                {
                    NoteRepo nr = new NoteRepo();

                    try
                    {
                        nr.updateNote(Convert.ToInt32(noteidTB.Text), savebynameTB.Text, noteTB.Text, L.getLID());
                        MessageBox.Show("Successfully Updated");
                        showtableBTN_Click(sender, e);
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("Write Something.");
                }
            }

            else
            {
                MessageBox.Show("Saving Name Required.");
            }
        }

        private void printBTN_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(noteTB.Text) == false && string.IsNullOrEmpty(noteTB.Text) == false)
            {
                PrintText pt = new PrintText();
                try
                {
                    pt.SaveFile(noteTB.Text);
                    ///MessageBox.Show("Printed.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Nothing To Print.");
            }
        }

        private void deleteBTN_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(noteidTB.Text) == false && string.IsNullOrEmpty(noteidTB.Text) == false)
            {
                NoteRepo nr = new NoteRepo();

                try
                {
                    nr.deleteNote(Convert.ToInt32(noteidTB.Text), L.getLID());
                    MessageBox.Show("Note Successfully Deleted.");
                    noteTB.Clear();
                    noteidTB.Clear();
                    noteidTB.IsEnabled = true;
                    savebynameTB.Clear();
                    showtableBTN_Click(sender, e);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Invalid NoteID.");
            }
        }
    }
}
