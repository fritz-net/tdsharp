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
        /// Represents a folder for user chats
        /// </summary>
        public partial class ChatFolder : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatFolder";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The title of the folder; 1-12 characters without line feeds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// The chosen icon for the chat folder; may be null. If null, use getChatFolderDefaultIconName to get default icon name for the folder
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("icon")]
            public ChatFolderIcon Icon { get; set; }

            /// <summary>
            /// The identifier of the chosen color for the chat folder icon; from -1 to 6. If -1, then color is disabled. Can't be changed if folder tags are disabled or the current user doesn't have Telegram Premium subscription
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("color_id")]
            public int ColorId { get; set; }

            /// <summary>
            /// True, if at least one link has been created for the folder
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_shareable")]
            public bool IsShareable { get; set; }

            /// <summary>
            /// The chat identifiers of pinned chats in the folder. There can be up to getOption("chat_folder_chosen_chat_count_max") pinned and always included non-secret chats and the same number of secret chats, but the limit can be increased with Telegram Premium
            /// </summary>
            [JsonProperty("pinned_chat_ids", ItemConverterType = typeof(Converter))]
            public long[] PinnedChatIds { get; set; }

            /// <summary>
            /// The chat identifiers of always included chats in the folder. There can be up to getOption("chat_folder_chosen_chat_count_max") pinned and always included non-secret chats and the same number of secret chats, but the limit can be increased with Telegram Premium
            /// </summary>
            [JsonProperty("included_chat_ids", ItemConverterType = typeof(Converter))]
            public long[] IncludedChatIds { get; set; }

            /// <summary>
            /// The chat identifiers of always excluded chats in the folder. There can be up to getOption("chat_folder_chosen_chat_count_max") always excluded non-secret chats and the same number of secret chats, but the limit can be increased with Telegram Premium
            /// </summary>
            [JsonProperty("excluded_chat_ids", ItemConverterType = typeof(Converter))]
            public long[] ExcludedChatIds { get; set; }

            /// <summary>
            /// True, if muted chats need to be excluded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_muted")]
            public bool ExcludeMuted { get; set; }

            /// <summary>
            /// True, if read chats need to be excluded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_read")]
            public bool ExcludeRead { get; set; }

            /// <summary>
            /// True, if archived chats need to be excluded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_archived")]
            public bool ExcludeArchived { get; set; }

            /// <summary>
            /// True, if contacts need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_contacts")]
            public bool IncludeContacts { get; set; }

            /// <summary>
            /// True, if non-contact users need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_non_contacts")]
            public bool IncludeNonContacts { get; set; }

            /// <summary>
            /// True, if bots need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_bots")]
            public bool IncludeBots { get; set; }

            /// <summary>
            /// True, if basic groups and supergroups need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_groups")]
            public bool IncludeGroups { get; set; }

            /// <summary>
            /// True, if channels need to be included
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("include_channels")]
            public bool IncludeChannels { get; set; }
        }
    }
}