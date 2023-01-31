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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace LABS_WPF.Windows
{
	/// <summary>
	/// Interaction logic for ListViewWindow.xaml
	/// </summary>
	public partial class ListViewWindow : Window
	{
		internal List<Person> people = new()
		{
			new("Léo", "Corporation", 1),
			new("Léo", "Corporation", 2),
			new("Léo", "Corporation", 3),
			new("Léo", "Corporation", 4),
			new("Léo", "Corporation", 5),
			new("Léo", "Corporation", 4),
			new("Léo", "Corporation", 4),
			new("Léo", "Corporation", 4),
			new("Léo", "Corporation", 4),
			new("Léo", "Corporation", 4),
			new("Léo", "Corporation", 4),
			new("Léo", "Corporation", 4),
			new("Léo", "Corporation", 4)
		};

		internal List<List<string>> items = new()
		{
			new() { "Léo", "Corporation", "1" },
			new() { "Léo", "Corporation", "2" },
			new() { "Léo", "Corporation", "3" },
			new() { "Léo", "Corporation", "4" },
			new() { "Léo", "Corporation", "5" },
			new() { "Léo", "Corporation", "6" }
		};
		public ListViewWindow()
		{
			InitializeComponent();
			ListView.ItemsSource = items;

			GVC1.DisplayMemberBinding = new Binding("Item[0]");
			GVC2.DisplayMemberBinding = new Binding("Item[1]");
			GVC3.DisplayMemberBinding = new Binding("Item[2]");
		}
	}

	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public Person(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public override string ToString()
		{
			return FirstName;
		}
	}
}
