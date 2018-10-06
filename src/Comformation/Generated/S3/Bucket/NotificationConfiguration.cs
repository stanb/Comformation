using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket NotificationConfiguration
    /// Describes the notification configuration for an AWS::S3::Bucket resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig.html
    /// </summary>
    public class NotificationConfiguration
    {

        /// <summary>
        /// LambdaConfigurations
        /// The AWS Lambda functions to invoke and the events for which to invoke the functions.
        /// Required: No
        /// Type: Amazon S3 Bucket LambdaConfiguration
        /// </summary>
        [JsonProperty("LambdaConfigurations")]
        public List<LambdaConfiguration> LambdaConfigurations { get; set; }

        /// <summary>
        /// QueueConfigurations
        /// The Amazon Simple Queue Service queues to publish messages to and the events for which to publish
        /// messages.
        /// Required: No
        /// Type: Amazon S3 Bucket QueueConfiguration
        /// </summary>
        [JsonProperty("QueueConfigurations")]
        public List<QueueConfiguration> QueueConfigurations { get; set; }

        /// <summary>
        /// TopicConfigurations
        /// The topic to which notifications are sent and the events for which notification are generated.
        /// Required: No
        /// Type: Amazon S3 Bucket TopicConfiguration
        /// </summary>
        [JsonProperty("TopicConfigurations")]
        public List<TopicConfiguration> TopicConfigurations { get; set; }

    }
}
