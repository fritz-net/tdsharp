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
        /// Removes a sticker from the set to which it belongs. The sticker set must be owned by the current user
        /// </summary>
        public class RemoveStickerFromSet : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "removeStickerFromSet";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Sticker to remove from the set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public InputFile Sticker { get; set; }
        }

        /// <summary>
        /// Removes a sticker from the set to which it belongs. The sticker set must be owned by the current user
        /// </summary>
        public static Task<Ok> RemoveStickerFromSetAsync(
            this Client client, InputFile sticker = default)
        {
            return client.ExecuteAsync(new RemoveStickerFromSet
            {
                Sticker = sticker
            });
        }
    }
}