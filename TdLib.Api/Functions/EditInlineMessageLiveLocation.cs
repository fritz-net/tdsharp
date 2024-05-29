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
        /// Edits the content of a live location in an inline message sent via a bot; for bots only
        /// </summary>
        public class EditInlineMessageLiveLocation : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editInlineMessageLiveLocation";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Inline message identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("inline_message_id")]
            public string InlineMessageId { get; set; }

            /// <summary>
            /// The new message reply markup; pass null if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_markup")]
            public ReplyMarkup ReplyMarkup { get; set; }

            /// <summary>
            /// New location content of the message; pass null to stop sharing the live location
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public Location Location { get; set; }

            /// <summary>
            /// New time relative to the message send date, for which the location can be updated, in seconds. If 0x7FFFFFFF specified, then the location can be updated forever.
            /// Otherwise, must not exceed the current live_period by more than a day, and the live location expiration date must remain in the next 90 days. Pass 0 to keep the current live_period
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("live_period")]
            public int LivePeriod { get; set; }

            /// <summary>
            /// The new direction in which the location moves, in degrees; 1-360. Pass 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("heading")]
            public int Heading { get; set; }

            /// <summary>
            /// The new maximum distance for proximity alerts, in meters (0-100000). Pass 0 if the notification is disabled
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("proximity_alert_radius")]
            public int ProximityAlertRadius { get; set; }
        }

        /// <summary>
        /// Edits the content of a live location in an inline message sent via a bot; for bots only
        /// </summary>
        public static Task<Ok> EditInlineMessageLiveLocationAsync(
            this Client client, string inlineMessageId = default, ReplyMarkup replyMarkup = default, Location location = default, int livePeriod = default, int heading = default, int proximityAlertRadius = default)
        {
            return client.ExecuteAsync(new EditInlineMessageLiveLocation
            {
                InlineMessageId = inlineMessageId, ReplyMarkup = replyMarkup, Location = location, LivePeriod = livePeriod, Heading = heading, ProximityAlertRadius = proximityAlertRadius
            });
        }
    }
}