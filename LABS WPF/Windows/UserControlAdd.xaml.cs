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
using LABS_WPF.UserControls;

namespace LABS_WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour UserControlAdd.xaml
    /// </summary>
    public partial class UserControlAdd : Window
    {
        public UserControlAdd()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            TestUC testUC = new TestUC();
            StackPanel2.Children.Add(testUC);
        }
    }
}
