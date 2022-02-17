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
        /// Forwards previously sent messages. Returns the forwarded messages in the same order as the message identifiers passed in message_ids. If a message can't be forwarded, null will be returned instead of the message
        /// </summary>
        public class ForwardMessages : Function<Messages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "forwardMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which to forward messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the chat from which to forward messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("from_chat_id")]
            public long FromChatId { get; set; }

            /// <summary>
            /// Identifiers of the messages to forward. Message identifiers must be in a strictly increasing order. At most 100 messages can be forwarded simultaneously
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_ids")]
            public long[] MessageIds { get; set; }

            /// <summary>
            /// Options to be used to send the messages; pass null to use default options
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("options")]
            public MessageSendOptions Options { get; set; }

            /// <summary>
            /// If true, content of the messages will be copied without reference to the original sender. Always true if the messages are forwarded to a secret chat or are local
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("send_copy")]
            public bool SendCopy { get; set; }

            /// <summary>
            /// If true, media caption of message copies will be removed. Ignored if send_copy is false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("remove_caption")]
            public bool RemoveCaption { get; set; }

            /// <summary>
            /// If true, messages will not be forwarded and instead fake messages will be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("only_preview")]
            public bool OnlyPreview { get; set; }
        }

        /// <summary>
        /// Forwards previously sent messages. Returns the forwarded messages in the same order as the message identifiers passed in message_ids. If a message can't be forwarded, null will be returned instead of the message
        /// </summary>
        public static Task<Messages> ForwardMessagesAsync(
            this Client client, long chatId = default, long fromChatId = default, long[] messageIds = default, MessageSendOptions options = default, bool sendCopy = default, bool removeCaption = default, bool onlyPreview = default)
        {
            return client.ExecuteAsync(new ForwardMessages
            {
                ChatId = chatId, FromChatId = fromChatId, MessageIds = messageIds, Options = options, SendCopy = sendCopy, RemoveCaption = removeCaption, OnlyPreview = onlyPreview
            });
        }
    }
}