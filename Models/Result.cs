using Newtonsoft.Json;

namespace HackerearthDesktop.Models
{
    internal class Result
    {
        [JsonProperty("compile_status")]
        public string CompileStatus { get; set; }

        [JsonProperty("run_status")]
        public RunStatus RunStatus { get; set; }
    }

}
