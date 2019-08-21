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

namespace TipCalculator
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

        private void SubmitButton(object sender, RoutedEventArgs e)
        {
            decimal cost = decimal.Parse(CostBox.Text);
            int tip = int.Parse(Tip.Text);
            Total.Text = (Math.Ceiling((cost * (decimal) (tip * .01)) * 100) /100).ToString("C");
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
