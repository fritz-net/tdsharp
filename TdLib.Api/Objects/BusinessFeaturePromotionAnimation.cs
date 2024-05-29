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
        /// Describes a promotion animation for a Business feature
        /// </summary>
        public partial class BusinessFeaturePromotionAnimation : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "businessFeaturePromotionAnimation";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Business feature
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("feature")]
            public BusinessFeature Feature { get; set; }

            /// <summary>
            /// Promotion animation for the feature
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("animation")]
            public Animation Animation { get; set; }
        }
    }
}