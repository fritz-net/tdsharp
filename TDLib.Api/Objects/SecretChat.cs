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
        /// Represents a secret chat
        /// </summary>
        public class SecretChat : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "secretChat";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Secret chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// Identifier of the chat partner
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            /// <summary>
            /// State of the secret chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("state")]
            public SecretChatState State { get; set; }

            /// <summary>
            /// True, if the chat was created by the current user; otherwise false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_outbound")]
            public bool IsOutbound { get; set; }

            /// <summary>
            /// Current message Time To Live setting (self-destruct timer) for the chat, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("ttl")]
            public int Ttl { get; set; }

            /// <summary>
            /// Hash of the currently used key for comparison with the hash of the chat partner's key. This is a string of 36 little-endian bytes, which must be split into groups of 2 bits, each denoting a pixel of one of 4 colors FFFFFF, D5E6F3, 2D5775, and 2F99C9.
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("key_hash")]
            public byte[] KeyHash { get; set; }

            /// <summary>
            /// Secret chat layer; determines features supported by the other client. Video notes are supported if the layer >= 66; nested text entities and underline and strikethrough entities are supported if the layer >= 101
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("layer")]
            public int Layer { get; set; }
        }
    }
}