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
        /// Deletes all messages in a Saved Messages topic
        /// </summary>
        public class DeleteSavedMessagesTopicHistory : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deleteSavedMessagesTopicHistory";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of Saved Messages topic which messages will be deleted
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("saved_messages_topic_id")]
            public long SavedMessagesTopicId { get; set; }
        }

        /// <summary>
        /// Deletes all messages in a Saved Messages topic
        /// </summary>
        public static Task<Ok> DeleteSavedMessagesTopicHistoryAsync(
            this Client client, long savedMessagesTopicId = default)
        {
            return client.ExecuteAsync(new DeleteSavedMessagesTopicHistory
            {
                SavedMessagesTopicId = savedMessagesTopicId
            });
        }
    }
}