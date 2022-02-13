using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
        /// 
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
