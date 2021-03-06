using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS::AppSync::GraphQLApi CognitoUserPoolConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-cognitouserpoolconfig.html
    /// </summary>
    public class CognitoUserPoolConfig
    {

        /// <summary>
        /// AppIdClientRegex
        /// A regular expression for validating the incoming Amazon Cognito user pool app client ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppIdClientRegex")]
        public Union<string, IntrinsicFunction> AppIdClientRegex { get; set; }

        /// <summary>
        /// UserPoolId
        /// The user pool ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserPoolId")]
        public Union<string, IntrinsicFunction> UserPoolId { get; set; }

        /// <summary>
        /// AwsRegion
        /// The AWS Region in which the user pool was created.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsRegion")]
        public Union<string, IntrinsicFunction> AwsRegion { get; set; }

    }
}
