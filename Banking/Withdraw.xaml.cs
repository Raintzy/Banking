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
    /// Interaction logic for Withdraw.xaml
    /// </summary>
    public partial class Withdraw : Window
    {
        Class1 class1 = new Class1();

        public double balance, wamount;


        public Withdraw()
        {
            InitializeComponent();
            class1.getUserinfo();
            blbl.Content = class1.userinfo[3];
            balance = Convert.ToDouble(blbl.Content);
            
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (wtbx.Text == "")
            {
                wtbx.Text = "0";
            }
            wamount = Convert.ToInt32(wtbx.Text);
            if (wamount > balance)
            {
                MessageBox.Show("Insufficient Balance!", "Transaction Error", MessageBoxButton.OK, MessageBoxImage.Error);
                wbtn.IsEnabled = false;
            }
            else if (wamount > 0)
            {
                wbtn.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pincode pincode = new Pincode();
            pincode.amount = Convert.ToDouble(wtbx.Text);
            pincode.btnid = 1;
            pincode.Show();
            this.Close();
        }

        private void wtbx_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void wtbx_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
