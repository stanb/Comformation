using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket S3KeyFilter
    /// S3Key is a property of the Amazon S3 Bucket NotificationFilter property that specifies the key names of Amazon
    /// Simple Storage Service (Amazon S3) objects for which to send notifications.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter-s3key.html
    /// </summary>
    public class S3KeyFilter
    {

        /// <summary>
        /// Rules
        /// The object key name to filter on and whether to filter on the suffix or prefix of the key name.
        /// Required: Yes
        /// Type: List of FilterRule
        /// </summary>
        [JsonProperty("Rules")]
        public List<FilterRule> Rules { get; set; }

    }
}
