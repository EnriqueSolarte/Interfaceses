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
  
    public partial class Main : UserControl
    {

        Operation operation;
        public Main()
        {
            InitializeComponent();
            this.labelTime.Content = DateTime.Now.ToString();
        }     

        private void buttonProfile_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Pages.Profile(this));
        }

        private void buttonProfileTest_click(object sender, RoutedEventArgs e)
        {
            operation = new Operation();
            operation.typeOperation = "Profile already generated";
            Switcher.Switch(new Pages.Profile(this, operation));
        }

        #region Rezing ListView
        private void ChangeSize(object sender, SizeChangedEventArgs e)
        {
            double remainingSpace = this.listViewOperations.ActualWidth;

            if (remainingSpace > 0)
            {
                (this.listViewOperations.View as GridView).Columns[0].Width = 50;
                (this.listViewOperations.View as GridView).Columns[1].Width = 200;
                (this.listViewOperations.View as GridView).Columns[2].Width = Math.Ceiling(remainingSpace - 50 - 200);

            }
        }
        #endregion

       
    }
}

