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
        /// Changes the ability of users to save, forward, or copy chat content. Supported only for basic groups, supergroups and channels. Requires owner privileges
        /// </summary>
        public class ToggleChatHasProtectedContent : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "toggleChatHasProtectedContent";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// True, if chat content can't be saved locally, forwarded, or copied
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_protected_content")]
            public bool HasProtectedContent { get; set; }
        }

        /// <summary>
        /// Changes the ability of users to save, forward, or copy chat content. Supported only for basic groups, supergroups and channels. Requires owner privileges
        /// </summary>
        public static Task<Ok> ToggleChatHasProtectedContentAsync(
            this Client client, long chatId = default, bool hasProtectedContent = default)
        {
            return client.ExecuteAsync(new ToggleChatHasProtectedContent
            {
                ChatId = chatId, HasProtectedContent = hasProtectedContent
            });
        }
    }
}