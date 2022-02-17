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
        /// Validates the order information provided by a user and returns the available shipping options for a flexible invoice
        /// </summary>
        public class ValidateOrderInfo : Function<ValidatedOrderInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "validateOrderInfo";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier of the Invoice message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Message identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// The order information, provided by the user; pass null if empty
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("order_info")]
            public OrderInfo OrderInfo { get; set; }

            /// <summary>
            /// True, if the order information can be saved
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("allow_save")]
            public bool AllowSave { get; set; }
        }

        /// <summary>
        /// Validates the order information provided by a user and returns the available shipping options for a flexible invoice
        /// </summary>
        public static Task<ValidatedOrderInfo> ValidateOrderInfoAsync(
            this Client client, long chatId = default, long messageId = default, OrderInfo orderInfo = default, bool allowSave = default)
        {
            return client.ExecuteAsync(new ValidateOrderInfo
            {
                ChatId = chatId, MessageId = messageId, OrderInfo = orderInfo, AllowSave = allowSave
            });
        }
    }
}