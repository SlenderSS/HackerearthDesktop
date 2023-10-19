﻿using HackerearthDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerearthDesktop.Services.Interfaces
{
    interface ILeetcodeProblemsService
    {
        ICollection<Problem> GetProblems();
        Problem GetProblemDescription(Problem problem);
    }
}
