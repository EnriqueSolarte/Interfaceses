﻿using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Switcher
    {
        public static MainWindow window;

        public static void Switch(UserControl newPage)
        {
            window.Navigate(newPage);
        }

        public static void Switch(UserControl newPage, Operation newOperation)
        {
            window.Navigate(newPage, newOperation);

        }
    }

    
}
