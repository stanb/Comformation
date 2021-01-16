using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ReplicationRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html
    /// </summary>
    public class ReplicationRule
    {

        /// <summary>
        /// DeleteMarkerReplication
        /// Specifies whether Amazon S3 replicates delete markers. If you specify a Filter in your replication
        /// configuration, you must also include a DeleteMarkerReplication element. If your Filter includes a
        /// Tag element, the DeleteMarkerReplication Status must be set to Disabled, because Amazon S3 does not
        /// support replicating delete markers for tag-based rules. For an example configuration, see Basic Rule
        /// Configuration.
        /// For more information about delete marker replication, see Basic Rule Configuration.
        /// Note If you are using an earlier version of the replication configuration, Amazon S3 handles
        /// replication of delete markers differently. For more information, see Backward Compatibility.
        /// Required: No
        /// Type: DeleteMarkerReplication
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteMarkerReplication")]
        public DeleteMarkerReplication DeleteMarkerReplication { get; set; }

        /// <summary>
        /// Destination
        /// A container for information about the replication destination and its configurations including
        /// enabling the S3 Replication Time Control (S3 RTC).
        /// Required: Yes
        /// Type: ReplicationDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public ReplicationDestination Destination { get; set; }

        /// <summary>
        /// Filter
        /// A filter that identifies the subset of objects to which the replication rule applies. A Filter must
        /// specify exactly one Prefix, TagFilter, or an And child element.
        /// Required: No
        /// Type: ReplicationRuleFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Filter")]
        public ReplicationRuleFilter Filter { get; set; }

        /// <summary>
        /// Id
        /// A unique identifier for the rule. The maximum value is 255 characters. If you don&#39;t specify a value,
        /// AWS CloudFormation generates a random ID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Prefix
        /// An object key name prefix that identifies the object or objects to which the rule applies. The
        /// maximum prefix length is 1,024 characters. To include all objects in a bucket, specify an empty
        /// string.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// Priority
        /// The priority indicates which rule has precedence whenever two or more replication rules conflict.
        /// Amazon S3 will attempt to replicate objects according to all replication rules. However, if there
        /// are two or more rules with the same destination bucket, then objects will be replicated according to
        /// the rule with the highest priority. The higher the number, the higher the priority.
        /// For more information, see Replication in the Amazon Simple Storage Service Developer Guide.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// SourceSelectionCriteria
        /// A container that describes additional filters for identifying the source objects that you want to
        /// replicate. You can choose to enable or disable the replication of these objects.
        /// Required: No
        /// Type: SourceSelectionCriteria
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceSelectionCriteria")]
        public SourceSelectionCriteria SourceSelectionCriteria { get; set; }

        /// <summary>
        /// Status
        /// Specifies whether the rule is enabled.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Disabled | Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
