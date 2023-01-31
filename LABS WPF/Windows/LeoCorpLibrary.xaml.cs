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
using PeyrSharp.Core;
using PeyrSharp.Core.Maths;
using PeyrSharp.Enums;
using PeyrSharp.UiHelpers;
using System.Windows;

namespace LABS_WPF.Windows
{
	/// <summary>
	/// Logique d'interaction pour LeoCorpLibrary.xaml
	/// </summary>
	public partial class LeoCorpLibrary : Window
	{
		public LeoCorpLibrary()
		{
			InitializeComponent();
		}

		private void TestButton_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(Algebra.Sum(10, -1, 10.3).ToString());
		}

		private void ScaleBtn_Click(object sender, RoutedEventArgs e)
		{
			double dpi = ScreenHelpers.GetDpi(this);
			double scale = ScreenHelpers.GetScreenScaling(this);
			MessageBox.Show($"DPI: {dpi}\nScale: {scale}");
		}

		private async void PwrBtn_Click(object sender, RoutedEventArgs e)
		{
			System.Collections.Generic.List<string> pwrs = await Password.GenerateAsync(10, 15, PasswordPresets.Complex);
			string msg = "";
			for (int i = 0; i < pwrs.Count; i++)
			{
				msg += $"{pwrs[i]}\n";
			}
			MessageBox.Show(msg);
		}
	}
}
