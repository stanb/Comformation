using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application MonitoringConfiguration
    /// Describes configuration parameters for Amazon CloudWatch logging for a Java-based Kinesis Data Analytics
    /// application. For more information about CloudWatch logging, see Monitoring.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-monitoringconfiguration.html
    /// </summary>
    public class MonitoringConfiguration
    {

        /// <summary>
        /// ConfigurationType
        /// Describes whether to use the default CloudWatch logging configuration for an application.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: CUSTOM | DEFAULT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfigurationType")]
        public Union<string, IntrinsicFunction> ConfigurationType { get; set; }

        /// <summary>
        /// MetricsLevel
        /// Describes the granularity of the CloudWatch Logs for an application.
        /// Required: No
        /// Type: String
        /// Allowed Values: APPLICATION | OPERATOR | PARALLELISM | TASK
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MetricsLevel")]
        public Union<string, IntrinsicFunction> MetricsLevel { get; set; }

        /// <summary>
        /// LogLevel
        /// Describes the verbosity of the CloudWatch Logs for an application.
        /// Required: No
        /// Type: String
        /// Allowed Values: DEBUG | ERROR | INFO | WARN
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogLevel")]
        public Union<string, IntrinsicFunction> LogLevel { get; set; }

    }
}
