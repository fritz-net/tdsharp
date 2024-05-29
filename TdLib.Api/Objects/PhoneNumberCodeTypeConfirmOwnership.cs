using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PhoneNumberCodeType : Object
        {
            /// <summary>
            /// Confirms ownership of a phone number to prevent account deletion while handling links of the type internalLinkTypePhoneNumberConfirmation
            /// </summary>
            public class PhoneNumberCodeTypeConfirmOwnership : PhoneNumberCodeType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "phoneNumberCodeTypeConfirmOwnership";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Hash value from the link
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("hash")]
                public string Hash { get; set; }
            }
        }
    }
}