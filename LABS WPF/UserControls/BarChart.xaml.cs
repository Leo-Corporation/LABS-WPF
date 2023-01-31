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
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LABS_WPF.UserControls
{
	/// <summary>
	/// Logique d'interaction pour BarChart.xaml
	/// </summary>
	public partial class BarChart : UserControl
	{
		public BarChart(params double[] values)
		{
			InitializeComponent();
			InitUI(values);
		}

		void InitUI(params double[] val)
		{
			double max = val.Max();
			double coef = ChartPresenter.Width / max;
			List<double> widths = new List<double>();

			foreach (double value in val)
			{
				double j = value * coef;
				widths.Add(j);
			}

			foreach (double d in widths)
			{
				ChartPresenter.Children.Add(CreateRectangle(d));
			}
		}

		Rectangle CreateRectangle(double width)
		{
			return new Rectangle
			{
				Height = 40,
				Width = width,
				Fill = new SolidColorBrush { Color = Colors.Blue },
				Margin = new Thickness { Bottom = 15, Left = 0, Right = 0, Top = 30 },
				RadiusX = 5,
				RadiusY = 5,
				HorizontalAlignment = HorizontalAlignment.Left
			};
		}
	}
}
