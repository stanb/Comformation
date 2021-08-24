using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MWAA.Environment
{
    /// <summary>
    /// AWS::MWAA::Environment LoggingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mwaa-environment-loggingconfiguration.html
    /// </summary>
    public class LoggingConfiguration
    {

        /// <summary>
        /// DagProcessingLogs
        /// Defines the processing logs sent to CloudWatch Logs and the logging level to send.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DagProcessingLogs")]
        public ModuleLoggingConfiguration DagProcessingLogs { get; set; }

        /// <summary>
        /// SchedulerLogs
        /// Defines the scheduler logs sent to CloudWatch Logs and the logging level to send.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchedulerLogs")]
        public ModuleLoggingConfiguration SchedulerLogs { get; set; }

        /// <summary>
        /// WebserverLogs
        /// Defines the web server logs sent to CloudWatch Logs and the logging level to send.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WebserverLogs")]
        public ModuleLoggingConfiguration WebserverLogs { get; set; }

        /// <summary>
        /// WorkerLogs
        /// Defines the worker logs sent to CloudWatch Logs and the logging level to send.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WorkerLogs")]
        public ModuleLoggingConfiguration WorkerLogs { get; set; }

        /// <summary>
        /// TaskLogs
        /// Defines the task logs sent to CloudWatch Logs and the logging level to send.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskLogs")]
        public ModuleLoggingConfiguration TaskLogs { get; set; }

    }
}
