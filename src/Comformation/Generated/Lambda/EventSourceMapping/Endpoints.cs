using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventSourceMapping
{
    /// <summary>
    /// AWS::Lambda::EventSourceMapping Endpoints
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-endpoints.html
    /// </summary>
    public class Endpoints
    {

        /// <summary>
        /// KafkaBootstrapServers
        /// The list of bootstrap servers for your Kafka brokers in the following format:
        /// &quot;KafkaBootstrapServers&quot;: [&quot;abc. xyz. com:xxxx&quot;,&quot;abc2. xyz. com:xxxx&quot;].
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KafkaBootstrapServers")]
        public List<Union<string, IntrinsicFunction>> KafkaBootstrapServers { get; set; }

    }
}
