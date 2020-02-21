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
        /// Returns one of the available Telegram Passport elements 
        /// </summary>
        public class GetPassportElement : Function<PassportElement>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getPassportElement";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Telegram Passport element type 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public PassportElementType Type { get; set; }

            /// <summary>
            /// Password of the current user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("password")]
            public string Password { get; set; }
        }


        /// <summary>
        /// Returns one of the available Telegram Passport elements 
        /// </summary>
        public static Task<PassportElement> GetPassportElementAsync(this Client client,
            PassportElementType type = default(PassportElementType),
            string password = default(string))
        {
            return client.ExecuteAsync(new GetPassportElement
            {
                Type = type,
                Password = password,
            });
        }
    }
}