using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application CheckpointConfiguration
    /// The CheckpointConfiguration property type specifies an application&#39;s checkpointing configuration.
    /// Checkpointing is the process of persisting application state for fault tolerance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html
    /// </summary>
    public class CheckpointConfiguration
    {

        /// <summary>
        /// ConfigurationType
        /// Describes whether the application uses Amazon Kinesis Data Analytics&#39; default checkpointing
        /// behavior.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfigurationType")]
        public Union<string, IntrinsicFunction> ConfigurationType { get; set; }

        /// <summary>
        /// CheckpointInterval
        /// Describes the interval in milliseconds between checkpoint operations.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CheckpointInterval")]
        public Union<int, IntrinsicFunction> CheckpointInterval { get; set; }

        /// <summary>
        /// MinPauseBetweenCheckpoints
        /// Describes the minimum time in milliseconds after a checkpoint operation completes that a new
        /// checkpoint operation can start. If a checkpoint operation takes longer than the CheckpointInterval,
        /// the application otherwise performs continual checkpoint operations.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinPauseBetweenCheckpoints")]
        public Union<int, IntrinsicFunction> MinPauseBetweenCheckpoints { get; set; }

        /// <summary>
        /// CheckpointingEnabled
        /// Describes whether checkpointing is enabled for a Java-based Kinesis Data Analytics application.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CheckpointingEnabled")]
        public Union<bool, IntrinsicFunction> CheckpointingEnabled { get; set; }

    }
}
