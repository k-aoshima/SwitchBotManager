using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SwiitchBotTestConsole
{
    public class RequestData
    {
        public RequestData()
        {
            this.Command = "press";
            this.Parameter = "default";
            this.CommandType = "command";
        }

        [JsonPropertyName("command")]
        public string Command { get; set; }

        [JsonPropertyName("parameter")]
        public string Parameter { get; set; }

        [JsonPropertyName("commandType")]
        public string CommandType { get; set; }

    }
}
