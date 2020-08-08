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
    }
}
