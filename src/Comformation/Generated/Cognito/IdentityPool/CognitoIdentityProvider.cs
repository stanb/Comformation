using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.IdentityPool
{
    /// <summary>
    /// Amazon Cognito IdentityPool CognitoIdentityProvider
    /// CognitoIdentityProvider is a property of the AWS::Cognito::IdentityPool resource that represents an Amazon
    /// Cognito user pool and its client ID.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitoidentityprovider.html
    /// </summary>
    public class CognitoIdentityProvider
    {

        /// <summary>
        /// ServerSideTokenCheck
        /// TRUE if server-side token validation is enabled for the identity provider’s token.
        /// Once you set ServerSideTokenCheck to TRUE for an identity pool, that identity pool will check with
        /// the integrated user pools to make sure that the user has not been globally signed out or deleted
        /// before the identity pool provides an OIDC token or AWS credentials for the user.
        /// If the user is signed out or deleted, the identity pool will return a 400 Not Authorized error.
        /// Type: Boolean
        /// Required: No
        /// </summary>
        [JsonProperty("ServerSideTokenCheck")]
        public Union<bool, IntrinsicFunction> ServerSideTokenCheck { get; set; }

        /// <summary>
        /// ProviderName
        /// The provider name for an Amazon Cognito user pool. For example, cognito-idp. us-east-2. amazonaws.
        /// com/us-east-2_123456789.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("ProviderName")]
        public Union<string, IntrinsicFunction> ProviderName { get; set; }

        /// <summary>
        /// ClientId
        /// The client ID for the Amazon Cognito user pool.
        /// Type: String
        /// Required: No
        /// </summary>
        [JsonProperty("ClientId")]
        public Union<string, IntrinsicFunction> ClientId { get; set; }

    }
}
