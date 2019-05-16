using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket NotificationFilter
    /// Specifies object key name filtering rules. For information about key name filtering, see Configuring Event
    /// Notifications in the Amazon Simple Storage Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter.html
    /// </summary>
    public class NotificationFilter
    {

        /// <summary>
        /// S3Key
        /// A container for object key name prefix and suffix filtering rules.
        /// Required: Yes
        /// Type: S3KeyFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Key")]
        public S3KeyFilter S3Key { get; set; }

    }
}
