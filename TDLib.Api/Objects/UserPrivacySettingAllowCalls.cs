using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class UserPrivacySetting : Object
        {
            /// <summary>
            /// A privacy setting for managing whether the user can be called
            /// </summary>
            public class UserPrivacySettingAllowCalls : UserPrivacySetting
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingAllowCalls";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}