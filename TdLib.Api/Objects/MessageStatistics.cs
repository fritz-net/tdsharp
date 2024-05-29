using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// A detailed statistics about a message
        /// </summary>
        public partial class MessageStatistics : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageStatistics";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// A graph containing number of message views and shares
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_interaction_graph")]
            public StatisticalGraph MessageInteractionGraph { get; set; }

            /// <summary>
            /// A graph containing number of message reactions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_reaction_graph")]
            public StatisticalGraph MessageReactionGraph { get; set; }
        }
    }
}