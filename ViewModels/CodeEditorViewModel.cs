using HackerearthDesktop.Models;
using HackerearthDesktop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerearthDesktop.ViewModels
{
    internal class CodeEditorViewModel : Base.BaseViewModel
    {
        
        #region  Status
        private RequestStatus _requestStatus;

        public RequestStatus RequestStatus
        {
            get { return _requestStatus; }
            set { Set(ref _requestStatus, value); }
        }

        #endregion

        #region  Code
        private string _code;
        public string Code
        {
            get { return _code; }
            set { Set(ref _code, value); }
        }
        #endregion

        #region input
        private string input;
        public string Input
        {
            get { return input; }
            set { Set(ref input, value); }
        }
        #endregion

        #region Languages
        private IEnumerable<Language> _languages;

        public IEnumerable<Language> Languages
        {
            get { return Language.GetValues(typeof(Language)).Cast<Language>(); }
            set {Set (ref _languages,value); }
        }
        #endregion

        #region SelectedLanguage
        private Language _selectedLanguage;

        public Language SelectedLanguage
        {
            get { return _selectedLanguage; }
            set { Set(ref _selectedLanguage, value); }
        }

        #endregion

        #region MemoryLimit
        private int _memoryLimit;

        public int MemoryLimit
        {
            get { return _memoryLimit; }
            set { Set(ref _memoryLimit, value); }
        }

        #endregion

        #region TimeLimit
        private byte _timeLimit;

        public byte TimeLimit
        {
            get { return _timeLimit; }
            set { Set(ref _timeLimit, value); }
        }

        #endregion
        public CodeEditorViewModel()
        {
            
        }
    }
}
