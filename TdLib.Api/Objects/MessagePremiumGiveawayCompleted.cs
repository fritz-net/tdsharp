using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A Telegram Premium giveaway without public winners has been completed for the chat
            /// </summary>
            public class MessagePremiumGiveawayCompleted : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messagePremiumGiveawayCompleted";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the message with the giveaway; can be 0 if the message was deleted
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("giveaway_message_id")]
                public long GiveawayMessageId { get; set; }

                /// <summary>
                /// Number of winners in the giveaway
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("winner_count")]
                public int WinnerCount { get; set; }

                /// <summary>
                /// Number of undistributed prizes
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("unclaimed_prize_count")]
                public int UnclaimedPrizeCount { get; set; }
            }
        }
    }
}