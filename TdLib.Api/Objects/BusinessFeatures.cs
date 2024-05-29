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
        /// Contains information about features, available to Business user accounts
        /// </summary>
        public partial class BusinessFeatures : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "businessFeatures";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The list of available business features
            /// </summary>
            [JsonProperty("features", ItemConverterType = typeof(Converter))]
            public BusinessFeature[] Features { get; set; }
        }
    }
}