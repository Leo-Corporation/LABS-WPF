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
using System.IO;
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
using System.Windows.Threading;

namespace LABS_WPF.Windows;
/// <summary>
/// Interaction logic for ZoomWindow.xaml
/// </summary>
public partial class ZoomWindow : Window
{
	readonly DispatcherTimer dispatcherTimer = new();
	public ZoomWindow()
	{
		InitializeComponent();
		dispatcherTimer.Interval = new(0, 0, 0, 0, 60);
		dispatcherTimer.Tick += (o, e) =>
		{
			StartScreenCapture();
		};
		dispatcherTimer.Start();
	}

	private void StartScreenCapture()
	{
		Task.Factory.StartNew(() =>
		{
			while (true)
			{
				System.Drawing.Point p = System.Windows.Forms.Cursor.Position;
				System.Drawing.Bitmap screenBitmap = new System.Drawing.Bitmap(25,
					25, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
				using (System.Drawing.Graphics screenGraphics = System.Drawing.Graphics.FromImage(screenBitmap))
				{
					screenGraphics.CopyFromScreen(p.X+12, p.Y+12, 0, 0, screenBitmap.Size);
				}
				Dispatcher.BeginInvoke(new Action(() =>
				{
					ZoomImg.Source = ConvertBitmapToImageSource(screenBitmap);
					// Perform any additional UI updates here
				}));
				System.Threading.Thread.Sleep(100);
				GC.Collect();
			}
		});
	}

	private ImageSource ConvertBitmapToImageSource(System.Drawing.Bitmap bitmap)
	{
		using (MemoryStream memory = new MemoryStream())
		{
			bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
			memory.Position = 0;
			BitmapImage bitmapImage = new BitmapImage();
			bitmapImage.BeginInit();
			bitmapImage.StreamSource = memory;
			bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
			bitmapImage.EndInit();
			return bitmapImage;
		}
	}
}
