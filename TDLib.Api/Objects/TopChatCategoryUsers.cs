using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class TopChatCategory : Object
        {
            /// <summary>
            /// Represents the categories of chats for which a list of frequently used chats can be retrieved
            /// </summary>
            public class TopChatCategoryUsers : TopChatCategory
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "topChatCategoryUsers";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}