﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HackerearthDesktop.Infrastructure.Commands
{
    internal class SetLanguageCommand : Command
    {
        private static string CurrentLanguage = "en";
        public override bool CanExecute(object parameter)
        {
            if (!(parameter is ComboBoxItem comboBoxItem)) return false;
            if (comboBoxItem.Name.ToString() != CurrentLanguage)
            {
                CurrentLanguage = comboBoxItem.Name.ToString();
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
                case "ua":
                    dictionary.Source = new Uri(@"..\Resources\Languages\Ua_lang.xaml", UriKind.Relative);
                    break;
                case "en":
                    dictionary.Source = new Uri(@"..\Resources\Languages\En_lang.xaml", UriKind.Relative);
                    break;
                default:
                    dictionary.Source = new Uri(@"..\Resources\Languages\En_lang.xaml", UriKind.Relative);
                    break;
            }
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
