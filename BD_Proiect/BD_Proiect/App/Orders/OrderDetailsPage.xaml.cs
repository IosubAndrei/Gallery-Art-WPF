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

namespace BD_Proiect.Orders
{
    /// <summary>
    /// Interaction logic for OrderDetailsPage.xaml
    /// </summary>
    public partial class OrderDetailsPage : UserControl
    {
        public Action acceptOrder;
        public Action<int> declineOrder;
        public OrderDetailsPage(int userID,int operaID)
        {
            InitializeComponent();
        }

        private void declineButton_Click(object sender, RoutedEventArgs e)
        {
            declineOrder(-1);
        }
    }
}
