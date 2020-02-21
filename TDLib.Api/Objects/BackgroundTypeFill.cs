using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// A filled background 
        /// </summary>
        public partial class BackgroundType : Object
        {
            /// <summary>
            /// A filled background 
            /// </summary>
            public class BackgroundTypeFill : BackgroundType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "backgroundTypeFill";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Description of the background fill
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("fill")]
                public BackgroundFill Fill { get; set; }
            }
        }
    }
}