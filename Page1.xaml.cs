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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

           if( txtdate.Text != "" && txtWrite.Text !="")
            {
                dynamic date = txtdate.Text.ToString();
                String Write = txtWrite.Text.ToString();


                String file = Path.Combine("A:\\File", date + ".txt");
                bool yes = File.Exists(file);

                if (!yes)
                {
                    File.WriteAllText(file, Write);
                    MessageBoxResult result = MessageBox.Show("Succesfully Saved", "", MessageBoxButton.OK);
                    if (result == MessageBoxResult.OK)
                    {
                        txtdate.Text = "";
                        txtWrite.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Date Already Passes,Give Current date");
                }
            }
            else
            {
                MessageBox.Show("Pleasr Fill the Required Fields");
            }

           

        }
    }
}
