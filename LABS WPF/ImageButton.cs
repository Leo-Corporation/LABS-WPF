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
	/// Suivez les étapes 1a ou 1b puis 2 pour utiliser ce contrôle personnalisé dans un fichier XAML.
	///
	/// Étape 1a) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans le projet actif.
	/// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
	/// être utilisé :
	///
	///     xmlns:MyNamespace="clr-namespace:LABS_WPF"
	///
	///
	/// Étape 1b) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans un autre projet.
	/// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
	/// être utilisé :
	///
	///     xmlns:MyNamespace="clr-namespace:LABS_WPF;assembly=LABS_WPF"
	///
	/// Vous devrez également ajouter une référence du projet contenant le fichier XAML
	/// à ce projet et regénérer pour éviter des erreurs de compilation :
	///
	///     Cliquez avec le bouton droit sur le projet cible dans l'Explorateur de solutions, puis sur
	///     "Ajouter une référence"->"Projets"->[Recherchez et sélectionnez ce projet]
	///
	///
	/// Étape 2)
	/// Utilisez à présent votre contrôle dans le fichier XAML.
	///
	///     <MyNamespace:ImageButton/>
	///
	/// </summary>
	public class ImageButton : Button
	{
		static ImageButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
		}
	}
}
