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
        /// Changes the business location of the current user. Requires Telegram Business subscription
        /// </summary>
        public class SetBusinessLocation : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setBusinessLocation";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new location of the business; pass null to remove the location
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public BusinessLocation Location { get; set; }
        }

        /// <summary>
        /// Changes the business location of the current user. Requires Telegram Business subscription
        /// </summary>
        public static Task<Ok> SetBusinessLocationAsync(
            this Client client, BusinessLocation location = default)
        {
            return client.ExecuteAsync(new SetBusinessLocation
            {
                Location = location
            });
        }
    }
}