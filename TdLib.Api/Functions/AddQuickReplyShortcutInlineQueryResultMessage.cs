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
        /// Adds a message to a quick reply shortcut via inline bot. If shortcut doesn't exist and there are less than getOption("quick_reply_shortcut_count_max") shortcuts, then a new shortcut is created.
        /// The shortcut must not contain more than getOption("quick_reply_shortcut_message_count_max") messages after adding the new message. Returns the added message
        /// </summary>
        public class AddQuickReplyShortcutInlineQueryResultMessage : Function<QuickReplyMessage>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addQuickReplyShortcutInlineQueryResultMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Name of the target shortcut
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("shortcut_name")]
            public string ShortcutName { get; set; }

            /// <summary>
            /// Identifier of a quick reply message in the same shortcut to be replied; pass 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_to_message_id")]
            public long ReplyToMessageId { get; set; }

            /// <summary>
            /// Identifier of the inline query
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("query_id")]
            public long QueryId { get; set; }

            /// <summary>
            /// Identifier of the inline query result
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("result_id")]
            public string ResultId { get; set; }

            /// <summary>
            /// Pass true to hide the bot, via which the message is sent. Can be used only for bots getOption("animation_search_bot_username"), getOption("photo_search_bot_username"), and getOption("venue_search_bot_username")
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("hide_via_bot")]
            public bool HideViaBot { get; set; }
        }

        /// <summary>
        /// Adds a message to a quick reply shortcut via inline bot. If shortcut doesn't exist and there are less than getOption("quick_reply_shortcut_count_max") shortcuts, then a new shortcut is created.
        /// The shortcut must not contain more than getOption("quick_reply_shortcut_message_count_max") messages after adding the new message. Returns the added message
        /// </summary>
        public static Task<QuickReplyMessage> AddQuickReplyShortcutInlineQueryResultMessageAsync(
            this Client client, string shortcutName = default, long replyToMessageId = default, long queryId = default, string resultId = default, bool hideViaBot = default)
        {
            return client.ExecuteAsync(new AddQuickReplyShortcutInlineQueryResultMessage
            {
                ShortcutName = shortcutName, ReplyToMessageId = replyToMessageId, QueryId = queryId, ResultId = resultId, HideViaBot = hideViaBot
            });
        }
    }
}