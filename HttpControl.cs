﻿using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SwiitchBotTestConsole
{
    public class HttpControl
    {
        /// <summary>
        /// SwitchBotURL
        /// </summary>
        private static readonly string SwitchBotUrl = "https://api.switch-bot.com/v1.0/scenes/";

        /// <summary>
        /// SwitchBot設定ファイルデータ
        /// </summary>
        private SwitchBotSetting _switchBotSetting;

        /// <summary>
        /// ステータスフォーマット
        /// </summary>
        private static readonly string StatusFormat = "StatusCode:{0}";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HttpControl()
        {
            _switchBotSetting = FileSystemUtils.LoadSwitchBotSetting();
        }

        /// <summary>
        /// SwitchBot要求送信
        /// </summary>
        /// <param name="sceneID">シーンID</param>
        /// <returns></returns>
        public async Task RequestAsync(string sceneID)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {

                    HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, SwitchBotUrl + sceneID + "/execute");
                    RequestData requestData = new RequestData();
                    var content = new StringContent(JsonUtility.JsonSerialize(requestData), Encoding.UTF8, "application/json");
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", _switchBotSetting.Authorization);

                    HttpResponseMessage result = await httpClient.SendAsync(requestMessage);
                    string resultJson = await result.Content.ReadAsStringAsync();

                    if(result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine("StatusOK");
                    }
                    else
                    {
                        Console.WriteLine("StatusNG");
                        Console.WriteLine(string.Format(StatusFormat, result.StatusCode));
                    }

                    Console.WriteLine(resultJson);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

    }
}
