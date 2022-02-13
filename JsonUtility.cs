using System.Text.Json;

namespace SwiitchBotTestConsole
{
    public class JsonUtility
    {
        public JsonUtility(){  }

        /// <summary>
        /// Jsonデシリアライズ
        /// </summary>
        /// <param name="responceData"></param>
        /// <returns></returns>
        public static ResponceData JsonDeserialize(string responceData)
        {
            ResponceData responce = JsonSerializer.Deserialize<ResponceData>(responceData);
            return responce;
        }

    }
}
