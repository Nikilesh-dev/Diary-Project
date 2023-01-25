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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtDate.Text != "" && txtelec.Text != "" && txthouse.Text != "" && txtmedical.Text != "" && txtothers.Text != "")
            {
                String Expense = "Electricity Expenses :  " + txtelec.Text + System.Environment.NewLine + System.Environment.NewLine +
                                 "Medical Expenses     :  " + txtmedical.Text + System.Environment.NewLine + System.Environment.NewLine +
                                 "House Expenses       :  " + txthouse.Text + System.Environment.NewLine + System.Environment.NewLine +
                                 "Others Expenses      :  " + txtothers.Text;

                String path = Path.Combine("A:\\File1", txtDate.Text + ".txt");
                File.WriteAllText(path, Expense);
                MessageBoxResult result = MessageBox.Show("Succesfully Saved", "", MessageBoxButton.OK);
                if (result == MessageBoxResult.OK)
                {
                    txtDate.Text = "";
                    txtelec.Text = "";
                    txtmedical.Text = "";
                    txthouse.Text = "";
                    txtothers.Text = "";
                

                }
            }

        }
        }
    }

