using HackerearthDesktop.Infrastructure.Commands;
using HackerearthDesktop.Models;
using HackerearthDesktop.Models.Enums;
using HackerearthDesktop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HackerearthDesktop.ViewModels
{
    internal class CodeEditorViewModel : Base.BaseViewModel
    {


        private readonly IHackerEarthService hackerEarth;

        #region  Status
        private RequestStatus _requestStatus = new RequestStatus();

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

        #region Output
        private string _output;

        public string Output
        {
            get { return _output; }
            set { Set(ref _output, value); }
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

        #region SubmitResponse
        private SubmitResponse _submitResponse;

        public SubmitResponse SubmitResponse
        {
            get { return _submitResponse; }
            set { Set(ref _submitResponse, value); }
        }

        #endregion

        #region Error
        private ErrorResponse _error;

        public ErrorResponse Error
        {
            get { return _error; }
            set { Set(ref _error, value); }
        }

        #endregion


        #region SubmitCode
        private ICommand _submitCommand;
        public ICommand SubmitCommand 
            => _submitCommand = _submitCommand 
            ?? new LambdaCommand(OnSubmitCommandExecution, CanSubmitCommandExecute);

        private bool CanSubmitCommandExecute(object o) => !string.IsNullOrWhiteSpace(Code);

        private void OnSubmitCommandExecution(object o)
        {
            var result = Task.Run(async () =>
                {
                  return await hackerEarth.SubmitCode(SelectedLanguage.ToString(), Code, Input, MemoryLimit, TimeLimit);
                }).Result;

            if (result is SubmitResponse response) SubmitResponse = response;
            else if (result is ErrorResponse error) RequestStatus.Message = error.Message;

            Task.Run(async() =>
            {
                while (SubmitResponse.Result.RunStatus.Output is null)
                {
                    SubmitResponse = await hackerEarth.GetStatus(SubmitResponse.StatusUpdateUrl);
                    RequestStatus.Message = SubmitResponse.RequestStatus.Message;
                    if (SubmitResponse.Result.CompileStatus != "OK" && SubmitResponse.Result.CompileStatus != null) 
                    {
                        Output = SubmitResponse.Result.CompileStatus;
                        goto _out;
                    }
                }

                Output = hackerEarth.GetOutput(SubmitResponse.Result.RunStatus.Output);
                _out:;
            });
        }

        #endregion

        public CodeEditorViewModel(IHackerEarthService hackerEarth)
        {
            this.hackerEarth = hackerEarth;
        }
    }
}
