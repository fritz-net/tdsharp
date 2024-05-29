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
        /// Returns the list of features available on the specific chat boost level; this is an offline request
        /// </summary>
        public class GetChatBoostLevelFeatures : Function<ChatBoostLevelFeatures>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatBoostLevelFeatures";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Pass true to get the list of features for channels; pass false to get the list of features for supergroups
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_channel")]
            public bool IsChannel { get; set; }

            /// <summary>
            /// Chat boost level
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("level")]
            public int Level { get; set; }
        }

        /// <summary>
        /// Returns the list of features available on the specific chat boost level; this is an offline request
        /// </summary>
        public static Task<ChatBoostLevelFeatures> GetChatBoostLevelFeaturesAsync(
            this Client client, bool isChannel = default, int level = default)
        {
            return client.ExecuteAsync(new GetChatBoostLevelFeatures
            {
                IsChannel = isChannel, Level = level
            });
        }
    }
}