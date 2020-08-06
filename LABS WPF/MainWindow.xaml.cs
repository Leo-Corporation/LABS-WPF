using LABS_WPF.Classes;
using LABS_WPF.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LABS_WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lorsque la souris se déplace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StackPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove(); // Déplacer
        }

        /// <summary>
        /// Lors du clic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LABSButton2_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Definitions.GitHubRepoUrl); // Démarrer dans un navigateur
        }

        /// <summary>
        /// Lors du clic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LABSButton1_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show(); // Ouvrir la fenêtre "A propos"
        }
    }
}
