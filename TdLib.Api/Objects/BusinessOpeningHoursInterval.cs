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
        /// Describes an interval of time when the business is open
        /// </summary>
        public partial class BusinessOpeningHoursInterval : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "businessOpeningHoursInterval";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The minute's sequence number in a week, starting on Monday, marking the start of the time interval during which the business is open; 0-7*24*60
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("start_minute")]
            public int StartMinute { get; set; }

            /// <summary>
            /// The minute's sequence number in a week, starting on Monday, marking the end of the time interval during which the business is open; 1-8*24*60
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("end_minute")]
            public int EndMinute { get; set; }
        }
    }
}