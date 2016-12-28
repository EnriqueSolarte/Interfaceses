﻿using System;
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


        public Main()
        {
            InitializeComponent();
            this.labelTime.Content = DateTime.Now.ToString();
        }
    
        private void buttonProfile_Click(object sender, RoutedEventArgs e)
        {
            int index = this.listViewOperations.Items.Count+1;
            Switcher.Switch(new Pages.Profile(this,index));

        }

       

        #region Rezing ListView
        private void ChangeSize(object sender, SizeChangedEventArgs e)
        {
            double remainingSpace = this.listViewOperations.ActualWidth;

            if (remainingSpace > 0)
            {
                (this.listViewOperations.View as GridView).Columns[0].Width = 50;
                (this.listViewOperations.View as GridView).Columns[1].Width = 50;
                (this.listViewOperations.View as GridView).Columns[2].Width = 200;
                (this.listViewOperations.View as GridView).Columns[3].Width = Math.Ceiling(remainingSpace - 50 -50 - 215);

            }
        }


        #endregion

        private void doubleCLlick(object sender, MouseButtonEventArgs e)
        {
            int index = this.listViewOperations.SelectedIndex;
            Switcher.Switch(new Pages.Profile(this, index));

        }

        
    }
}

