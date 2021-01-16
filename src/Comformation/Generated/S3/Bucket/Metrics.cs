using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket Metrics
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metrics.html
    /// </summary>
    public class Metrics
    {

        /// <summary>
        /// EventThreshold
        /// A container specifying the time threshold for emitting the s3:Replication:OperationMissedThreshold
        /// event.
        /// Required: No
        /// Type: ReplicationTimeValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EventThreshold")]
        public ReplicationTimeValue EventThreshold { get; set; }

        /// <summary>
        /// Status
        /// Specifies whether the replication metrics are enabled.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Disabled | Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
