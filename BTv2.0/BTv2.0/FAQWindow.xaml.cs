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

namespace BTv2._0
{
    /// <summary>
    /// Interaction logic for FAQWindow.xaml
    /// </summary>
    public partial class FAQWindow : Window
    {
        Login L;
        public FAQWindow()
        {
            ///InitializeComponent();
        }

        public FAQWindow(Login L)
        {
            InitializeComponent();
            this.L = L;
        }

        private void backBTN_Click(object sender, RoutedEventArgs e)
        {
            OptionWindow ow = new OptionWindow(L);
            ow.Show();
            this.Close();
        }
    }
}
