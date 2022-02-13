using System;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace SwiitchBotTestConsole
{
    public class JsonUtility
    {
        public JsonUtility()
        {
            
        }

        /// <summary>
        /// RequestDataクラスをJson文字列に変換
        /// </summary>
        /// <param name="requestData">要求クラス</param>
        /// <returns>Json文字列</returns>
        public static string JsonSerialize(RequestData requestData)
        {
            var options = new JsonSerializerOptions
            {
                // JavaScriptEncoder.Createでエンコードしない文字を指定するのも可
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                // 読みやすいようインデントを付ける
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(requestData, options);
            return json;
        }

    }
}
