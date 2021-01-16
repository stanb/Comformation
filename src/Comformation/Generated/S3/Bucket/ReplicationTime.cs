using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ReplicationTime
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationtime.html
    /// </summary>
    public class ReplicationTime
    {

        /// <summary>
        /// Status
        /// Specifies whether the replication time is enabled.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Disabled | Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// Time
        /// A container specifying the time by which replication should be complete for all objects and
        /// operations on objects.
        /// Required: Yes
        /// Type: ReplicationTimeValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Time")]
        public ReplicationTimeValue Time { get; set; }

    }
}
