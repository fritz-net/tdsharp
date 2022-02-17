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
        /// Returns messages in a message thread of a message. Can be used only if message.can_get_message_thread == true. Message thread of a channel message is in the channel's linked supergroup.
        /// </summary>
        public class GetMessageThreadHistory : Function<Messages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getMessageThreadHistory";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Message identifier, which thread history needs to be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// Identifier of the message starting from which history must be fetched; use 0 to get results from the last message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("from_message_id")]
            public long FromMessageId { get; set; }

            /// <summary>
            /// Specify 0 to get results from exactly the from_message_id or a negative offset up to 99 to get additionally some newer messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public int Offset { get; set; }

            /// <summary>
            /// The maximum number of messages to be returned; must be positive and can't be greater than 100. If the offset is negative, the limit must be greater than or equal to -offset. For optimal performance, the number of returned messages is chosen by TDLib and can be smaller than the specified limit
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns messages in a message thread of a message. Can be used only if message.can_get_message_thread == true. Message thread of a channel message is in the channel's linked supergroup.
        /// </summary>
        public static Task<Messages> GetMessageThreadHistoryAsync(
            this Client client, long chatId = default, long messageId = default, long fromMessageId = default, int offset = default, int limit = default)
        {
            return client.ExecuteAsync(new GetMessageThreadHistory
            {
                ChatId = chatId, MessageId = messageId, FromMessageId = fromMessageId, Offset = offset, Limit = limit
            });
        }
    }
}