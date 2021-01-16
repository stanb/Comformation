using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster BrokerLogs
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-brokerlogs.html
    /// </summary>
    public class BrokerLogs
    {

        /// <summary>
        /// S3
        /// Details of the Amazon S3 destination for broker logs.
        /// Required: No
        /// Type: S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3 { get; set; }

        /// <summary>
        /// Firehose
        /// Details of the Kinesis Data Firehose delivery stream that is the destination for broker logs.
        /// Required: No
        /// Type: Firehose
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Firehose")]
        public Firehose Firehose { get; set; }

        /// <summary>
        /// CloudWatchLogs
        /// Details of the CloudWatch Logs destination for broker logs.
        /// Required: No
        /// Type: CloudWatchLogs
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogs")]
        public CloudWatchLogs CloudWatchLogs { get; set; }

    }
}
