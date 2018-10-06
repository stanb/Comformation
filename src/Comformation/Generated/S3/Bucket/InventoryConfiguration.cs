using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket InventoryConfiguration
    /// The InventoryConfiguration property type specifies the inventory configuration for an Amazon S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html
    /// </summary>
    public class InventoryConfiguration
    {

        /// <summary>
        /// Destination
        /// Information about where to publish the inventory results.
        /// Required: Yes
        /// Type: Amazon S3 Bucket Destination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public Destination Destination { get; set; }

        /// <summary>
        /// Enabled
        /// Specifies whether the inventory is enabled or disabled. If set to True, an inventory list is
        /// generated. If set to False, no inventory list is generated.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// Id
        /// The ID that identifies the inventory configuration.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// IncludedObjectVersions
        /// Object versions to include in the inventory list. If set to All, the list includes all the object
        /// versions, which adds the version related fields VersionId, IsLatest, and DeleteMarker to the list.
        /// If set to Current, the list does not contain these version related fields.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludedObjectVersions")]
        public Union<string, IntrinsicFunction> IncludedObjectVersions { get; set; }

        /// <summary>
        /// OptionalFields
        /// The optional fields that are included in the inventory results.
        /// Required: No
        /// Type: StringList
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OptionalFields")]
        public List<Union<string, IntrinsicFunction>> OptionalFields { get; set; }

        /// <summary>
        /// Prefix
        /// The prefix that is prepended to all inventory results.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// ScheduleFrequency
        /// The frequency of inventory results generation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleFrequency")]
        public Union<string, IntrinsicFunction> ScheduleFrequency { get; set; }

    }
}
