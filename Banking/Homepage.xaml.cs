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

namespace Banking
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Window
    {

        Class1 class1 = new Class1();
        public Homepage()
        {
            InitializeComponent();
            class1.getUserinfo();
            nameLbl.Content = class1.userinfo[0];
        }

        private void wbtn_Click(object sender, RoutedEventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Close();
        }

        private void dbtn_Click(object sender, RoutedEventArgs e)
        {
            Deposit depost = new Deposit();
            depost.Show();
            this.Close();
        }

        private void ibtn_Click(object sender, RoutedEventArgs e)
        {
            Inquire inquire = new Inquire();
            inquire.Show();
            this.Close();
        }
    }
}
