using LABS_WPF.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LABS_WPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lors du clic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkTextBlock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start(Definitions.GitHubRepoUrl); // Démarrer dans un navigateur
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textblock1.Text = $"Version {Definitions.Version}";
        }
    }
}
