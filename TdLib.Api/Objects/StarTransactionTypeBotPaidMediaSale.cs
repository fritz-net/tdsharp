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
        public partial class StarTransactionType : Object
        {
            /// <summary>
            /// The transaction is a sale of paid media by the bot or a business account managed by the bot; for bots only
            /// </summary>
            public class StarTransactionTypeBotPaidMediaSale : StarTransactionType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "starTransactionTypeBotPaidMediaSale";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the user that bought the media
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public long UserId { get; set; }

                /// <summary>
                /// The bought media
                /// </summary>
                [JsonProperty("media", ItemConverterType = typeof(Converter))]
                public PaidMedia[] Media { get; set; }

                /// <summary>
                /// Bot-provided payload
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("payload")]
                public string Payload { get; set; }

                /// <summary>
                /// Information about the affiliate which received commission from the transaction; may be null if none
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("affiliate")]
                public AffiliateInfo Affiliate { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd