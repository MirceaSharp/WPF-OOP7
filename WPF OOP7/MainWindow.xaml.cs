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

namespace WPF_OOP7
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(rdMonarchy.IsChecked ==true)
            {
                Monarchy monarchyCountry = new Monarchy(txtCountry.Text, txtCapital.Text, txtHeadofState.Text);
                lbShow.Items.Add(monarchyCountry).ToString();

            }
            else if(rdRepublic.IsChecked ==true)
            {
                Republic myRepublic= new Republic(txtCountry.Text, txtCapital.Text, txtHeadofState.Text);
                lbShow.Items.Add(myRepublic).ToString();


            }
            else if(rdOther.IsChecked == true)
            {

                Country myCountry = new Country(txtCountry.Text, txtCapital.Text);
                lbShow.Items.Add(myCountry).ToString();
            }
        }
    }
}
