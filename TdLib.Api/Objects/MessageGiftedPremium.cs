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
            /// Telegram Premium was gifted to the user
            /// </summary>
            public class MessageGiftedPremium : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageGiftedPremium";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The identifier of a user that gifted Telegram Premium; 0 if the gift was anonymous
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("gifter_user_id")]
                public long GifterUserId { get; set; }

                /// <summary>
                /// Currency for the paid amount
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("currency")]
                public string Currency { get; set; }

                /// <summary>
                /// The paid amount, in the smallest units of the currency
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("amount")]
                public long Amount { get; set; }

                /// <summary>
                /// Cryptocurrency used to pay for the gift; may be empty if none
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("cryptocurrency")]
                public string Cryptocurrency { get; set; }

                /// <summary>
                /// The paid amount, in the smallest units of the cryptocurrency; 0 if none
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("cryptocurrency_amount")]
                public long CryptocurrencyAmount { get; set; }

                /// <summary>
                /// Number of months the Telegram Premium subscription will be active
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
            }
        }
    }
}