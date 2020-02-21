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
        /// Searches for a sticker set by its name 
        /// </summary>
        public class SearchStickerSet : Function<StickerSet>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchStickerSet";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Name of the sticker set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }
        }


        /// <summary>
        /// Searches for a sticker set by its name 
        /// </summary>
        public static Task<StickerSet> SearchStickerSetAsync(this Client client,
            string name = default(string))
        {
            return client.ExecuteAsync(new SearchStickerSet
            {
                Name = name,
            });
        }
    }
}