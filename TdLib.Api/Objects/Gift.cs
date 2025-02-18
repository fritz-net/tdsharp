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
        /// <summary>
        /// Describes a gift that can be sent to another user or channel chat
        /// </summary>
        public partial class Gift : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "gift";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of the gift
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public long Id { get; set; }

            /// <summary>
            /// The sticker representing the gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public Sticker Sticker { get; set; }

            /// <summary>
            /// Number of Telegram Stars that must be paid for the gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("star_count")]
            public long StarCount { get; set; }

            /// <summary>
            /// Number of Telegram Stars that can be claimed by the receiver instead of the regular gift by default. If the gift was paid with just bought Telegram Stars, then full value can be claimed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("default_sell_star_count")]
            public long DefaultSellStarCount { get; set; }

            /// <summary>
            /// Number of Telegram Stars that must be paid to upgrade the gift; 0 if upgrade isn't possible
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("upgrade_star_count")]
            public long UpgradeStarCount { get; set; }

            /// <summary>
            /// True, if the gift is a birthday gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_for_birthday")]
            public bool IsForBirthday { get; set; }

            /// <summary>
            /// Number of remaining times the gift can be purchased; 0 if not limited or the gift was sold out
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("remaining_count")]
            public int RemainingCount { get; set; }

            /// <summary>
            /// Number of total times the gift can be purchased; 0 if not limited
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("total_count")]
            public int TotalCount { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the gift was send for the first time; for sold out gifts only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("first_send_date")]
            public int FirstSendDate { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the gift was send for the last time; for sold out gifts only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_send_date")]
            public int LastSendDate { get; set; }
        }
    }
}
// REUSE-IgnoreEnd