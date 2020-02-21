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
        /// A Telegram Passport element containing the user's bank statement
        /// </summary>
        public partial class PassportElementType : Object
        {
            /// <summary>
            /// A Telegram Passport element containing the user's bank statement
            /// </summary>
            public class PassportElementTypeBankStatement : PassportElementType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementTypeBankStatement";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}