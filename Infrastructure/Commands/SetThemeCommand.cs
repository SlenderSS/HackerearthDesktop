using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HackerearthDesktop.Infrastructure.Commands
{
    internal class SetThemeCommand: Command
    {
        private static string CurrentTheme = "dark";
        public override bool CanExecute(object parameter)
        {
            if (!(parameter is ComboBoxItem comboBoxItem)) return false;
            if (comboBoxItem.Name.ToString() != CurrentTheme)
            {
                CurrentTheme = comboBoxItem.Name.ToString();
                return true;
            }
            return false;
        }

        public override void Execute(object parameter)
        {
            if (!(parameter is ComboBoxItem comboBoxItem)) return;
            ResourceDictionary dictionary = new ResourceDictionary();
            switch (comboBoxItem.Name.ToString())
            {
                case "dark":
                    dictionary.Source = new Uri(@"pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Dark.xaml");
                    break;
                case "light":
                    dictionary.Source = new Uri(@"pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml");
                    break;
                default:
                    dictionary.Source = new Uri(@"pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Dark.xaml");
                    break;
            }
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}

