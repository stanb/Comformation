using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket FilterRule
    /// Specifies the Amazon S3 object key name to filter on and whether to filter on the suffix or prefix of the key
    /// name.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter-s3key-rules.html
    /// </summary>
    public class FilterRule
    {

        /// <summary>
        /// Name
        /// The object key name prefix or suffix identifying one or more objects to which the filtering rule
        /// applies. The maximum length is 1,024 characters. Overlapping prefixes and suffixes are not
        /// supported. For more information, see Configuring Event Notifications in the Amazon Simple Storage
        /// Service Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: prefix | suffix
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value that the filter searches for in object key names.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
