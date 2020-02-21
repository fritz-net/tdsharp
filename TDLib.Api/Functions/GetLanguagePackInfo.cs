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
        /// Returns information about a language pack. Returned language pack identifier may be different from a provided one. Can be called before authorization 
        /// </summary>
        public class GetLanguagePackInfo : Function<LanguagePackInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getLanguagePackInfo";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Language pack identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("language_pack_id")]
            public string LanguagePackId { get; set; }
        }


        /// <summary>
        /// Returns information about a language pack. Returned language pack identifier may be different from a provided one. Can be called before authorization 
        /// </summary>
        public static Task<LanguagePackInfo> GetLanguagePackInfoAsync(this Client client,
            string languagePackId = default(string))
        {
            return client.ExecuteAsync(new GetLanguagePackInfo
            {
                LanguagePackId = languagePackId,
            });
        }
    }
}