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
        /// Joins an active group call. Returns join response payload for tgcalls
        /// </summary>
        public class JoinGroupCall : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "joinGroupCall";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Group call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("group_call_id")]
            public int GroupCallId { get; set; }

            /// <summary>
            /// Identifier of a group call participant, which will be used to join the call; pass null to join as self; video chats only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("participant_id")]
            public MessageSender ParticipantId { get; set; }

            /// <summary>
            /// Caller audio channel synchronization source identifier; received from tgcalls
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("audio_source_id")]
            public int AudioSourceId { get; set; }

            /// <summary>
            /// Group call join payload; received from tgcalls
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("payload")]
            public string Payload { get; set; }

            /// <summary>
            /// True, if the user's microphone is muted
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_muted")]
            public bool IsMuted { get; set; }

            /// <summary>
            /// True, if the user's video is enabled
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_my_video_enabled")]
            public bool IsMyVideoEnabled { get; set; }

            /// <summary>
            /// If non-empty, invite hash to be used to join the group call without being muted by administrators
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_hash")]
            public string InviteHash { get; set; }
        }

        /// <summary>
        /// Joins an active group call. Returns join response payload for tgcalls
        /// </summary>
        public static Task<Text> JoinGroupCallAsync(
            this Client client, int groupCallId = default, MessageSender participantId = default, int audioSourceId = default, string payload = default, bool isMuted = default, bool isMyVideoEnabled = default, string inviteHash = default)
        {
            return client.ExecuteAsync(new JoinGroupCall
            {
                GroupCallId = groupCallId, ParticipantId = participantId, AudioSourceId = audioSourceId, Payload = payload, IsMuted = isMuted, IsMyVideoEnabled = isMyVideoEnabled, InviteHash = inviteHash
            });
        }
    }
}