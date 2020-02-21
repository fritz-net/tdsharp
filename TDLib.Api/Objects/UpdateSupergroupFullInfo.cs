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
        /// Some data from supergroupFullInfo has been changed 
        /// </summary>
        public partial class Update : Object
        {
            /// <summary>
            /// Some data from supergroupFullInfo has been changed 
            /// </summary>
            public class UpdateSupergroupFullInfo : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateSupergroupFullInfo";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the supergroup or channel 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_id")]
                public int SupergroupId { get; set; }

                /// <summary>
                /// New full information about the supergroup
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_full_info")]
                public SupergroupFullInfo SupergroupFullInfo { get; set; }
            }
        }
    }
}