using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventSourceMapping
{
    /// <summary>
    /// AWS::Lambda::EventSourceMapping SelfManagedEventSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-selfmanagedeventsource.html
    /// </summary>
    public class SelfManagedEventSource
    {

        /// <summary>
        /// Endpoints
        /// The list of bootstrap servers for your Kafka brokers in the following format:
        /// &quot;KafkaBootstrapServers&quot;: [&quot;abc. xyz. com:xxxx&quot;,&quot;abc2. xyz. com:xxxx&quot;].
        /// Required: No
        /// Type: Endpoints
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Endpoints")]
        public Endpoints Endpoints { get; set; }

    }
}
