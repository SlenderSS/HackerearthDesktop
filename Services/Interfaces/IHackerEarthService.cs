using HackerearthDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerearthDesktop.Services.Interfaces
{
    interface IHackerEarthService
    {
        string GetOutput(string outputUrl);
        Task<SubmitResponse> GetStatus(string statusUpdateUrl);
        Task<object> SubmitCode(string lang, string source, string input = "", int memoryLimit = 256, byte timeLimit = 1);
    }
}
