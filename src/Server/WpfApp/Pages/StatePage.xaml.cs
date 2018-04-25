﻿using Common.Logging;
using LazyWelfare.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp.Pages
{
    /// <summary>
    /// StatePage.xaml 的交互逻辑
    /// </summary>
    public partial class StatePage : UserControl
    {
        private static readonly ILog logger = LogManager.GetLogger<StatePage>();

        public StatePage()
        {
            InitializeComponent();
        }

        private void Button_ServiceStart_Click(object sender, RoutedEventArgs e)
        {
            ServiceProcess.Instance.Start();
        }
      
        private void Button_ServiceStop_Click(object sender, RoutedEventArgs e)
        {
            ServiceProcess.Instance.Stop();
        }
    }
}
