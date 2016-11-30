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
        Main mainPage;
        Operation profileOperation;

        public Profile(Main main)
        { 
            Main = main;
            mainPage = main;
            InitializeComponent();
            profileOperation = new Operation();
        }


        private void buttonAccept_Click(object sender, RoutedEventArgs e)
        {   
            profileDefinition();
            
            Switcher.Switch(new Main(profileOperation,mainPage.currentList));
        }

        private void profileDefinition()
        {
            
            profileOperation.TypeImagineOperation ="/Images/Profile.png";
            profileOperation.TypeOperation = "Profile";
            profileOperation.Parameters = "Z=150 XF=25.25 F125.25 Z2.5 S=12.5 Mx=12.45 TF=125.8";
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Main);
        }
    }
}
