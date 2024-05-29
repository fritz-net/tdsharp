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
        /// Returns information about the next messages of the specified type in the chat split by days. Returns the results in reverse chronological order. Can return partial result for the last returned day. Behavior of this method depends on the value of the option "utc_time_offset"
        /// </summary>
        public class GetChatMessageCalendar : Function<MessageCalendar>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatMessageCalendar";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat in which to return information about messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Filter for message content. Filters searchMessagesFilterEmpty, searchMessagesFilterMention, searchMessagesFilterUnreadMention, and searchMessagesFilterUnreadReaction are unsupported in this function
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("filter")]
            public SearchMessagesFilter Filter { get; set; }

            /// <summary>
            /// The message identifier from which to return information about messages; use 0 to get results from the last message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("from_message_id")]
            public long FromMessageId { get; set; }

            /// <summary>
            /// If not0, only messages in the specified Saved Messages topic will be considered; pass 0 to consider all messages, or for chats other than Saved Messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("saved_messages_topic_id")]
            public long SavedMessagesTopicId { get; set; }
        }

        /// <summary>
        /// Returns information about the next messages of the specified type in the chat split by days. Returns the results in reverse chronological order. Can return partial result for the last returned day. Behavior of this method depends on the value of the option "utc_time_offset"
        /// </summary>
        public static Task<MessageCalendar> GetChatMessageCalendarAsync(
            this Client client, long chatId = default, SearchMessagesFilter filter = default, long fromMessageId = default, long savedMessagesTopicId = default)
        {
            return client.ExecuteAsync(new GetChatMessageCalendar
            {
                ChatId = chatId, Filter = filter, FromMessageId = fromMessageId, SavedMessagesTopicId = savedMessagesTopicId
            });
        }
    }
}