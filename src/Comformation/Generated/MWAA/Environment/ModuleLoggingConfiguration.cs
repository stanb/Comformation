using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MWAA.Environment
{
    /// <summary>
    /// AWS::MWAA::Environment ModuleLoggingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-moduleloggingconfiguration.html
    /// </summary>
    public class ModuleLoggingConfiguration
    {

        /// <summary>
        /// Enabled
        /// Specifies whether to enable logging.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// LogLevel
        /// Defines the log level, which can be CRITICAL, ERROR, WARNING, or INFO.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogLevel")]
        public Union<string, IntrinsicFunction> LogLevel { get; set; }

        /// <summary>
        /// CloudWatchLogGroupArn
        /// Provides the ARN for the CloudWatch group where the logs will be published.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogGroupArn")]
        public Union<string, IntrinsicFunction> CloudWatchLogGroupArn { get; set; }

    }
}
