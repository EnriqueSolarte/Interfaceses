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

namespace Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        #region Behaibor apperance
        private void sizeChanged(object sender, SizeChangedEventArgs e)
        {
            double remainingSpace = listViewOperations.ActualWidth;

            if (remainingSpace > 0)
            {
                (listViewOperations.View as GridView).Columns[0].Width = 50;
                (listViewOperations.View as GridView).Columns[1].Width = 200;
                (listViewOperations.View as GridView).Columns[2].Width = Math.Ceiling(remainingSpace-50-200);
                
            }
        }

        #endregion
    }
}