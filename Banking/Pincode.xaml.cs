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
        Class1 class1 = new Class1();

        public double amount { get; set; }
        public int btnid { get; set; }
        public Pincode()
        {
            InitializeComponent();
            class1.getUserinfo();
        }

        private void updateBalance(double balance)
        {
            string[] arrLine = File.ReadAllLines("C:\\Users\\reg_encoder\\Documents\\Example.txt");
            arrLine[4 - 1] = "Balance: " + balance + ".00";
            File.WriteAllLines("C:\\Users\\reg_encoder\\Documents\\Example.txt", arrLine);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (btnid == 1)
            {
                string pincode = _1.Text + _2.Text + _3.Text + _4.Text + _5.Text + _6.Text;
                int pin = Convert.ToInt32(pincode);
;               int userpin = Convert.ToInt32(class1.userinfo[2]);
                double balance1 = Convert.ToDouble(class1.userinfo[3]) - amount;


                if (pin == userpin)
                {
                    using (StreamWriter writer = new StreamWriter("C:\\Users\\reg_encoder\\Documents\\Output.txt", true))
                    {
                        writer.WriteLine("\nUsername: " + class1.userinfo[0]);
                        writer.WriteLine("Amount Withdrawn: " + amount);
                        writer.WriteLine("Remaining Balance: " + balance1);
                        writer.WriteLine("Date: " + DateTime.Now);
                        writer.WriteLine("Transaction: Withdrawal");
                    }
                    updateBalance(balance1);

                    MessageBox.Show("Amount withdrawn successfully!", "Successful Transaction", MessageBoxButton.OK, MessageBoxImage.Information);

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
                string pincode = _1.Text + _2.Text + _3.Text + _4.Text + _5.Text + _6.Text;
                int pin = Convert.ToInt32(pincode);
                int userpin = Convert.ToInt32(class1.userinfo[2]);
                double balance2 = Convert.ToDouble(class1.userinfo[3]) + amount;
                if (pin == userpin)
                {
                    using (StreamWriter writer = new StreamWriter("C:\\Users\\reg_encoder\\Documents\\Output.txt", true))
                    {
                        
                        writer.WriteLine("Username: " + class1.userinfo[0]);
                        writer.WriteLine("Amount Withdrawn: " + amount);
                        writer.WriteLine("Remaining Balance: " + balance2);
                        writer.WriteLine("Date: " + DateTime.Now);
                        writer.WriteLine("Transaction: Deposit");
                        writer.WriteLine("");
                    }

                    updateBalance(balance2);

                    MessageBox.Show("Amount deposited successfully!", "Successful Transaction", MessageBoxButton.OK, MessageBoxImage.Information);

                    Homepage homepage = new Homepage();
                    homepage.Show();
                    this.Close();

                    
                }
            }

        }
    }
}
