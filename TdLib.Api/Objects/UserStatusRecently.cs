using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class UserStatus : Object
        {
            /// <summary>
            /// The user was online recently
            /// </summary>
            public class UserStatusRecently : UserStatus
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userStatusRecently";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Exact user's status is hidden because the current user enabled userPrivacySettingShowStatus privacy setting for the user and has no Telegram Premium
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("by_my_privacy_settings")]
                public bool ByMyPrivacySettings { get; set; }
            }
        }
    }
}