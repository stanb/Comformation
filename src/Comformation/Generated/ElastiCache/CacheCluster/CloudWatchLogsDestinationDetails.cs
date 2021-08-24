using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.CacheCluster
{
    /// <summary>
    /// AWS::ElastiCache::CacheCluster CloudWatchLogsDestinationDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-cloudwatchlogsdestinationdetails.html
    /// </summary>
    public class CloudWatchLogsDestinationDetails
    {

        /// <summary>
        /// LogGroup
        /// The name of the CloudWatch Logs log group.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogGroup")]
        public Union<string, IntrinsicFunction> LogGroup { get; set; }

    }
}
