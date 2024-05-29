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
        /// Manually adds a new animation to the list of saved animations. The new animation is added to the beginning of the list. If the animation was already in the list, it is removed first.
        /// Only non-secret video animations with MIME type "video/mp4" can be added to the list
        /// </summary>
        public class AddSavedAnimation : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addSavedAnimation";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The animation file to be added. Only animations known to the server (i.e., successfully sent via a message) can be added to the list
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("animation")]
            public InputFile Animation { get; set; }
        }

        /// <summary>
        /// Manually adds a new animation to the list of saved animations. The new animation is added to the beginning of the list. If the animation was already in the list, it is removed first.
        /// Only non-secret video animations with MIME type "video/mp4" can be added to the list
        /// </summary>
        public static Task<Ok> AddSavedAnimationAsync(
            this Client client, InputFile animation = default)
        {
            return client.ExecuteAsync(new AddSavedAnimation
            {
                Animation = animation
            });
        }
    }
}