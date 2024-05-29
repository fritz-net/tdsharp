using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InternalLinkType : Object
        {
            /// <summary>
            /// The link is a link to a game. Call searchPublicChat with the given bot username, check that the user is a bot,
            /// ask the current user to select a chat to send the game, and then call sendMessage with inputMessageGame
            /// </summary>
            public class InternalLinkTypeGame : InternalLinkType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "internalLinkTypeGame";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Username of the bot that owns the game
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("bot_username")]
                public string BotUsername { get; set; }

                /// <summary>
                /// Short name of the game
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("game_short_name")]
                public string GameShortName { get; set; }
            }
        }
    }
}