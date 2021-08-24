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
        /// Indicates whether to enable the Apache Airflow log type (e. g. DagProcessingLogs) in CloudWatch
        /// Logs.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// LogLevel
        /// Defines the Apache Airflow logs to send for the log type (e. g. DagProcessingLogs) to CloudWatch
        /// Logs. Valid values: CRITICAL, ERROR, WARNING, INFO.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogLevel")]
        public Union<string, IntrinsicFunction> LogLevel { get; set; }

        /// <summary>
        /// CloudWatchLogGroupArn
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogGroupArn")]
        public Union<string, IntrinsicFunction> CloudWatchLogGroupArn { get; set; }

    }
}
