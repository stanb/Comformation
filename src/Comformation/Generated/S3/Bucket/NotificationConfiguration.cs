using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket NotificationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig.html
    /// </summary>
    public class NotificationConfiguration
    {

        /// <summary>
        /// LambdaConfigurations
        /// Describes the AWS Lambda functions to invoke and the events for which to invoke them.
        /// Required: No
        /// Type: List of LambdaConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaConfigurations")]
        public List<LambdaConfiguration> LambdaConfigurations { get; set; }

        /// <summary>
        /// QueueConfigurations
        /// The Amazon Simple Queue Service queues to publish messages to and the events for which to publish
        /// messages.
        /// Required: No
        /// Type: List of QueueConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueueConfigurations")]
        public List<QueueConfiguration> QueueConfigurations { get; set; }

        /// <summary>
        /// TopicConfigurations
        /// The topic to which notifications are sent and the events for which notifications are generated.
        /// Required: No
        /// Type: List of TopicConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicConfigurations")]
        public List<TopicConfiguration> TopicConfigurations { get; set; }

    }
}
