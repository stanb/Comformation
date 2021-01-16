using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application ApplicationSnapshotConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationsnapshotconfiguration.html
    /// </summary>
    public class ApplicationSnapshotConfiguration
    {

        /// <summary>
        /// SnapshotsEnabled
        /// Describes whether snapshots are enabled for a Flink-based Kinesis Data Analytics application.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SnapshotsEnabled")]
        public Union<bool, IntrinsicFunction> SnapshotsEnabled { get; set; }

    }
}
