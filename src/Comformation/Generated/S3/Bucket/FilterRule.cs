using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket FilterRule
    /// Rules is a property of the S3KeyFilter property that describes the Amazon Simple Storage Service (Amazon S3)
    /// object key name to filter on and whether to filter on the suffix or prefix of the key name.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter-s3key-rules.html
    /// </summary>
    public class FilterRule
    {

        /// <summary>
        /// Name
        /// Whether the filter matches the prefix or suffix of object key names. For valid values, see the Name
        /// request element of the PUT Bucket notification action in the Amazon Simple Storage Service API
        /// Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value that the filter searches for in object key names.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
