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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String builder = "";
            char[] chars = { '@', '.' };
            String Mail = txtNMail.Text;
            char[] Mai = Mail.ToCharArray();
            char[] Pass = txtCPass.Password.ToCharArray();

            for (int i = 0; i < Mail.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (Mail[i] == chars[j])
                    {

                        builder = "OK";

                    }

                }
            }

            if (txtname.Text != "" && txtNMail.Text != "" && txtCPass.Password != "" && builder == "OK" && Pass.Length > 5)
            {
                Settings settings = new Settings();
                settings.Name = txtname.Text;
                settings.Mail = txtNMail.Text;
                settings.Password = txtCPass.Password;
                settings.Save();

                MessageBox.Show("Account Successfully Created");
                txtname.Text = "";
                txtNMail.Text = "";
                txtCPass.Password = "";
            }
            else
            {
                MessageBox.Show("Please Give Valid Details");
            }

        
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {

        Settings settings = new Settings();

        if (txtMail.Text == settings.Mail && txtPass.Password == settings.Password)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
        else
        {
            MessageBox.Show("Please Enter Valid Mail ID and Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }

}
    }

