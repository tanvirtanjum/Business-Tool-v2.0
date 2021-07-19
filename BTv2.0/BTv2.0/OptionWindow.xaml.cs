using System;
using System.Windows;
using System.Windows.Threading;
using BTv2._0.entity;

namespace BTv2._0
{
    /// <summary>
    /// Interaction logic for OptionWindow.xaml
    /// </summary>
    public partial class OptionWindow : Window
    {
        
        Login L;
        public OptionWindow()
        {
            //InitializeComponent();
        }

        public OptionWindow(Login L)
        {
            this.L = L;

            InitializeComponent();

            aboutmeLBL.Content = L.getLID();

            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void emplistBTN_Click(object sender, RoutedEventArgs e)
        {
            EmpListWindow elw = new EmpListWindow(L);
            elw.Show();
            this.Close();
        }

        private void productlistBTN_Click(object sender, RoutedEventArgs e)
        {
            ProductListWindow plw = new ProductListWindow(L);
            plw.Show();
            this.Close();
        }

        private void sellproductBTN_Click(object sender, RoutedEventArgs e)
        {
            SellProductWindow spw = new SellProductWindow(L);
            spw.Show();
            this.Close();
        }

        private void takenotesBTN_Click(object sender, RoutedEventArgs e)
        {
            TakeNoteWindow tnw = new TakeNoteWindow(L);
            tnw.Show();
            this.Close();
        }

        private void aboutmeBTN_Click(object sender, RoutedEventArgs e)
        {
            AboutMeWindow amw = new AboutMeWindow(L);
            amw.Show();
            this.Close();
        }

        private void faqBTN_Click(object sender, RoutedEventArgs e)
        {
            FAQWindow fw = new FAQWindow(L);
            this.Close();
            fw.Show();
        }

        private void logoutBTN_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow liw = new LogInWindow();
            liw.Show();
            this.Close();
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            
            clockLBL.Content = d.ToString("dd") + " " + d.ToString("MMMM") + ", " + d.Year + "\n" + d.DayOfWeek + "\n" + d.ToString("T");
        }
    }
}
