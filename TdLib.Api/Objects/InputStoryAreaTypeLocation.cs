using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputStoryAreaType : Object
        {
            /// <summary>
            /// Describes type of clickable rectangle area on a story media to be added
            /// </summary>
            public class InputStoryAreaTypeLocation : InputStoryAreaType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputStoryAreaTypeLocation";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The location
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("location")]
                public Location Location { get; set; }
            }
        }
    }
}