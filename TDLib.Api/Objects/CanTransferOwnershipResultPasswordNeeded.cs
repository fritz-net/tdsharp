using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class CanTransferOwnershipResult : Object
        {
            /// <summary>
            /// The 2-step verification needs to be enabled first
            /// </summary>
            public class CanTransferOwnershipResultPasswordNeeded : CanTransferOwnershipResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "canTransferOwnershipResultPasswordNeeded";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}