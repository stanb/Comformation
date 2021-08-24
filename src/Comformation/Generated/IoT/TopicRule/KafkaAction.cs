using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule KafkaAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-kafkaaction.html
    /// </summary>
    public class KafkaAction
    {

        /// <summary>
        /// DestinationArn
        /// The ARN of Kafka action&#39;s VPC TopicRuleDestination.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationArn")]
        public Union<string, IntrinsicFunction> DestinationArn { get; set; }

        /// <summary>
        /// Topic
        /// The Kafka topic for messages to be sent to the Kafka broker.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Topic")]
        public Union<string, IntrinsicFunction> Topic { get; set; }

        /// <summary>
        /// Key
        /// The Kafka message key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Partition
        /// The Kafka message partition.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Partition")]
        public Union<string, IntrinsicFunction> Partition { get; set; }

        /// <summary>
        /// ClientProperties
        /// Properties of the Apache Kafka producer client.
        /// Required: Yes
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientProperties")]
        public Dictionary<string, Union<string, IntrinsicFunction>> ClientProperties { get; set; }

    }
}
