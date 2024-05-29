using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Asynchronously edits the text, media or caption of a quick reply message. Use quickReplyMessage.can_be_edited to check whether a message can be edited.
        /// Text message can be edited only to a text message. The type of message content in an album can't be changed with exception of replacing a photo with a video or vice versa
        /// </summary>
        public class EditQuickReplyMessage : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editQuickReplyMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of the quick reply shortcut with the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("shortcut_id")]
            public int ShortcutId { get; set; }

            /// <summary>
            /// Identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// New content of the message. Must be one of the following types: inputMessageText, inputMessageAnimation, inputMessageAudio, inputMessageDocument, inputMessagePhoto or inputMessageVideo
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("input_message_content")]
            public InputMessageContent InputMessageContent { get; set; }
        }

        /// <summary>
        /// Asynchronously edits the text, media or caption of a quick reply message. Use quickReplyMessage.can_be_edited to check whether a message can be edited.
        /// Text message can be edited only to a text message. The type of message content in an album can't be changed with exception of replacing a photo with a video or vice versa
        /// </summary>
        public static Task<Ok> EditQuickReplyMessageAsync(
            this Client client, int shortcutId = default, long messageId = default, InputMessageContent inputMessageContent = default)
        {
            return client.ExecuteAsync(new EditQuickReplyMessage
            {
                ShortcutId = shortcutId, MessageId = messageId, InputMessageContent = inputMessageContent
            });
        }
    }
}