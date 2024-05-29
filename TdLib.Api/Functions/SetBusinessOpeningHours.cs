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
        /// Changes the business opening hours of the current user. Requires Telegram Business subscription
        /// </summary>
        public class SetBusinessOpeningHours : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setBusinessOpeningHours";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new opening hours of the business; pass null to remove the opening hours; up to 28 time intervals can be specified
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("opening_hours")]
            public BusinessOpeningHours OpeningHours { get; set; }
        }

        /// <summary>
        /// Changes the business opening hours of the current user. Requires Telegram Business subscription
        /// </summary>
        public static Task<Ok> SetBusinessOpeningHoursAsync(
            this Client client, BusinessOpeningHours openingHours = default)
        {
            return client.ExecuteAsync(new SetBusinessOpeningHours
            {
                OpeningHours = openingHours
            });
        }
    }
}