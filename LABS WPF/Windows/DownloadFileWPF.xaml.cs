﻿/*
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
using System.Net;
using System.Threading;
using System.Windows;

namespace LABS_WPF.Windows
{
	/// <summary>
	/// Logique d'interaction pour DownloadFileWPF.xaml
	/// </summary>
	public partial class DownloadFileWPF : Window
	{
		WebClient client = new();
		string path = System.AppDomain.CurrentDomain.BaseDirectory + @"\test.txt";
		string link = "https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/G%C3%A9n%C3%A9rateur%20de%20mots%20de%20passe%203/G%C3%A9n%C3%A9rateur%20de%20mots%20de%20passe%203.exe";
		public DownloadFileWPF()
		{
			InitializeComponent();
		}

		private void StartBtn_Click(object sender, RoutedEventArgs e)
		{
			client.DownloadProgressChanged += Client_DownloadProgressChanged;
			client.DownloadFileCompleted += Client_DownloadFileCompleted;
			Thread thread = new(() =>
			{
				Uri uri = new(link);
				client.DownloadFileAsync(uri, path);
			});
			thread.Start();
		}

		private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
		{
			Dispatcher.Invoke(() =>
			{
				MessageBox.Show("Completed");
			});
		}

		private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			Dispatcher.Invoke(() =>
			{
				PgrBar.Minimum = 0;
				double receive = double.Parse(e.BytesReceived.ToString());
				double total = double.Parse(e.TotalBytesToReceive.ToString());
				double percentage = receive / total * 100;
				PgrBar.Value = int.Parse(Math.Truncate(percentage).ToString());
			});
		}
	}
}
