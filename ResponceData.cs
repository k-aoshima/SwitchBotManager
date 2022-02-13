using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SwiitchBotTestConsole
{
    public class ResponceData
    {
        public ResponceData()
        {
            this.StausCode = 0;
            this.BodyObj = new List<Body>();
            this.Message = Message;
        }

        /// <summary>
        /// ステータスコード
        /// </summary>
        [JsonPropertyName("statusCode")]
        public int StausCode { get; set; }

        /// <summary>
        /// ボディ
        /// </summary>
        [JsonPropertyName("body")]
        public List<Body> BodyObj { get; set; }

        /// <summary>
        /// メッセージ
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        public class Body
        {
            public Body()
            {
                this.SceneId = string.Empty;
                this.SceneName = string.Empty;
            }

            /// <summary>
            /// シーンID
            /// </summary>
            [JsonPropertyName("sceneId")]
            public string SceneId { get; set; }

            /// <summary>
            /// シーン名
            /// </summary>
            [JsonPropertyName("sceneName")]
            public string SceneName { get; set; }
        }

    }
}
