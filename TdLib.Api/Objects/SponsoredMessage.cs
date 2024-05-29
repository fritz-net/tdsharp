using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Describes a sponsored message
        /// </summary>
        public partial class SponsoredMessage : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sponsoredMessage";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Message identifier; unique for the chat to which the sponsored message belongs among both ordinary and sponsored messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// True, if the message needs to be labeled as "recommended" instead of "sponsored"
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_recommended")]
            public bool IsRecommended { get; set; }

            /// <summary>
            /// True, if the message can be reported to Telegram moderators through reportChatSponsoredMessage
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_reported")]
            public bool CanBeReported { get; set; }

            /// <summary>
            /// Content of the message. Currently, can be only of the type messageText
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("content")]
            public MessageContent Content { get; set; }

            /// <summary>
            /// Information about the sponsor of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sponsor")]
            public MessageSponsor Sponsor { get; set; }

            /// <summary>
            /// Title of the sponsored message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Text for the message action button
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("button_text")]
            public string ButtonText { get; set; }

            /// <summary>
            /// Identifier of the accent color for title, button text and message background
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("accent_color_id")]
            public int AccentColorId { get; set; }

            /// <summary>
            /// Identifier of a custom emoji to be shown on the message background; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("background_custom_emoji_id")]
            public long BackgroundCustomEmojiId { get; set; }

            /// <summary>
            /// If non-empty, additional information about the sponsored message to be shown along with the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("additional_info")]
            public string AdditionalInfo { get; set; }
        }
    }
}