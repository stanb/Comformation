using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS::AppSync::GraphQLApi LogConfig
    /// The LogConfig property type specifies the logging configuration when writing GraphQL operations and tracing to
    /// Amazon CloudWatch for a AWS AppSync GraphQL API.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html
    /// </summary>
    public class LogConfig
    {

        /// <summary>
        /// CloudWatchLogsRoleArn
        /// The service role that AWS AppSync will assume to publish to Amazon CloudWatch Logs in your account.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogsRoleArn")]
        public Union<string, IntrinsicFunction> CloudWatchLogsRoleArn { get; set; }

        /// <summary>
        /// ExcludeVerboseContent
        /// Set to TRUE to exclude sections that contain information such as headers, context, and evaluated
        /// mapping templates, regardless of logging level.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludeVerboseContent")]
        public Union<bool, IntrinsicFunction> ExcludeVerboseContent { get; set; }

        /// <summary>
        /// FieldLogLevel
        /// The field logging level. Values can be NONE, ERROR, or ALL.
        /// NONE: No field-level logs are captured. ERROR: Logs the following information only for the fields
        /// that are in error: The error section in the server response. Field-level errors. The generated
        /// request/response functions that got resolved for error fields. ALL: The following information is
        /// logged for all fields in the query: Field-level tracing information. The generated request/response
        /// functions that got resolved for each field.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldLogLevel")]
        public Union<string, IntrinsicFunction> FieldLogLevel { get; set; }

    }
}
