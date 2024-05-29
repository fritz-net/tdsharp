using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class AuthenticationCodeType : Object
        {
            /// <summary>
            /// A digit-only authentication code is delivered to https://fragment.com. The user must be logged in there via a wallet owning the phone number's NFT
            /// </summary>
            public class AuthenticationCodeTypeFragment : AuthenticationCodeType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authenticationCodeTypeFragment";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// URL to open to receive the code
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("url")]
                public string Url { get; set; }

                /// <summary>
                /// Length of the code
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("length")]
                public int Length { get; set; }
            }
        }
    }
}