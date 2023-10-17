using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerearthDesktop.Models.Enums
{
    internal enum RequestStatus
    {
        [Description("The request has been recorded and processing has been initiated.")]
        REQUEST_INITIATED,

        [Description("The request has been queued in the evaluation pipeline.")]
        REQUEST_QUEUED,

        [Description("Compilation is complete.")]
        CODE_COMPILED,

        [Description("Execution is complete.")]
        REQUEST_COMPLETED,

        [Description("The request processing failed due to an internal issue.")]
        REQUEST_FAILED
    }
}
