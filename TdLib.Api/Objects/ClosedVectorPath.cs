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
        /// Represents a closed vector path. The path begins at the end point of the last command. The coordinate system origin is in the upper-left corner
        /// </summary>
        public partial class ClosedVectorPath : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "closedVectorPath";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of vector path commands
            /// </summary>
            [JsonProperty("commands", ItemConverterType = typeof(Converter))]
            public VectorPathCommand[] Commands { get; set; }
        }
    }
}
// REUSE-IgnoreEnd