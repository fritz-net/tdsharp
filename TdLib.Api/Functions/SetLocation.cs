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
        /// Changes the location of the current user. Needs to be called if getOption("is_location_visible") is true and location changes for more than 1 kilometer. Must not be called if the user has a business location
        /// </summary>
        public class SetLocation : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setLocation";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new location of the user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public Location Location { get; set; }
        }

        /// <summary>
        /// Changes the location of the current user. Needs to be called if getOption("is_location_visible") is true and location changes for more than 1 kilometer. Must not be called if the user has a business location
        /// </summary>
        public static Task<Ok> SetLocationAsync(
            this Client client, Location location = default)
        {
            return client.ExecuteAsync(new SetLocation
            {
                Location = location
            });
        }
    }
}