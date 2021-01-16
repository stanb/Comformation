using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// AWS::Elasticsearch::Domain LogPublishingOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-logpublishingoption.html
    /// </summary>
    public class LogPublishingOption
    {

        /// <summary>
        /// CloudWatchLogsLogGroupArn
        /// Specifies the CloudWatch log group to publish to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogsLogGroupArn")]
        public Union<string, IntrinsicFunction> CloudWatchLogsLogGroupArn { get; set; }

        /// <summary>
        /// Enabled
        /// If true, enables the publishing of logs to CloudWatch.
        /// Default: false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
