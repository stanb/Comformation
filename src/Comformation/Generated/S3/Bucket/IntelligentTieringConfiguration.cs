using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket IntelligentTieringConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-intelligenttieringconfiguration.html
    /// </summary>
    public class IntelligentTieringConfiguration
    {

        /// <summary>
        /// Id
        /// The ID used to identify the S3 Intelligent-Tiering configuration.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Prefix
        /// An object key name prefix that identifies the subset of objects to which the rule applies.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// Status
        /// Specifies the status of the configuration.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Disabled | Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// TagFilters
        /// A container for a key-value pair.
        /// Required: No
        /// Type: List of TagFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TagFilters")]
        public List<TagFilter> TagFilters { get; set; }

        /// <summary>
        /// Tierings
        /// Specifies the S3 Intelligent-Tiering storage class tier of the configuration.
        /// Required: Yes
        /// Type: List of Tiering
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Tierings")]
        public List<Tiering> Tierings { get; set; }

    }
}
