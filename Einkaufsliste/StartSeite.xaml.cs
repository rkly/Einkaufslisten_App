using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Vorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 dokumentiert.

namespace Einkaufslisten_App
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class StartSeite : Page
    {
        public StartSeite(/*Frame frame*/)
        {
            this.InitializeComponent();
            //this.Menu.Content = frame;
            //ContentFrame.Navigate(typeof(Einkaufslisten));
        }
        #region Menu-Tasten
        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
            Menu.IsPaneOpen = !Menu.IsPaneOpen;
        }

        private void Erstellen_Click(object sender, RoutedEventArgs e)
        {
            Menu.IsPaneOpen = false;
            //if(Menu.Content != null)
            //((Frame)Menu.Content).Navigate(typeof(Erstellen));
            ContentFrame.Navigate(typeof(Erstellen));
        }

        private void Einkaufslisten_Click(object sender, RoutedEventArgs e)
        {
            Menu.IsPaneOpen = false;
            ContentFrame.Navigate(typeof(Einkaufslisten));
        }

        private void Einstellungen_Click(object sender, RoutedEventArgs e)
        {
            Menu.IsPaneOpen = false;
            ContentFrame.Navigate(typeof(Einstellungen));
        }
        #endregion

        private void About_Click(object sender, RoutedEventArgs e)
        {
            Menu.IsPaneOpen = false;
            ContentFrame.Navigate(typeof(Info));
        }
    }
}
