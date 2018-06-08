using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS AppSync DataSource ElasticsearchConfig
    /// The ElasticsearchConfig property type specifies the AwsRegion and Endpoints for an Amazon Elasticsearch
    /// Service domain in your account for an AWS AppSync data source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-elasticsearchconfig.html
    /// </summary>
    public class ElasticsearchConfig
    {

        /// <summary>
        /// AwsRegion
        /// The AWS region.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsRegion")]
        public Union<string, IntrinsicFunction> AwsRegion { get; set; }

        /// <summary>
        /// Endpoint
        /// The endpoint.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Endpoint")]
        public Union<string, IntrinsicFunction> Endpoint { get; set; }

    }
}
