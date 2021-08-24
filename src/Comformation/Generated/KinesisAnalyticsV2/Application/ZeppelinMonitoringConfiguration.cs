using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application ZeppelinMonitoringConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-zeppelinmonitoringconfiguration.html
    /// </summary>
    public class ZeppelinMonitoringConfiguration
    {

        /// <summary>
        /// LogLevel
        /// The verbosity of the CloudWatch Logs for an application. You can set it to INFO, WARN, ERROR, or
        /// DEBUG.
        /// Required: No
        /// Type: String
        /// Allowed values: DEBUG | ERROR | INFO | WARN
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogLevel")]
        public Union<string, IntrinsicFunction> LogLevel { get; set; }

    }
}
