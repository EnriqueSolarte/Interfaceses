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

        public List<Operation> currentList;


        public Main()
        {
            InitializeComponent();
            this.labelTime.Content = DateTime.Now.ToString();
            this.currentList = new List<Operation>();
        }

        public Main(Operation newOperation, List<Operation> savedList)
        {
            InitializeComponent();
            this.labelTime.Content = DateTime.Now.ToString();
            this.currentList = new List<Operation>();
            currentList = savedList;
            loadOperation(newOperation);
        }

        

        private void loadOperation(Operation newOperation)
        {
            this.currentList.Add(newOperation);
            this.listViewOperations.ItemsSource = null;
            this.listViewOperations.ItemsSource = currentList;
        }

        private void buttonProfile_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Pages.Profile(this));
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

        private void doubleCLlick(object sender, MouseButtonEventArgs e)
        {
            var selectedStockObject = listViewOperations.SelectedItems[0] as Operation;
            if (selectedStockObject == null)
            {
                return;
            }
            
        }
    }
}

