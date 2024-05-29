using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class KeyboardButtonType : Object
        {
            /// <summary>
            /// A button that requests users to be shared by the current user; available only in private chats. Use the method shareUsersWithBot to complete the request
            /// </summary>
            public class KeyboardButtonTypeRequestUsers : KeyboardButtonType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "keyboardButtonTypeRequestUsers";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique button identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public int Id { get; set; }

                /// <summary>
                /// True, if the shared users must or must not be bots
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("restrict_user_is_bot")]
                public bool RestrictUserIsBot { get; set; }

                /// <summary>
                /// True, if the shared users must be bots; otherwise, the shared users must not be bots. Ignored if restrict_user_is_bot is false
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_is_bot")]
                public bool UserIsBot { get; set; }

                /// <summary>
                /// True, if the shared users must or must not be Telegram Premium users
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("restrict_user_is_premium")]
                public bool RestrictUserIsPremium { get; set; }

                /// <summary>
                /// True, if the shared users must be Telegram Premium users; otherwise, the shared users must not be Telegram Premium users. Ignored if restrict_user_is_premium is false
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_is_premium")]
                public bool UserIsPremium { get; set; }

                /// <summary>
                /// The maximum number of users to share
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("max_quantity")]
                public int MaxQuantity { get; set; }

                /// <summary>
                /// Pass true to request name of the users; bots only
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("request_name")]
                public bool RequestName { get; set; }

                /// <summary>
                /// Pass true to request username of the users; bots only
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("request_username")]
                public bool RequestUsername { get; set; }

                /// <summary>
                /// Pass true to request photo of the users; bots only
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("request_photo")]
                public bool RequestPhoto { get; set; }
            }
        }
    }
}