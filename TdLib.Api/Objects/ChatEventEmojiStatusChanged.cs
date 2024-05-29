using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// The chat emoji status was changed
            /// </summary>
            public class ChatEventEmojiStatusChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventEmojiStatusChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Previous emoji status; may be null if none
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_emoji_status")]
                public EmojiStatus OldEmojiStatus { get; set; }

                /// <summary>
                /// New emoji status; may be null if none
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_emoji_status")]
                public EmojiStatus NewEmojiStatus { get; set; }
            }
        }
    }
}