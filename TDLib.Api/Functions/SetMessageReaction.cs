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
        /// Changes chosen reaction for a message
        /// </summary>
        public class SetMessageReaction : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setMessageReaction";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which the message belongs
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
            /// Text representation of the new chosen reaction. Can be an empty string or the currently chosen reaction to remove the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reaction")]
            public string Reaction { get; set; }

            /// <summary>
            /// True, if the reaction is added with a big animation
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_big")]
            public bool IsBig { get; set; }
        }

        /// <summary>
        /// Changes chosen reaction for a message
        /// </summary>
        public static Task<Ok> SetMessageReactionAsync(
            this Client client, long chatId = default, long messageId = default, string reaction = default, bool isBig = default)
        {
            return client.ExecuteAsync(new SetMessageReaction
            {
                ChatId = chatId, MessageId = messageId, Reaction = reaction, IsBig = isBig
            });
        }
    }
}