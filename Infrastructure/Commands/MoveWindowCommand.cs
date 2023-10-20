using System.Windows;

namespace HackerearthDesktop.Infrastructure.Commands
{
    internal class MoveWindowCommand : Command
    {
        public override bool CanExecute(object parameter)
         => true;

        public override void Execute(object parameter)
        {
            Application.Current.MainWindow.DragMove();
        }
    }
}
