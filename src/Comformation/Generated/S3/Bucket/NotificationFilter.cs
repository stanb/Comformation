using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket NotificationFilter
    /// Filter is a property of the LambdaConfigurations, QueueConfigurations, and TopicConfigurations properties that
    /// describes the filtering rules that determine the Amazon Simple Storage Service (Amazon S3) objects for which
    /// to send notifications.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter.html
    /// </summary>
    public class NotificationFilter
    {

        /// <summary>
        /// S3Key
        /// Amazon S3 filtering rules that describe for which object key names to send notifications.
        /// Required: Yes
        /// Type: S3KeyFilter
        /// </summary>
        [JsonProperty("S3Key")]
        public S3KeyFilter S3Key { get; set; }

    }
}
