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
using System.Windows.Navigation;


namespace Dashboard
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String file = Path.Combine("A:\\File", txtdate.Text + ".txt");
          
            bool yes = File.Exists(file);

            if (yes && txtdate.Text !=""){


                String all = File.ReadAllText(file);

                txtWrite.Text = all;
            }
            else
            {
                MessageBox.Show("Enter Valid Date");
            }

            
        }
    }
}
