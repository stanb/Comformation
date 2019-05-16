using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ReplicationDestination
    /// Specifies which Amazon S3 bucket to store replicated objects in and their storage class.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules-destination.html
    /// </summary>
    public class ReplicationDestination
    {

        /// <summary>
        /// AccessControlTranslation
        /// Specify this only in a cross-account scenario (where source and destination bucket owners are not
        /// the same), and you want to change replica ownership to the AWS account that owns the destination
        /// bucket. If this is not specified in the replication configuration, the replicas are owned by same
        /// AWS account that owns the source object.
        /// Required: No
        /// Type: AccessControlTranslation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessControlTranslation")]
        public AccessControlTranslation AccessControlTranslation { get; set; }

        /// <summary>
        /// Account
        /// Destination bucket owner account ID. In a cross-account scenario, if you direct Amazon S3 to change
        /// replica ownership to the AWS account that owns the destination bucket by specifying the
        /// AccessControlTranslation property, this is the account ID of the destination bucket owner. For more
        /// information, see Cross-Region Replication Additional Configuration: Change Replica Owner in the
        /// Amazon Simple Storage Service Developer Guide.
        /// If you specify the AccessControlTranslation property, the Account property is required.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Account")]
        public Union<string, IntrinsicFunction> Account { get; set; }

        /// <summary>
        /// Bucket
        /// The Amazon Resource Name (ARN) of the bucket where you want Amazon S3 to store replicas of the
        /// object identified by the rule.
        /// A replication configuration can replicate objects to only one destination bucket. If there are
        /// multiple rules in your replication configuration, all rules must specify the same destination
        /// bucket.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// EncryptionConfiguration
        /// Specifies encryption-related information.
        /// Required: No
        /// Type: EncryptionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionConfiguration")]
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// StorageClass
        /// The storage class to use when replicating objects, such as standard or reduced redundancy. By
        /// default, Amazon S3 uses the storage class of the source object to create the object replica.
        /// For valid values, see the StorageClass element of the PUT Bucket replication action in the Amazon
        /// Simple Storage Service API Reference.
        /// Required: No
        /// Type: String
        /// Allowed Values: DEEP_ARCHIVE | GLACIER | INTELLIGENT_TIERING | ONEZONE_IA | REDUCED_REDUNDANCY |
        /// STANDARD | STANDARD_IA
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StorageClass")]
        public Union<string, IntrinsicFunction> StorageClass { get; set; }

    }
}
