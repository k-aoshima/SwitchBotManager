 using System;
namespace SwiitchBotTestConsole
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SceneData
    {
        private AirConditionerObj _airConditionerObj;
        private HDMIObj _hDMIObj;

        public AirConditionerObj AirConditioner
        {
            get
            {
                return _airConditionerObj;
            }
            set
            {
                this._airConditionerObj = value;
            }
        }

        public HDMIObj HDMI
        {
            get
            {
                return _hDMIObj;
            }
            set
            {
                this._hDMIObj = value;
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        /// <summary>
        /// エアコン
        /// </summary>
        public partial class AirConditionerObj
        {
            private string heaterOnField;
            private string coolerOnField;

            /// <summary>
            /// 暖房ON
            /// </summary>
            public string HeaterOn
            {
                get
                {
                    return heaterOnField;
                }
                set
                {
                    this.heaterOnField = value;
                }
            }

            /// <summary>
            /// 冷房ON
            /// </summary>
            public string CoolerOn
            {
                get
                {
                    return coolerOnField;
                }

                set
                {
                    this.coolerOnField = value;
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        /// <summary>
        /// HDMI
        /// </summary>
        public class HDMIObj
        {
            private string chromeChastField;
            private string switchField;
            private string pcField;

            /// <summary>
            /// ChromeCast
            /// </summary>
            public string ChromeCast
            {
                get
                {
                    return chromeChastField;
                }
                set
                {
                    this.chromeChastField = value;
                }
            }

            /// <summary>
            /// Switch
            /// </summary>
            public string Switch
            {
                get
                {
                    return switchField;
                }
                set
                {
                    this.switchField = value;
                }
            }

            /// <summary>
            /// PC
            /// </summary>
            public string PC
            {
                get
                {
                    return pcField;
                }
                set
                {
                    this.pcField = value;
                }
            }

        }

    }
}
