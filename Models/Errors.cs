using Newtonsoft.Json;

namespace HackerearthDesktop.Models
{
    internal class Errors
    {
        [JsonProperty("quota")]
        public int Quota { get; set; }
        [JsonProperty("current_count")]
        public int CurrentCount { get; set; }
    }

}
