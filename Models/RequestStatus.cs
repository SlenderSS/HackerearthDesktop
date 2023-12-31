﻿using Newtonsoft.Json;

namespace HackerearthDesktop.Models
{
    internal class RequestStatus
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

}
