using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application CheckpointConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-checkpointconfiguration.html
    /// </summary>
    public class CheckpointConfiguration
    {

        /// <summary>
        /// ConfigurationType
        /// Describes whether the application uses Kinesis Data Analytics&#39; default checkpointing behavior. You
        /// must set this property to CUSTOM in order to set the CheckpointingEnabled, CheckpointInterval, or
        /// MinPauseBetweenCheckpoints parameters.
        /// Note If this value is set to DEFAULT, the application will use the following values, even if they
        /// are set to other values using APIs or application code: CheckpointingEnabled: true
        /// CheckpointInterval: 60000 MinPauseBetweenCheckpoints: 5000
        /// Required: Yes
        /// Type: String
        /// Allowed values: CUSTOM | DEFAULT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfigurationType")]
        public Union<string, IntrinsicFunction> ConfigurationType { get; set; }

        /// <summary>
        /// CheckpointInterval
        /// Describes the interval in milliseconds between checkpoint operations.
        /// Note If CheckpointConfiguration. ConfigurationType is DEFAULT, the application will use a
        /// CheckpointInterval value of 60000, even if this value is set to another value using this API or in
        /// application code.
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
        /// the application otherwise performs continual checkpoint operations. For more information, see Tuning
        /// Checkpointing in the Apache Flink Documentation.
        /// Note If CheckpointConfiguration. ConfigurationType is DEFAULT, the application will use a
        /// MinPauseBetweenCheckpoints value of 5000, even if this value is set using this API or in application
        /// code.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinPauseBetweenCheckpoints")]
        public Union<int, IntrinsicFunction> MinPauseBetweenCheckpoints { get; set; }

        /// <summary>
        /// CheckpointingEnabled
        /// Describes whether checkpointing is enabled for a Flink-based Kinesis Data Analytics application.
        /// Note If CheckpointConfiguration. ConfigurationType is DEFAULT, the application will use a
        /// CheckpointingEnabled value of true, even if this value is set to another value using this API or in
        /// application code.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CheckpointingEnabled")]
        public Union<bool, IntrinsicFunction> CheckpointingEnabled { get; set; }

    }
}
