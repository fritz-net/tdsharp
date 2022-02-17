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
        /// Describes a sticker
        /// </summary>
        public partial class Sticker : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sticker";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The identifier of the sticker set to which the sticker belongs; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("set_id")]
            public long SetId { get; set; }

            /// <summary>
            /// Sticker width; as defined by the sender
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("width")]
            public int Width { get; set; }

            /// <summary>
            /// Sticker height; as defined by the sender
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("height")]
            public int Height { get; set; }

            /// <summary>
            /// Emoji corresponding to the sticker
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("emoji")]
            public string Emoji { get; set; }

            /// <summary>
            /// Sticker type
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public StickerType Type { get; set; }

            /// <summary>
            /// Sticker's outline represented as a list of closed vector paths; may be empty. The coordinate system origin is in the upper-left corner
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("outline")]
            public ClosedVectorPath[] Outline { get; set; }

            /// <summary>
            /// Sticker thumbnail in WEBP or JPEG format; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("thumbnail")]
            public Thumbnail Thumbnail { get; set; }

            /// <summary>
            /// File containing the sticker
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public File Sticker_ { get; set; }
        }
    }
}