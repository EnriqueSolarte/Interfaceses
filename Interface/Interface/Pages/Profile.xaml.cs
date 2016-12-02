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
        Main MainPage;
        Operation profileOperation;

        public Profile(Main main, int index)
        { 
            Main = main;
            MainPage = main;
            InitializeComponent();
            profileOperation = new Operation();
            if (index <= MainPage.listViewOperations.Items.Count)
            {
                var listProfileOperation = MainPage.listViewOperations.SelectedValue as List<Operation>;
                profileOperation = listProfileOperation.Last();
                
            }
            else
            {
                profileOperation.index = MainPage.listViewOperations.Items.Count;
            }
            fillingProfileParameters();

        }

       

        private void buttonAccept_Click(object sender, RoutedEventArgs e)
        {
            profileDefinition();
            Switcher.Switch(Main);
        }

        private void profileDefinition()
        {
            profileOperation.TypeImagineOperation ="/Images/Profile.png";
            profileOperation.TypeOperation = "Profile";
            profileOperation.Parameters = DateTime.Now.ToString("[DD=hh][MM=mm][YY=-hh][MM=mmss]");
            profileOperation.update = DateTime.Now.ToString();


            List<Operation> listOperation = new List<Operation>();
            listOperation.Add(profileOperation);
            if (profileOperation.index != MainPage.listViewOperations.Items.Count)
            {
                MainPage.listViewOperations.Items.RemoveAt(profileOperation.index);
            }
            MainPage.listViewOperations.Items.Insert(profileOperation.index, listOperation);
            
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Main);
        }

        private void fillingProfileParameters()
        {
            this.textBoxParameters.Text = profileOperation.index + profileOperation.Parameters;

        }
    }
}
