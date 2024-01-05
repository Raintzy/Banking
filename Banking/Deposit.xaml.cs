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
    /// Interaction logic for Deposit.xaml
    /// </summary>
    public partial class Deposit : Window
    {
        Class1 class1 = new Class1();

        public double balance, damount;

        public int btnid = 0;
        public Deposit()
        {
            InitializeComponent();
            class1.getUserinfo();
            blbl.Content = class1.userinfo[3];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pincode pincode = new Pincode();
            pincode.Show();
            this.Close();
        }
    }
}
