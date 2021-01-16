using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket S3KeyFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter-s3key.html
    /// </summary>
    public class S3KeyFilter
    {

        /// <summary>
        /// Rules
        /// A list of containers for the key-value pair that defines the criteria for the filter rule.
        /// Required: Yes
        /// Type: List of FilterRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public List<FilterRule> Rules { get; set; }

    }
}
