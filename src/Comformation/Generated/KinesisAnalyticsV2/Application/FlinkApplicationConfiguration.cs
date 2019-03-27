using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application FlinkApplicationConfiguration
    /// The FlinkApplicationConfiguration property type describes configuration parameters for a Java-based Kinesis
    /// Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-flinkapplicationconfiguration.html
    /// </summary>
    public class FlinkApplicationConfiguration
    {

        /// <summary>
        /// CheckpointConfiguration
        /// Describes an application&#39;s checkpointing configuration. Checkpointing is the process of persisting
        /// application state for fault tolerance.
        /// Required: No
        /// Type: CheckpointConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CheckpointConfiguration")]
        public CheckpointConfiguration CheckpointConfiguration { get; set; }

        /// <summary>
        /// ParallelismConfiguration
        /// Describes parameters for how an application executes multiple tasks simultaneously.
        /// Required: No
        /// Type: ParallelismConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ParallelismConfiguration")]
        public ParallelismConfiguration ParallelismConfiguration { get; set; }

        /// <summary>
        /// MonitoringConfiguration
        /// Describes configuration parameters for Amazon CloudWatch logging for an application.
        /// Required: No
        /// Type: MonitoringConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MonitoringConfiguration")]
        public MonitoringConfiguration MonitoringConfiguration { get; set; }

    }
}
