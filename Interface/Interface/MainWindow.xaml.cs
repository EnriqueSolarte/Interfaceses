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

namespace Interface
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Pages.Main());
        }

        #region Switcher Tools
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
        public void Navigate(UserControl nextPage, Operation operation)
        {
            this.Content = nextPage;
            if (nextPage.Name == "pageMain")
            {
                MessageBox.Show(operation.typeOperation);
            }
        }

        #endregion

    }
}
