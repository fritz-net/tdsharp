using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InternalLinkType : Object
        {
            /// <summary>
            /// The link is a link to a business chat. Use getBusinessChatLinkInfo with the provided link name to get information about the link,
            /// then open received private chat and replace chat draft with the provided text
            /// </summary>
            public class InternalLinkTypeBusinessChat : InternalLinkType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "internalLinkTypeBusinessChat";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Name of the link
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("link_name")]
                public string LinkName { get; set; }
            }
        }
    }
}