using System;
using System.Threading.Tasks;

namespace SwiitchBotTestConsole
{
    class MainClass
    {
        private static SceneData _sceneData;
        private static object _lockObj;

        public static void Main(string[] args)
        {

            Console.WriteLine("Run SwitcBotAPI");
            _sceneData = FileSystemUtils.LoadSeceneData();
            HttpControl httpControl = new HttpControl();

            _lockObj = new object();

            Task result;
            lock(_lockObj)
            {
                result = httpControl.RequestAsync(_sceneData.AirConditioner.HeaterOn);
            }

            result.Wait();

            Console.WriteLine("Exit");
            Console.ReadLine();
            
        }

        
    }
}
