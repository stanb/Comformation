using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS::AppSync::GraphQLApi OpenIDConnectConfig
    /// The OpenIDConnectConfig property type specifies the optional authorization configuration for using an OpenID
    /// Connect compliant service with your GraphQL endpoint for an AWS AppSync GraphQL API.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-openidconnectconfig.html
    /// </summary>
    public class OpenIDConnectConfig
    {

        /// <summary>
        /// Issuer
        /// The issuer for the OpenID Connect configuration. The issuer returned by discovery must exactly match
        /// the value of iss in the ID token.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Issuer")]
        public Union<string, IntrinsicFunction> Issuer { get; set; }

        /// <summary>
        /// ClientId
        /// The client identifier of the Relying party at the OpenID identity provider. This identifier is
        /// typically obtained when the Relying party is registered with the OpenID identity provider. You can
        /// specify a regular expression so the AWS AppSync can validate against multiple client identifiers at
        /// a time.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientId")]
        public Union<string, IntrinsicFunction> ClientId { get; set; }

        /// <summary>
        /// AuthTTL
        /// The number of milliseconds a token is valid after being authenticated.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthTTL")]
        public Union<double, IntrinsicFunction> AuthTTL { get; set; }

        /// <summary>
        /// IatTTL
        /// The number of milliseconds a token is valid after being issued to a user.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IatTTL")]
        public Union<double, IntrinsicFunction> IatTTL { get; set; }

    }
}
