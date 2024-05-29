using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Changes the login email address of the user. The email address can be changed only if the current user already has login email and passwordState.login_email_address_pattern is non-empty.
        /// The change will not be applied until the new login email address is confirmed with checkLoginEmailAddressCode. To use Apple ID/Google ID instead of an email address, call checkLoginEmailAddressCode directly
        /// </summary>
        public class SetLoginEmailAddress : Function<EmailAddressAuthenticationCodeInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setLoginEmailAddress";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// New login email address
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("new_login_email_address")]
            public string NewLoginEmailAddress { get; set; }
        }

        /// <summary>
        /// Changes the login email address of the user. The email address can be changed only if the current user already has login email and passwordState.login_email_address_pattern is non-empty.
        /// The change will not be applied until the new login email address is confirmed with checkLoginEmailAddressCode. To use Apple ID/Google ID instead of an email address, call checkLoginEmailAddressCode directly
        /// </summary>
        public static Task<EmailAddressAuthenticationCodeInfo> SetLoginEmailAddressAsync(
            this Client client, string newLoginEmailAddress = default)
        {
            return client.ExecuteAsync(new SetLoginEmailAddress
            {
                NewLoginEmailAddress = newLoginEmailAddress
            });
        }
    }
}