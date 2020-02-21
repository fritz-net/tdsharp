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
        /// The is_all_history_available setting of a supergroup was toggled 
        /// </summary>
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// The is_all_history_available setting of a supergroup was toggled 
            /// </summary>
            public class ChatEventIsAllHistoryAvailableToggled : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventIsAllHistoryAvailableToggled";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// New value of is_all_history_available
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_all_history_available")]
                public bool IsAllHistoryAvailable { get; set; }
            }
        }
    }
}