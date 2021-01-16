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
        /// A JSON blob that provides configuration to use for logging DagProcessingLogs.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DagProcessingLogs")]
        public ModuleLoggingConfiguration DagProcessingLogs { get; set; }

        /// <summary>
        /// SchedulerLogs
        /// A JSON blob that provides configuration to use for logging SchedulerLogs.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SchedulerLogs")]
        public ModuleLoggingConfiguration SchedulerLogs { get; set; }

        /// <summary>
        /// WebserverLogs
        /// A JSON blob that provides configuration to use for logging WebserverLogs.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WebserverLogs")]
        public ModuleLoggingConfiguration WebserverLogs { get; set; }

        /// <summary>
        /// WorkerLogs
        /// A JSON blob that provides configuration to use for logging WorkerLogs.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WorkerLogs")]
        public ModuleLoggingConfiguration WorkerLogs { get; set; }

        /// <summary>
        /// TaskLogs
        /// A JSON blob that provides configuration to use for logging TaskLogs.
        /// Required: No
        /// Type: ModuleLoggingConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskLogs")]
        public ModuleLoggingConfiguration TaskLogs { get; set; }

    }
}
