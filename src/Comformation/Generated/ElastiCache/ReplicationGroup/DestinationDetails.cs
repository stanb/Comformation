using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.ReplicationGroup
{
    /// <summary>
    /// AWS::ElastiCache::ReplicationGroup DestinationDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-destinationdetails.html
    /// </summary>
    public class DestinationDetails
    {

        /// <summary>
        /// CloudWatchLogsDetails
        /// The configuration details of the CloudWatch Logs destination.
        /// Required: No
        /// Type: CloudWatchLogsDestinationDetails
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogsDetails")]
        public CloudWatchLogsDestinationDetails CloudWatchLogsDetails { get; set; }

        /// <summary>
        /// KinesisFirehoseDetails
        /// The configuration details of the Kinesis Data Firehose destination.
        /// Required: No
        /// Type: KinesisFirehoseDestinationDetails
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KinesisFirehoseDetails")]
        public KinesisFirehoseDestinationDetails KinesisFirehoseDetails { get; set; }

    }
}
