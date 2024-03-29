﻿using MvvmCross.ViewModels;
using ProxySuper.Core.Models;
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

namespace ProxySuper.WPF.Controls
{
    /// <summary>
    /// ProgressControl.xaml 的交互逻辑
    /// </summary>
    public partial class ProgressControl : UserControl
    {
        public ProgressControl()
        {
            InitializeComponent();

            LogsTextBox.TextChanged += LogsTextBox_TextChanged;
        }

        private void LogsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            LogsTextBox.ScrollToEnd();
        }
    }
}
