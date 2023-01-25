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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        Settings settings = new Settings();
        public Page3()
        {
            InitializeComponent();
            txtname.Text = settings.Name;
            txtmail.Text = settings.Mail;
            txtPass.Text= settings.Password;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)


        {

            if(txtPass1.Password == settings.Password)
            {
                Settings settings = new Settings();
                settings.Name = txtname.Text;
                settings.Mail = txtmail.Text;
                settings.Password = txtPass.Text;
                 settings.Save();

             MessageBoxResult result =   MessageBox.Show("Your Profile Details Updated","",MessageBoxButton.OK);

                

              
                

            }
            else
            {
                MessageBox.Show("Please Enter Valid Password","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }

            Window1 window1 = new Window1();
            window1.lblname.Content = txtname.Text;
            window1.lblmail.Content = txtmail.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtname.IsReadOnly= false;

         }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            txtmail.IsReadOnly = false;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            txtPass.IsReadOnly = false;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
