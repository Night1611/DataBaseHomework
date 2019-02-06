﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace Listener
{
	/// <summary>
	/// ServerWindow.xaml 的交互逻辑
	/// </summary>
	public partial class ServerWindow : Window
    {
        public ServerWindow()
        {
            InitializeComponent();
            var threadAccept = new Thread(AcceptClientConnect);
            threadAccept.Start();
        }

        private void AcceptClientConnect()
        {
            while (true)
            {
                try
                {
                }
            }
        }
    }
}