using System;
using System.Threading.Tasks;

namespace SwiitchBotTestConsole
{
    class MainClass
    {
        
        private static object _lockObj;
        private static ResponceData _responceData;

        private static readonly string SceneListFormat = "No:{0} ID:{1} Name:{2}";

        public static void Main(string[] args)
        {

            Console.WriteLine("Run SwitcBotAPI");
            HttpControl httpControl = new HttpControl();

            _lockObj = new object();

            Task<string> resultScene;

            lock (_lockObj)
            {
                resultScene = httpControl.GetSceneAsync();
            }

            _responceData = JsonUtility.JsonDeserialize(resultScene.Result);

            for (int i = 0; i < _responceData.BodyObj.Count; i++)
            {
                ResponceData.Body body = _responceData.BodyObj[i];
                Console.WriteLine(string.Format(SceneListFormat, i, body.SceneId, body.SceneName));
            }

            while (true)
            {
                Console.Write("No?:");
                string selectNo = Console.ReadLine();

                if (int.TryParse(selectNo, out int no))
                {
                    Task result;
                    lock (_lockObj)
                    {
                        result = httpControl.RequestAsync(_responceData.BodyObj[no].SceneId);
                    }
                    result.Wait();
                    Console.Write("Retry?[y/n]:");
                    if (Console.ReadLine() != "y")
                    {
                        break;
                    }
                }
            }
        }
    }
}
