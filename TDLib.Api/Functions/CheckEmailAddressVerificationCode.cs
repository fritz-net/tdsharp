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
        /// Checks the email address verification code for Telegram Passport
        /// </summary>
        public class CheckEmailAddressVerificationCode : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "checkEmailAddressVerificationCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Verification code to check
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("code")]
            public string Code { get; set; }
        }

        /// <summary>
        /// Checks the email address verification code for Telegram Passport
        /// </summary>
        public static Task<Ok> CheckEmailAddressVerificationCodeAsync(
            this Client client, string code = default)
        {
            return client.ExecuteAsync(new CheckEmailAddressVerificationCode
            {
                Code = code
            });
        }
    }
}