using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class DeviceToken : Object
        {
            /// <summary>
            /// Represents a data needed to subscribe for push notifications through registerDevice method. To use specific push notification service, the correct application platform must be specified and a valid server authentication data must be uploaded at https://my.telegram.org
            /// </summary>
            public class DeviceTokenFirebaseCloudMessaging : DeviceToken
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "deviceTokenFirebaseCloudMessaging";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Device registration token; may be empty to deregister a device
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("token")]
                public string Token { get; set; }

                /// <summary>
                /// True, if push notifications must be additionally encrypted
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("encrypt")]
                public bool Encrypt { get; set; }
            }
        }
    }
}