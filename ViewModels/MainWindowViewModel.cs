using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerearthDesktop.ViewModels
{
    class MainWindowViewModel : Base.BaseViewModel
    {

        private string _title;
        public string Title
        {
            get { return _title; }
            set { Set( ref _title, value); }
        }

        #region CurrentView
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { Set(ref _currentView, value); }
        }

        #endregion


        public MainWindowViewModel(CodeEditorViewModel codeEditorViewModel)
        {
            CurrentView = codeEditorViewModel;
        }
    }
}
