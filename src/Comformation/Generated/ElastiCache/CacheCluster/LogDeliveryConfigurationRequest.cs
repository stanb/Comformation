using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElastiCache.CacheCluster
{
    /// <summary>
    /// AWS::ElastiCache::CacheCluster LogDeliveryConfigurationRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-logdeliveryconfigurationrequest.html
    /// </summary>
    public class LogDeliveryConfigurationRequest
    {

        /// <summary>
        /// DestinationDetails
        /// Configuration details of either a CloudWatch Logs destination or Kinesis Data Firehose destination.
        /// Required: No
        /// Type: DestinationDetails
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationDetails")]
        public DestinationDetails DestinationDetails { get; set; }

        /// <summary>
        /// DestinationType
        /// Specify either CloudWatch Logs or Kinesis Data Firehose as the destination type. Valid values are
        /// either cloudwatch-logs or kinesis-firehose.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationType")]
        public Union<string, IntrinsicFunction> DestinationType { get; set; }

        /// <summary>
        /// LogFormat
        /// Valid values are either json or text.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogFormat")]
        public Union<string, IntrinsicFunction> LogFormat { get; set; }

        /// <summary>
        /// LogType
        /// Valid value is slow-log. Refers to slow-log.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogType")]
        public Union<string, IntrinsicFunction> LogType { get; set; }

    }
}
