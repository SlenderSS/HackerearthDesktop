using Newtonsoft.Json;

namespace HackerearthDesktop.Models
{
    internal class ErrorResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("errors")]
        public Errors Errors { get; set; }
    }

}
