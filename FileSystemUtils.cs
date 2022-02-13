using System.Xml.Serialization;

namespace SwiitchBotTestConsole
{
    public static class FileSystemUtils
    {
        //保存元のファイル名
        private static string SceneDataFileName = @"Xml/SceneData.xml";
        private static string SwitchBotSettingFileName = @"Xml/SwitchBotSetting.xml";

        public static SceneData LoadSeceneData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SceneData));
            System.IO.StreamReader sr = new System.IO.StreamReader(SceneDataFileName, new System.Text.UTF8Encoding(false));
            SceneData sceneData = (SceneData)serializer.Deserialize(sr);
            sr.Close();

            return sceneData;
        }

        public static SwitchBotSetting LoadSwitchBotSetting()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SwitchBotSetting));
            System.IO.StreamReader sr = new System.IO.StreamReader(SwitchBotSettingFileName, new System.Text.UTF8Encoding(false));
            SwitchBotSetting switchBotSetting = (SwitchBotSetting)serializer.Deserialize(sr);
            sr.Close();

            return switchBotSetting;
        }


    }
}
