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
        /// A sticker to be added to a sticker set
        /// </summary>
        public partial class InputSticker : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "inputSticker";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// File with the sticker; must fit in a 512x512 square. For WEBP stickers and masks the file must be in PNG format, which will be converted to WEBP server-side. Otherwise, the file must be local or uploaded within a week. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public InputFile Sticker { get; set; }

            /// <summary>
            /// Emojis corresponding to the sticker
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("emojis")]
            public string Emojis { get; set; }

            /// <summary>
            /// Sticker type
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public StickerType Type { get; set; }
        }
    }
}