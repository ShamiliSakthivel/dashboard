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

namespace dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         
        public MainWindow()
        {
            InitializeComponent();
            Settings settings = new Settings();
            if (settings.Username != null && Txtpassword != null)
            {
                Txtusername.Text = settings.Username;
                Txtpassword.Text = settings.password;
            }
            Settings.Default.Username = Txtusername.Text;
            Settings.Default.password = Txtpassword.Text;
           
            Settings.Default.Save();

                  }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Win win = new Win();
                win.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           

            Win win = new Win();
            win.Show();
                 
            
        }

      

        private void Rememberme_Click(object sender, RoutedEventArgs e)
        {
          
           

        }
    }
}
