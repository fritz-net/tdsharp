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
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A Telegram Premium gift code was created for the user
            /// </summary>
            public class MessagePremiumGiftCode : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messagePremiumGiftCode";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of a chat or a user that created the gift code; may be null if unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("creator_id")]
                public MessageSender CreatorId { get; set; }

                /// <summary>
                /// Message added to the gift
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public FormattedText Text { get; set; }

                /// <summary>
                /// True, if the gift code was created for a giveaway
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_from_giveaway")]
                public bool IsFromGiveaway { get; set; }

                /// <summary>
                /// True, if the winner for the corresponding Telegram Premium subscription wasn't chosen
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_unclaimed")]
                public bool IsUnclaimed { get; set; }

                /// <summary>
                /// Currency for the paid amount; empty if unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("currency")]
                public string Currency { get; set; }

                /// <summary>
                /// The paid amount, in the smallest units of the currency; 0 if unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("amount")]
                public long Amount { get; set; }

                /// <summary>
                /// Cryptocurrency used to pay for the gift; may be empty if none or unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("cryptocurrency")]
                public string Cryptocurrency { get; set; }

                /// <summary>
                /// The paid amount, in the smallest units of the cryptocurrency; 0 if unknown
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("cryptocurrency_amount")]
                public long CryptocurrencyAmount { get; set; }

                /// <summary>
                /// Number of months the Telegram Premium subscription will be active after code activation
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("month_count")]
                public int MonthCount { get; set; }

                /// <summary>
                /// A sticker to be shown in the message; may be null if unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker")]
                public Sticker Sticker { get; set; }

                /// <summary>
                /// The gift code
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("code")]
                public string Code { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd