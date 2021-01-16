using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint KafkaSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-kafkasettings.html
    /// </summary>
    public class KafkaSettings
    {

        /// <summary>
        /// Broker
        /// The broker location and port of the Kafka broker that hosts your Kafka instance. Specify the broker
        /// in the form broker-hostname-or-ip:port . For example, &quot;ec2-12-345-678-901. compute-1. amazonaws.
        /// com:2345&quot;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Broker")]
        public Union<string, IntrinsicFunction> Broker { get; set; }

        /// <summary>
        /// Topic
        /// The topic to which you migrate the data. If you don&#39;t specify a topic, AWS DMS specifies
        /// &quot;kafka-default-topic&quot; as the migration topic.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Topic")]
        public Union<string, IntrinsicFunction> Topic { get; set; }

    }
}
