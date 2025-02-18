using System;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputMessageContent : Object
        {
            /// <summary>
            /// A forwarded message
            /// </summary>
            public class InputMessageForwarded : InputMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputMessageForwarded";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier for the chat this forwarded message came from
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("from_chat_id")]
                public long FromChatId { get; set; }

                /// <summary>
                /// Identifier of the message to forward. A message can be forwarded only if messageProperties.can_be_forwarded
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }

                /// <summary>
                /// Pass true if a game message is being shared from a launched game; applies only to game messages
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("in_game_share")]
                public bool InGameShare { get; set; }

                /// <summary>
                /// Pass true to replace video start timestamp in the forwarded message
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("replace_video_start_timestamp")]
                public bool ReplaceVideoStartTimestamp { get; set; }

                /// <summary>
                /// The new video start timestamp; ignored if replace_video_start_timestamp == false
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_video_start_timestamp")]
                public int NewVideoStartTimestamp { get; set; }

                /// <summary>
                /// Options to be used to copy content of the message without reference to the original sender; pass null to forward the message as usual
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("copy_options")]
                public MessageCopyOptions CopyOptions { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd