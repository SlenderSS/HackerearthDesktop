using Newtonsoft.Json;

namespace HackerearthDesktop.Models
{
    internal class SubmitResponse
    {
        [JsonProperty("he_id")]
        public string HeID { get; set; }
        [JsonProperty("request_status")]
        public RequestStatus RequestStatus { get; set; }
        [JsonProperty("status_update_url")]
        public string StatusUpdateUrl { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }
    }

}
