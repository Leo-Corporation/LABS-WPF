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
using LABS_WPF.UserControls;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace LABS_WPF.Windows
{
	/// <summary>
	/// Logique d'interaction pour UserControlAdd.xaml
	/// </summary>
	public partial class UserControlAdd : Window
	{
		AddUC add = new();
		public UserControlAdd()
		{
			InitializeComponent();
			WrapPanel1.Children.Add(add);
		}

		private void TestButton_Click(object sender, RoutedEventArgs e)
		{
			Definitions.UserControlAdd = this;
			AddUC();
		}

		internal void AddUC()
		{
			TestUC testUC = new();
			WrapPanel1.Children.Add(testUC);
			WrapPanel1.Children.Remove(add);
			WrapPanel1.Children.Add(add);
		}

		private void Window_GotFocus(object sender, RoutedEventArgs e)
		{
			Definitions.UserControlAdd = this;
		}

		private void Window_Activated(object sender, EventArgs e)
		{
			Definitions.UserControlAdd = this;
		}

		private void button2_Click(object sender, RoutedEventArgs e)
		{
			WrapPanel1.Children.Clear();
			WrapPanel1.Children.Add(add);
		}

		private void button3_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				for (int i = 0; i < WrapPanel1.Children.Count; i++)
				{
					if (WrapPanel1.Children[i] is TestUC)
					{
						TestUC testUC = (TestUC)WrapPanel1.Children[i];
						testUC.CheckBox1.Visibility = Visibility.Visible;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message); // Afficher une erreur
			}

		}

		private void button4_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				List<TestUC> testUCs = new();
				UIElementCollection uIElementCollection = WrapPanel1.Children;

				foreach (UIElement uIElement in uIElementCollection)
				{
					if (uIElement is TestUC)
					{
						TestUC testUC = (TestUC)uIElement;
						if ((bool)testUC.CheckBox1.IsChecked)
						{
							testUCs.Add(testUC);
						}
					}
				}

				foreach (TestUC testUC1 in testUCs)
				{
					WrapPanel1.Children.Remove(testUC1);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
