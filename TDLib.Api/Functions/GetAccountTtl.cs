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
        /// Returns the period of inactivity after which the account of the current user will automatically be deleted
        /// </summary>
        public class GetAccountTtl : Function<AccountTtl>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getAccountTtl";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns the period of inactivity after which the account of the current user will automatically be deleted
        /// </summary>
        public static Task<AccountTtl> GetAccountTtlAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetAccountTtl
            {
                
            });
        }
    }
}