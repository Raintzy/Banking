using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Pincode.xaml
    /// </summary>
    public partial class Pincode : Window
    {
        Withdraw withdraw = new Withdraw();
        Deposit deposit = new Deposit();
        Class1 class1 = new Class1();

        public double amount { get; set; }
        public int btnid { get; set; }
        public Pincode()
        {
            InitializeComponent();
            class1.getUserinfo();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (btnid == 1)
            {
                string pincode = _1.Text + _2.Text + _3.Text + _4.Text + _5.Text + _6.Text;
                int pin = Convert.ToInt32(pincode);
;                int userpin = Convert.ToInt32(class1.userinfo[2]);
                if (pin == userpin)
                {
                    using (StreamWriter writer = new StreamWriter("C:\\Users\\oscar\\Documents\\Output.txt"))
                    {
                        writer.WriteLine("Username: " + class1.userinfo[0]);
                        writer.WriteLine("Amount Withdrawn: " + amount);
                        writer.WriteLine("Remaining Balance: " + (Convert.ToDouble(class1.userinfo[3]) - amount));
                        writer.WriteLine("Date: " + DateTime.Now);
                        writer.WriteLine("Transaction: Withdrawal");
                    }
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    this.Close();

                }
                else {
                    MessageBox.Show("Okay!");
                }
            }
            else if (btnid == 2)
            {
                int pin = Convert.ToInt32(_1.Text) + Convert.ToInt32(_2.Text) + Convert.ToInt32(_3.Text)
                    + Convert.ToInt32(_4.Text) + Convert.ToInt32(_5.Text) + Convert.ToInt32(_6.Text);
                int userpin = Convert.ToInt32(class1.userinfo[2]);
                if (pin == userpin)
                {

                }
            }

        }
    }
}
