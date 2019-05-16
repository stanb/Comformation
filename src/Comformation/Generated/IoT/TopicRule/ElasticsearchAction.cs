using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule ElasticsearchAction
    /// Describes an action that writes data to an Amazon Elasticsearch Service domain.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html
    /// </summary>
    public class ElasticsearchAction
    {

        /// <summary>
        /// Endpoint
        /// The endpoint of your Elasticsearch domain.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

        /// <summary>
        /// Id
        /// The unique identifier for the document you are storing.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Index
        /// The Elasticsearch index where you want to store your data.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Index")]
        public Union<string, IntrinsicFunction> Index { get; set; }

        /// <summary>
        /// RoleArn
        /// The IAM role ARN that has access to Elasticsearch.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Type
        /// The type of document you are storing.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
