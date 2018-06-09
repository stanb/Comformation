using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule ElasticsearchAction
    /// Elasticsearch is a property of the Actions property that describes an action that writes data to an
    /// Elasticsearch domain.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html
    /// </summary>
    public class ElasticsearchAction
    {

        /// <summary>
        /// Endpoint
        /// The endpoint of your Elasticsearch domain.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

        /// <summary>
        /// Id
        /// A unique identifier for the stored data.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Index
        /// The Elasticsearch index where the data is stored.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Index")]
        public Union<string, IntrinsicFunction> Index { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to Elasticsearch.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Type
        /// The type of stored data.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
