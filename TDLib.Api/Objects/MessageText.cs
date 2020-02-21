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
        /// A text message 
        /// </summary>
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A text message 
            /// </summary>
            public class MessageText : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageText";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Text of the message 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public FormattedText Text { get; set; }

                /// <summary>
                /// A preview of the web page that's mentioned in the text; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("web_page")]
                public WebPage WebPage { get; set; }
            }
        }
    }
}