﻿using System.Windows;

namespace HackerearthDesktop.Infrastructure.Commands
{
    internal class MinimizeWindowCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;            
        }
    }
}
