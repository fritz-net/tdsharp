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
        /// Represents the results of the inline query. Use sendInlineQueryResultMessage to send the result of the query
        /// </summary>
        public partial class InlineQueryResults : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "inlineQueryResults";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of the inline query
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("inline_query_id")]
            public long InlineQueryId { get; set; }

            /// <summary>
            /// Button to be shown above inline query results; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("button")]
            public InlineQueryResultsButton Button { get; set; }

            /// <summary>
            /// Results of the query
            /// </summary>
            [JsonProperty("results", ItemConverterType = typeof(Converter))]
            public InlineQueryResult[] Results { get; set; }

            /// <summary>
            /// The offset for the next request. If empty, then there are no more results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("next_offset")]
            public string NextOffset { get; set; }
        }
    }
}