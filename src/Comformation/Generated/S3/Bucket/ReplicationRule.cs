using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ReplicationRule
    /// Specifies which Amazon S3 objects to replicate and where to store the replicas.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html
    /// </summary>
    public class ReplicationRule
    {

        /// <summary>
        /// Destination
        /// A container for information about the replication destination.
        /// Required: Yes
        /// Type: ReplicationDestination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public ReplicationDestination Destination { get; set; }

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
        /// An object keyname prefix that identifies the object or objects to which the rule applies. The
        /// maximum prefix length is 1,024 characters. To include all objects in a bucket, specify an empty
        /// string.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// SourceSelectionCriteria
        /// A container that describes additional filters for identifying the source objects that you want to
        /// replicate. You can choose to enable or disable the replication of these objects. Currently, Amazon
        /// S3 supports only the filter that you can specify for objects created with server-side encryption
        /// using an AWS KMS-Managed Key (SSE-KMS).
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
        /// Allowed Values: Disabled | Enabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
