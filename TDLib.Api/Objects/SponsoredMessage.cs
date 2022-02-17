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
            /// Sponsor chat identifier; 0 if the sponsor chat is accessible through an invite link
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sponsor_chat_id")]
            public long SponsorChatId { get; set; }

            /// <summary>
            /// Information about the sponsor chat; may be null unless sponsor_chat_id == 0
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sponsor_chat_info")]
            public ChatInviteLinkInfo SponsorChatInfo { get; set; }

            /// <summary>
            /// An internal link to be opened when the sponsored message is clicked; may be null. If null, the sponsor chat needs to be opened instead
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("link")]
            public InternalLinkType Link { get; set; }

            /// <summary>
            /// Content of the message. Currently, can be only of the type messageText
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("content")]
            public MessageContent Content { get; set; }
        }
    }
}