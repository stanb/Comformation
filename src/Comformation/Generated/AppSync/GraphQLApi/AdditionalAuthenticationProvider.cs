using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS::AppSync::GraphQLApi AdditionalAuthenticationProvider
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-additionalauthenticationprovider.html
    /// </summary>
    public class AdditionalAuthenticationProvider
    {

        /// <summary>
        /// OpenIDConnectConfig
        /// The OpenID Connect configuration.
        /// Required: No
        /// Type: OpenIDConnectConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OpenIDConnectConfig")]
        public OpenIDConnectConfig OpenIDConnectConfig { get; set; }

        /// <summary>
        /// LambdaAuthorizerConfig
        /// Configuration for AWS Lambda function authorization.
        /// Required: No
        /// Type: LambdaAuthorizerConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaAuthorizerConfig")]
        public LambdaAuthorizerConfig LambdaAuthorizerConfig { get; set; }

        /// <summary>
        /// UserPoolConfig
        /// The Amazon Cognito user pool configuration.
        /// Required: No
        /// Type: CognitoUserPoolConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserPoolConfig")]
        public CognitoUserPoolConfig UserPoolConfig { get; set; }

        /// <summary>
        /// AuthenticationType
        /// The authentication type for API key, AWS Identity and Access Management, OIDC, Amazon Cognito user
        /// pools, or AWS Lambda.
        /// Valid Values: API_KEY | AWS_IAM | OPENID_CONNECT | AMAZON_COGNITO_USER_POOLS | AWS_LAMBDA
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthenticationType")]
        public Union<string, IntrinsicFunction> AuthenticationType { get; set; }

    }
}
