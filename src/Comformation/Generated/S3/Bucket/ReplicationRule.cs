using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket ReplicationRule
    /// The ReplicationRule property type specifies which Amazon Simple Storage Service (Amazon S3) objects to
    /// replicate and where to store them. The Rules subproperty of the Amazon S3 Bucket ReplicationConfiguration
    /// property contains a list of ReplicationRule property types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html
    /// </summary>
    public class ReplicationRule
    {

        /// <summary>
        /// Destination
        /// Defines the destination where Amazon S3 stores replicated objects.
        /// Required: Yes
        /// Type: Amazon S3 Bucket ReplicationDestination
        /// </summary>
        [JsonProperty("Destination")]
        public Union<ReplicationDestination, IntrinsicFunction> Destination { get; set; }

        /// <summary>
        /// Id
        /// A unique identifier for the rule. If you don&#39;t specify a value, AWS CloudFormation generates a
        /// random ID.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Prefix
        /// An object prefix. This rule applies to all Amazon S3 objects with this prefix. To specify all
        /// objects in an S3 bucket, specify an empty string.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// SourceSelectionCriteria
        /// Specifies additional filters in identifying source objects that you want to replicate.
        /// Currently, Amazon S3 supports only the filter that you can specify for objects created with
        /// server-side encryption using an AWS KMS-managed key. That is, you can choose to enable or disable
        /// replication of these objects.
        /// Required: No
        /// Type: Amazon S3 Bucket SourceSelectionCriteria
        /// </summary>
        [JsonProperty("SourceSelectionCriteria")]
        public Union<SourceSelectionCriteria, IntrinsicFunction> SourceSelectionCriteria { get; set; }

        /// <summary>
        /// Status
        /// Whether the rule is enabled. For valid values, see the Status element of the PUT Bucket replication
        /// action in the Amazon Simple Storage Service API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
