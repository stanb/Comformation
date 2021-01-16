using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationInsights.Application
{
    /// <summary>
    /// AWS::ApplicationInsights::Application Log
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationinsights-application-log.html
    /// </summary>
    public class Log
    {

        /// <summary>
        /// LogGroupName
        /// The CloudWatch log group name to be associated with the monitored log.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogGroupName")]
        public Union<string, IntrinsicFunction> LogGroupName { get; set; }

        /// <summary>
        /// LogPath
        /// The path of the logs to be monitored. The log path must be an absolute Windows or Linux system file
        /// path. For more information, see CloudWatch Agent Configuration File: Logs Section.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogPath")]
        public Union<string, IntrinsicFunction> LogPath { get; set; }

        /// <summary>
        /// LogType
        /// The log type decides the log patterns against which Application Insights analyzes the log. The log
        /// type is selected from the following: SQL_SERVER, IIS, APPLICATION, and DEFAULT.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogType")]
        public Union<string, IntrinsicFunction> LogType { get; set; }

        /// <summary>
        /// Encoding
        /// The type of encoding of the logs to be monitored. The specified encoding should be included in the
        /// list of CloudWatch agent supported encodings. If not provided, CloudWatch Application Insights uses
        /// the default encoding type for the log type:
        /// APPLICATION/DEFAULT: utf-8 encoding SQL_SERVER: utf-16 encoding IIS: ascii encoding
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Encoding")]
        public Union<string, IntrinsicFunction> Encoding { get; set; }

        /// <summary>
        /// PatternSet
        /// The log pattern set.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PatternSet")]
        public Union<string, IntrinsicFunction> PatternSet { get; set; }

    }
}
