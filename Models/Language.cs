using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerearthDesktop.Models
{
    internal enum Language
    {
        [Description("C#")]
        CSHARP,
        [Description("C++14")]
        CPP14,
        [Description("C++17")]
        CPP17,
        [Description("Python")]
        PYTHON

    }

    public class Root
    {
        public string he_id { get; set; }
        public RequestStatus_ request_status { get; set; }
        public string status_update_url { get; set; }
        public Result result { get; set; }
    }

}
