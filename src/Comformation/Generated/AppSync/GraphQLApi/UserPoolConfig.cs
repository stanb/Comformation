using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS AppSync GraphQLApi UserPoolConfig
    /// The UserPoolConfig property type specifies the optional authorization configuration for using Amazon Cognito
    /// User Pools with your GraphQL endpoint for an AWS AppSync GraphQL API.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html
    /// </summary>
    public class UserPoolConfig
    {

        /// <summary>
        /// AppIdClientRegex
        /// A regular expression for validating the incoming Amazon Cognito User Pool app client ID.
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
        /// The AWS region in which the user pool was created.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsRegion")]
        public Union<string, IntrinsicFunction> AwsRegion { get; set; }

        /// <summary>
        /// DefaultAction
        /// The action that you want your GraphQL API to take when a request that uses Amazon Cognito User Pool
        /// authentication doesn't match the Amazon Cognito User Pool configuration.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultAction")]
        public Union<string, IntrinsicFunction> DefaultAction { get; set; }

    }
}
