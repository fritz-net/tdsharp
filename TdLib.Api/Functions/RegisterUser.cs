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
        /// Finishes user registration. Works only when the current authorization state is authorizationStateWaitRegistration
        /// </summary>
        public class RegisterUser : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "registerUser";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The first name of the user; 1-64 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("first_name")]
            public string FirstName { get; set; }

            /// <summary>
            /// The last name of the user; 0-64 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_name")]
            public string LastName { get; set; }

            /// <summary>
            /// Pass true to disable notification about the current user joining Telegram for other users that added them to contact list
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("disable_notification")]
            public bool DisableNotification { get; set; }
        }

        /// <summary>
        /// Finishes user registration. Works only when the current authorization state is authorizationStateWaitRegistration
        /// </summary>
        public static Task<Ok> RegisterUserAsync(
            this Client client, string firstName = default, string lastName = default, bool disableNotification = default)
        {
            return client.ExecuteAsync(new RegisterUser
            {
                FirstName = firstName, LastName = lastName, DisableNotification = disableNotification
            });
        }
    }
}