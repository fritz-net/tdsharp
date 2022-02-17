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
        /// Changes default participant identifier, on whose behalf a video chat in the chat will be joined
        /// </summary>
        public class SetVideoChatDefaultParticipant : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setVideoChatDefaultParticipant";

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
            /// Default group call participant identifier to join the video chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("default_participant_id")]
            public MessageSender DefaultParticipantId { get; set; }
        }

        /// <summary>
        /// Changes default participant identifier, on whose behalf a video chat in the chat will be joined
        /// </summary>
        public static Task<Ok> SetVideoChatDefaultParticipantAsync(
            this Client client, long chatId = default, MessageSender defaultParticipantId = default)
        {
            return client.ExecuteAsync(new SetVideoChatDefaultParticipant
            {
                ChatId = chatId, DefaultParticipantId = defaultParticipantId
            });
        }
    }
}