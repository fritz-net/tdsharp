using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ChatRevenueTransactionType : Object
        {
            /// <summary>
            /// Describes type of transaction for revenue earned from sponsored messages in a chat
            /// </summary>
            public class ChatRevenueTransactionTypeEarnings : ChatRevenueTransactionType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatRevenueTransactionTypeEarnings";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Point in time (Unix timestamp) when the earnings started
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("start_date")]
                public int StartDate { get; set; }

                /// <summary>
                /// Point in time (Unix timestamp) when the earnings ended
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("end_date")]
                public int EndDate { get; set; }
            }
        }
    }
}