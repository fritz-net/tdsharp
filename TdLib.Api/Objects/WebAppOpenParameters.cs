using System;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Options to be used when a Web App is opened
        /// </summary>
        public partial class WebAppOpenParameters : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "webAppOpenParameters";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Preferred Web App theme; pass null to use the default theme
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("theme")]
            public ThemeParameters Theme { get; set; }

            /// <summary>
            /// Short name of the current application; 0-64 English letters, digits, and underscores
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("application_name")]
            public string ApplicationName { get; set; }

            /// <summary>
            /// The mode in which the Web App is opened; pass null to open in webAppOpenModeFullSize
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("mode")]
            public WebAppOpenMode Mode { get; set; }
        }
    }
}
// REUSE-IgnoreEnd