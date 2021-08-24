using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS::AppSync::GraphQLApi LambdaAuthorizerConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html
    /// </summary>
    public class LambdaAuthorizerConfig
    {

        /// <summary>
        /// IdentityValidationExpression
        /// A regular expression for validation of tokens before the Lambda function is called.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IdentityValidationExpression")]
        public Union<string, IntrinsicFunction> IdentityValidationExpression { get; set; }

        /// <summary>
        /// AuthorizerUri
        /// The ARN of the Lambda function to be called for authorization. This may be a standard Lambda ARN, a
        /// version ARN (. . . /v3) or alias ARN.
        /// Note: This Lambda function must have the following resource-based policy assigned to it. When
        /// configuring Lambda authorizers in the console, this is done for you. To do so with the AWS CLI, run
        /// the following:
        /// aws lambda add-permission --function-name
        /// &quot;arn:aws:lambda:us-east-2:111122223333:function:my-function&quot; --statement-id &quot;appsync&quot; --principal
        /// appsync. amazonaws. com --action lambda:InvokeFunction
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthorizerUri")]
        public Union<string, IntrinsicFunction> AuthorizerUri { get; set; }

        /// <summary>
        /// AuthorizerResultTtlInSeconds
        /// The number of seconds a response should be cached for. The default is 5 minutes (300 seconds). The
        /// Lambda function can override this by returning a ttlOverride key in its response. A value of 0
        /// disables caching of responses.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthorizerResultTtlInSeconds")]
        public Union<double, IntrinsicFunction> AuthorizerResultTtlInSeconds { get; set; }

    }
}
