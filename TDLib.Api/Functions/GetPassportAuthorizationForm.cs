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
        /// Returns a Telegram Passport authorization form for sharing data with a service
        /// </summary>
        public class GetPassportAuthorizationForm : Function<PassportAuthorizationForm>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getPassportAuthorizationForm";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// User identifier of the service's bot
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_user_id")]
            public long BotUserId { get; set; }

            /// <summary>
            /// Telegram Passport element types requested by the service
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("scope")]
            public string Scope { get; set; }

            /// <summary>
            /// Service's public key
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("public_key")]
            public string PublicKey { get; set; }

            /// <summary>
            /// Unique request identifier provided by the service
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("nonce")]
            public string Nonce { get; set; }
        }

        /// <summary>
        /// Returns a Telegram Passport authorization form for sharing data with a service
        /// </summary>
        public static Task<PassportAuthorizationForm> GetPassportAuthorizationFormAsync(
            this Client client, long botUserId = default, string scope = default, string publicKey = default, string nonce = default)
        {
            return client.ExecuteAsync(new GetPassportAuthorizationForm
            {
                BotUserId = botUserId, Scope = scope, PublicKey = publicKey, Nonce = nonce
            });
        }
    }
}