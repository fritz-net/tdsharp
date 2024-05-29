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
        /// Describes manually or automatically chosen quote from another message
        /// </summary>
        public partial class TextQuote : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "textQuote";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Text of the quote. Only Bold, Italic, Underline, Strikethrough, Spoiler, and CustomEmoji entities can be present in the text
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public FormattedText Text { get; set; }

            /// <summary>
            /// Approximate quote position in the original message in UTF-16 code units as specified by the message sender
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("position")]
            public int Position { get; set; }

            /// <summary>
            /// True, if the quote was manually chosen by the message sender
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_manual")]
            public bool IsManual { get; set; }
        }
    }
}