using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS AppSync GraphQLApi LogConfig
    /// The LogConfig property type specifies the logging configuration when writing GraphQL operations and tracing to
    /// Amazon Cloudwatch for a AWS AppSync GraphQL API.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html
    /// </summary>
    public class LogConfig
    {

        /// <summary>
        /// CloudWatchLogsRoleArn
        /// The IAM role that will allow publishing CloudWatch logs into the customer's account.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogsRoleArn")]
        public Union<string, IntrinsicFunction> CloudWatchLogsRoleArn { get; set; }

        /// <summary>
        /// FieldLogLevel
        /// The desired level of logging.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldLogLevel")]
        public Union<string, IntrinsicFunction> FieldLogLevel { get; set; }

    }
}
