using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Banking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 class1 = new Class1();

        public MainWindow()
        {
            InitializeComponent();
            class1.getUserinfo();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (unameTbx.Text == class1.userinfo[0] && passTbx.Password == class1.userinfo[1])
            {
                Homepage home = new Homepage();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, try again!", "Login error", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}
