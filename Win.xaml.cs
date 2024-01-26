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

namespace dashboard
{
    /// <summary>
    /// Interaction logic for Win.xaml
    /// </summary>
    public partial class Win : Window
    {
        Register register;
        Storagepage storagepage;
        Cloudpage cloudpage;
        Files files;
        Manager manager;
        public Win()
        {
            InitializeComponent();
            register = new Register();
            storagepage = new Storagepage();
            cloudpage = new Cloudpage();
            files = new Files();
            manager = new Manager();
            framemain.Content = register;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            framemain.Content = register;  
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            framemain.Content = storagepage;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            framemain.Content = cloudpage;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            framemain.Content = files;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            framemain.Content = manager;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.Close();
           
        }
    }
}
