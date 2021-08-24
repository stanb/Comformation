using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.CacheCluster
{
    /// <summary>
    /// AWS::ElastiCache::CacheCluster KinesisFirehoseDestinationDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-kinesisfirehosedestinationdetails.html
    /// </summary>
    public class KinesisFirehoseDestinationDetails
    {

        /// <summary>
        /// DeliveryStream
        /// The name of the Kinesis Data Firehose delivery stream.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeliveryStream")]
        public Union<string, IntrinsicFunction> DeliveryStream { get; set; }

    }
}
