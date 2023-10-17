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
        private string _status;
        public string Status
        {
            get { return _status; }
            set {Set(ref _status,value); }
        }
        #endregion

        #region  Status
        private string _code;
        public string Code
        {
            get { return _code; }
            set { Set(ref _code, value); }
        }
        #endregion
        public CodeEditorViewModel()
        {

        }
    }
}
