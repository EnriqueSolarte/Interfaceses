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

namespace Interface.Pages
{
   
    public partial class Profile : UserControl
    {
        UserControl Main;
        Operation profileOperation;
        public Profile(UserControl main)
        {
            Main = main;
            InitializeComponent();
            profileOperation = new Operation();
        }

        public Profile(UserControl main, Operation operation)
        {
            Main = main;
            profileOperation = operation;
            InitializeComponent();
            MessageBox.Show(profileOperation.typeOperation);
        }

        private void buttonAccept_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Main, profileOperation);
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Main);
        }
    }
}
