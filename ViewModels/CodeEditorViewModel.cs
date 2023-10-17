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

        private Languages _language;

        public Languages Language
        {
            get { return _language; }
            set {Set (ref _language,value); }
        }


        
        public CodeEditorViewModel()
        {
            
        }
    }
}
