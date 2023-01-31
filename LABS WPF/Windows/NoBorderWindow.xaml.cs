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
using LABS_WPF.UserControls;
using PeyrSharp.Core;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace LABS_WPF.Windows
{
	/// <summary>
	/// Logique d'interaction pour NoBorderWindow.xaml
	/// </summary>
	public partial class NoBorderWindow : Window
	{
		public NoBorderWindow()
		{
			InitializeComponent();
			var image = new BitmapImage();
			image.BeginInit();
			image.UriSource = new Uri("https://media.rawg.io/media/achievements/189/189299bbae4d128e4c85b5e9c671f727.jpg");
			image.DecodePixelWidth = 50;
			image.EndInit();

			img1.Source = image; // Set the image

			for (int i = 0; i < 10; i++)
			{
				Combobox.Items.Add(new CustomItem(Password.GenerateAsync(10, "A.B.C.D.E.F.G", ".").GetAwaiter().GetResult()));
			}

			EmojiTxt.Text = "🇫🇷";
		}

		private void minimize_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void maximize_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Maximized;
		}

		private void close_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void maximizeButton_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Maximized;
			RefreshMaximizeRestoreButton();
		}

		private void restoreButton_Click(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Normal;
			RefreshMaximizeRestoreButton();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void RefreshMaximizeRestoreButton()
		{
			if (this.WindowState == WindowState.Maximized)
			{
				this.maximizeButton.Visibility = Visibility.Collapsed;
				this.restoreButton.Visibility = Visibility.Visible;
			}
			else
			{
				this.maximizeButton.Visibility = Visibility.Visible;
				this.restoreButton.Visibility = Visibility.Collapsed;
			}
		}

		private void window_StateChanged(object sender, EventArgs e)
		{
			RefreshMaximizeRestoreButton();
		}

		private void window_Loaded(object sender, RoutedEventArgs e)
		{
			RefreshMaximizeRestoreButton();
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"Password: {PasswordTxt.Password}");
		}

		private void Combobox_GotFocus(object sender, RoutedEventArgs e)
		{
			Combobox.IsDropDownOpen = true;
		}
	}
}
