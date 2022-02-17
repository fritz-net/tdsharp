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
        /// Edits the text of a message (or a text of a game message). Returns the edited message after the edit is completed on the server side
        /// </summary>
        public class EditMessageText : Function<Message>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editMessageText";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The chat the message belongs to
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// The new message reply markup; pass null if none; for bots only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_markup")]
            public ReplyMarkup ReplyMarkup { get; set; }

            /// <summary>
            /// New text content of the message. Must be of type inputMessageText
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("input_message_content")]
            public InputMessageContent InputMessageContent { get; set; }
        }

        /// <summary>
        /// Edits the text of a message (or a text of a game message). Returns the edited message after the edit is completed on the server side
        /// </summary>
        public static Task<Message> EditMessageTextAsync(
            this Client client, long chatId = default, long messageId = default, ReplyMarkup replyMarkup = default, InputMessageContent inputMessageContent = default)
        {
            return client.ExecuteAsync(new EditMessageText
            {
                ChatId = chatId, MessageId = messageId, ReplyMarkup = replyMarkup, InputMessageContent = inputMessageContent
            });
        }
    }
}