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
        /// Toggles whether sponsored messages are shown in the channel chat; requires owner privileges in the channel. The chat must have at least chatBoostFeatures.min_sponsored_message_disable_boost_level boost level to disable sponsored messages
        /// </summary>
        public class ToggleSupergroupCanHaveSponsoredMessages : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "toggleSupergroupCanHaveSponsoredMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The identifier of the channel
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroup_id")]
            public long SupergroupId { get; set; }

            /// <summary>
            /// The new value of can_have_sponsored_messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_have_sponsored_messages")]
            public bool CanHaveSponsoredMessages { get; set; }
        }

        /// <summary>
        /// Toggles whether sponsored messages are shown in the channel chat; requires owner privileges in the channel. The chat must have at least chatBoostFeatures.min_sponsored_message_disable_boost_level boost level to disable sponsored messages
        /// </summary>
        public static Task<Ok> ToggleSupergroupCanHaveSponsoredMessagesAsync(
            this Client client, long supergroupId = default, bool canHaveSponsoredMessages = default)
        {
            return client.ExecuteAsync(new ToggleSupergroupCanHaveSponsoredMessages
            {
                SupergroupId = supergroupId, CanHaveSponsoredMessages = canHaveSponsoredMessages
            });
        }
    }
}