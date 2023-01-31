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
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace LABS_WPF.Windows
{
	/// <summary>
	/// Interaction logic for MousePixelsWindow.xaml
	/// </summary>
	public partial class MousePixelsWindow : Window
	{
		readonly DispatcherTimer dispatcherTimer = new();
		public MousePixelsWindow()
		{
			InitializeComponent();

			dispatcherTimer.Interval = new(0, 0, 0, 0, 1); // Interval
			dispatcherTimer.Tick += (o, e) =>
			{
				System.Drawing.Point p = System.Windows.Forms.Cursor.Position;

				int count = 0;
				List<Border> bs = new()
				{
					B1, B2,B3,B4,B5,B6, B7, B8, B9
				};
				List<TextBlock> ts = new()
				{
					T1, T2,T3,T4,T5,T6, T7, T8, T9
				};
				for (int x = -1; x < 2; x++)
				{
					for (int y = -1; y < 2; y++)
					{
						Bitmap bitmap = new(1, 1);
						Graphics GFX = Graphics.FromImage(bitmap);
						GFX.CopyFromScreen(new(p.X + x, p.Y + y), new System.Drawing.Point(0, 0), bitmap.Size);
						System.Drawing.Color pixel = bitmap.GetPixel(0, 0);


						bs[count].Background = new SolidColorBrush { Color = System.Windows.Media.Color.FromRgb(pixel.R, pixel.G, pixel.B) }; // Set color
						ts[count].Text = $"({p.X + x}, {p.Y + y})";
						ts[count].Foreground = new SolidColorBrush { Color = System.Windows.Media.Color.FromRgb((byte)(255 - pixel.R), (byte)(255 - pixel.B), (byte)(255 - pixel.B)) };
						count++;
					}
				}
			};
			dispatcherTimer.Start();
		}
	}
}
