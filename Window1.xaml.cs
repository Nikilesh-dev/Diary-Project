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

namespace Dashboard
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Page1 Page1 = new Page1();
            frame.Content = Page1;
           Settings settings   = new Settings();
            lblmail.Content = settings.Mail;
            lblname.Content = settings.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2(); 
            frame.Content = page2;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 Page1 = new Page1();
            frame.Content = Page1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page3 Page3 = new Page3();
            frame.Content = Page3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            Page4 Page4 = new Page4();
            frame.Content = Page4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Page5 Page5 = new Page5();
            frame.Content = Page5;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
         MessageBoxResult result =   MessageBox.Show("Are you Sure You want to Logout ?", "LOGOUT", MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
