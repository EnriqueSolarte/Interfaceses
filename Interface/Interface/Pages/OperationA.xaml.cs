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
    /// <summary>
    /// Interaction logic for OperationA.xaml
    /// </summary>
    public partial class  OperationA : UserControl
    {
        UserControl Main;
        Main MainPage;
        Operation operationA;

        public OperationA(Main main, int index)
        {
            Main = main;
            MainPage = main;
            InitializeComponent();
            operationA = new Operation();
           

        }
    }
}