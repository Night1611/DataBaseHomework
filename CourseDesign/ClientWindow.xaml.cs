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
using System.Windows.Shapes;

namespace CourseDesign {
	/// <summary>
	/// ClientWindow.xaml 的交互逻辑
	/// </summary>
	public partial class ClientWindow : Window {
		public ClientWindow() {
			InitializeComponent();
		}
		public ClientWindow(string UserID) {
			InitializeComponent();
			this.UserID = UserID;
			this.Title = "当前登陆用户名："+ UserID;
		}
		private string UserID;

		//退出
		private void MenuItem_Exit_Click(object sender, RoutedEventArgs e) {
			Close(); //关闭ClientWindow窗口
		}

		//登出
		private void MenuItem_Logout_Click(object sender, RoutedEventArgs e) {
			Login login = new Login(UserID);
			login.Show();
			Close(); //关闭ClientWindow窗口
		}

		private void MenuItem_Settings_Click(object sender, RoutedEventArgs e) {

		}

		private void MenuItem_About_Click(object sender, RoutedEventArgs e) {
			About about = new About();
			about.ShowDialog();
		}

		private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			string ChatUserName = listBox.SelectedItem.ToString();
		}
	}
}