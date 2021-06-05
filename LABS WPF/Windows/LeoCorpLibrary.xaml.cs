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
using System.Windows.Shapes;
using LeoCorpLibrary;
using LeoCorpLibrary.UI;

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
            MessageBox.Show(Maths.Sum(10, -1, 10.3).ToString());
        }

		private void ScaleBtn_Click(object sender, RoutedEventArgs e)
		{
            var dpi = ScreenHelpers.GetScreenDPIFromWPFWindow(this);
            var scale = ScreenHelpers.GetScreenScalingFromWPFWindow(this);
            MessageBox.Show($"DPI: {dpi}\nScale: {scale}");
		}

		private void PwrBtn_Click(object sender, RoutedEventArgs e)
		{
            var pwrs = Password.GenerateAmount(10, 15, PasswordPresets.Complex);
            string msg = "";
            for (int i = 0; i < pwrs.Count; i++)
			{
                msg += $"{pwrs[i]}\n";
			}
            MessageBox.Show(msg);
		}
	}
}
