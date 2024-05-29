using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InternalLinkType : Object
        {
            /// <summary>
            /// The link is a link to a story. Call searchPublicChat with the given sender username, then call getStory with the received chat identifier and the given story identifier, then show the story if received
            /// </summary>
            public class InternalLinkTypeStory : InternalLinkType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "internalLinkTypeStory";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Username of the sender of the story
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("story_sender_username")]
                public string StorySenderUsername { get; set; }

                /// <summary>
                /// Story identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("story_id")]
                public int StoryId { get; set; }
            }
        }
    }
}