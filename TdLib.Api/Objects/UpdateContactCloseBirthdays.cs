using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// The list of contacts that had birthdays recently or will have birthday soon has changed
            /// </summary>
            public class UpdateContactCloseBirthdays : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateContactCloseBirthdays";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// List of contact users with close birthday
                /// </summary>
                [JsonProperty("close_birthday_users", ItemConverterType = typeof(Converter))]
                public CloseBirthdayUser[] CloseBirthdayUsers { get; set; }
            }
        }
    }
}