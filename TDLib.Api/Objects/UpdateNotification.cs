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
        /// A notification was changed 
        /// </summary>
        public partial class Update : Object
        {
            /// <summary>
            /// A notification was changed 
            /// </summary>
            public class UpdateNotification : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateNotification";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique notification group identifier 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("notification_group_id")]
                public int NotificationGroupId { get; set; }

                /// <summary>
                /// Changed notification
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("notification")]
                public Notification Notification { get; set; }
            }
        }
    }
}