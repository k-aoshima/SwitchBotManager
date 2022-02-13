using System;
namespace SwiitchBotTestConsole
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SwitchBotSetting
    {

        private string authorizationField;

        public string Authorization
        {
            get
            {
                return authorizationField;
            }
            set
            {
                this.authorizationField = value;
            }

        }
    }
}
