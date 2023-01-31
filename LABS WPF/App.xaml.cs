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
using System.Windows;
using System.Windows.Shell;

namespace LABS_WPF
{
	/// <summary>
	/// Logique d'interaction pour App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			//base.OnStartup(e);

			if (e.Args.Length > 0)
			{
				MessageBox.Show("Test");
				Shutdown();
			}

			JumpTask jumpTask = new JumpTask
			{
				Title = "This is a test",
				Description = "A test jump list.",
				IconResourcePath = System.Reflection.Assembly.GetEntryAssembly().CodeBase,
				ApplicationPath = System.Reflection.Assembly.GetEntryAssembly().CodeBase,
				Arguments = "/test"
			};

			JumpList jumpList = new JumpList();
			jumpList.JumpItems.Add(jumpTask);
			jumpList.ShowFrequentCategory = false;
			jumpList.ShowRecentCategory = false;

			JumpList.SetJumpList(Current, jumpList);

			// Open another window: new Windows.About().Show();
		}
	}
}
