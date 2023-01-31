/*
MIT License

Copyright (c) Léo Corporation

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. 
*/
using LABS_WPF.Classes;
using LABS_WPF.Windows;
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

namespace LABS_WPF
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			//Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
			InitializeComponent();
			LeoCorpLibrary.Update.GetLastVersion("https://bing.com");

		}

		/// <summary>
		/// Lorsque la souris se déplace.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void StackPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
				DragMove(); // Déplacer
		}

		/// <summary>
		/// Lors du clic.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LABSButton2_Click(object sender, RoutedEventArgs e)
		{
			Process.Start(Definitions.GitHubRepoUrl); // Démarrer dans un navigateur
		}

		/// <summary>
		/// Lors du clic.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LABSButton1_Click(object sender, RoutedEventArgs e)
		{
			About about = new About();
			about.Show(); // Ouvrir la fenêtre "A propos"
		}

		private void TestButton_Click(object sender, RoutedEventArgs e)
		{
			new Windows.LeoCorpLibrary().Show();
		}

		private void TestButton_Click_1(object sender, RoutedEventArgs e)
		{
			new Windows.UserControlAdd().Show();
		}

		private void TestButton_Click_2(object sender, RoutedEventArgs e)
		{
			new NoBorderWindow().Show();
		}

		private void TestButton_Click_3(object sender, RoutedEventArgs e)
		{
			new ScrollWindow().Show();
		}

		private void TestButton_Click_4(object sender, RoutedEventArgs e)
		{
			new BluredWindow().Show();
		}

		private void TestButton_Click_5(object sender, RoutedEventArgs e)
		{
			new MaximizeWindow().Show();
		}

		private void TestButton_Click_6(object sender, RoutedEventArgs e)
		{
			new DownloadFileWPF().Show();
		}

		private void TestButton_Click_7(object sender, RoutedEventArgs e)
		{
			//LeoCorpLibrary.Update.Check(Definitions.Version, Definitions.Version + "-test", new About(), new UserControlAdd());
		}

		private void TestButton_Click_8(object sender, RoutedEventArgs e)
		{
			new BarChartWindow().Show();
		}

		private void TestButton_Click_9(object sender, RoutedEventArgs e)
		{
			new ListViewWindow().Show();
		}

		private void TestButton_Click_10(object sender, RoutedEventArgs e)
		{
			new AnimatedWindow().Show(); // Show
		}

		private void TestButton_Click_11(object sender, RoutedEventArgs e)
		{
			new MousePixelsWindow().Show();
        }
    }
}
