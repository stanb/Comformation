using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS::DMS::Endpoint ElasticsearchSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-elasticsearchsettings.html
    /// </summary>
    public class ElasticsearchSettings
    {

        /// <summary>
        /// EndpointUri
        /// The endpoint for the Elasticsearch cluster. AWS DMS uses HTTPS if a transport protocol (http/https)
        /// is not specified.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EndpointUri")]
        public Union<string, IntrinsicFunction> EndpointUri { get; set; }

        /// <summary>
        /// FullLoadErrorPercentage
        /// The maximum percentage of records that can fail to be written before a full load operation stops.
        /// To avoid early failure, this counter is only effective after 1000 records are transferred.
        /// Elasticsearch also has the concept of error monitoring during the last 10 minutes of an Observation
        /// Window. If transfer of all records fail in the last 10 minutes, the full load operation stops.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FullLoadErrorPercentage")]
        public Union<int, IntrinsicFunction> FullLoadErrorPercentage { get; set; }

        /// <summary>
        /// ErrorRetryDuration
        /// The maximum number of seconds for which DMS retries failed API requests to the Elasticsearch
        /// cluster.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorRetryDuration")]
        public Union<int, IntrinsicFunction> ErrorRetryDuration { get; set; }

        /// <summary>
        /// ServiceAccessRoleArn
        /// The Amazon Resource Name (ARN) used by the service to access the IAM role. The role must allow the
        /// iam:PassRole action.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

    }
}
