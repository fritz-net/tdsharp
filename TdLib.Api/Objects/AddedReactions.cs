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
        /// Represents a list of reactions added to a message
        /// </summary>
        public partial class AddedReactions : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addedReactions";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The total number of found reactions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("total_count")]
            public int TotalCount { get; set; }

            /// <summary>
            /// The list of added reactions
            /// </summary>
            [JsonProperty("reactions", ItemConverterType = typeof(Converter))]
            public AddedReaction[] Reactions { get; set; }

            /// <summary>
            /// The offset for the next request. If empty, then there are no more results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("next_offset")]
            public string NextOffset { get; set; }
        }
    }
}