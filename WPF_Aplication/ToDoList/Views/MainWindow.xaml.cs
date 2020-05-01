using System;
using System.IO;
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
using ToDoList.ViewModels;

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new RecordViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sri = Application.GetResourceStream(new Uri(@"Resources\Cursor\pointer.cur", UriKind.Relative));
            var cur = new Cursor(sri.Stream);
            this.Cursor = cur;

            var cultureName = "English";
            var newCultureName = "Russian";
            var requestedCulture = string.Format(@"Resources\DinamicLanguage\{0}.xaml", cultureName);
            var resourceDictionary = Application.Current.Resources.MergedDictionaries
                .FirstOrDefault(i => i.Source.OriginalString.Equals(requestedCulture));
            if (resourceDictionary != null)
            {
                requestedCulture = string.Format(@"Resources\DinamicLanguage\{0}.xaml", newCultureName);
                var dictionary = new ResourceDictionary();
                dictionary.Source = new Uri(requestedCulture, UriKind.Relative);
                Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
                Application.Current.Resources.MergedDictionaries.Add(dictionary);
            }
        }
    }
}
