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
        /// Contains stickers which must be used for reaction animation rendering
        /// </summary>
        public partial class Reaction : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "reaction";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Text representation of the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reaction")]
            public string Reaction_ { get; set; }

            /// <summary>
            /// Reaction title
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// True, if the reaction can be added to new messages and enabled in chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_active")]
            public bool IsActive { get; set; }

            /// <summary>
            /// Static icon for the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("static_icon")]
            public Sticker StaticIcon { get; set; }

            /// <summary>
            /// Appear animation for the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("appear_animation")]
            public Sticker AppearAnimation { get; set; }

            /// <summary>
            /// Select animation for the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("select_animation")]
            public Sticker SelectAnimation { get; set; }

            /// <summary>
            /// Activate animation for the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("activate_animation")]
            public Sticker ActivateAnimation { get; set; }

            /// <summary>
            /// Effect animation for the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("effect_animation")]
            public Sticker EffectAnimation { get; set; }

            /// <summary>
            /// Around animation for the reaction; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("around_animation")]
            public Sticker AroundAnimation { get; set; }

            /// <summary>
            /// Center animation for the reaction; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("center_animation")]
            public Sticker CenterAnimation { get; set; }
        }
    }
}