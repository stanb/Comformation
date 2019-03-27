using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket ReplicationDestination
    /// Destination is a property of the ReplicationRule property that specifies which Amazon Simple Storage Service
    /// (Amazon S3) bucket to store replicated objects and their storage class.
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
        /// Conditional: If you specify the AccessControlTranslation property, the Account property is required.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Account")]
        public Union<string, IntrinsicFunction> Account { get; set; }

        /// <summary>
        /// Bucket
        /// The Amazon resource name (ARN) of an S3 bucket where Amazon S3 stores replicated objects. This
        /// destination bucket must be in a different region than your source bucket.
        /// If you have multiple rules in your replication configuration, specify the same destination bucket
        /// for all of the rules.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// EncryptionConfiguration
        /// Specifies encryption-related information.
        /// Required: No
        /// Type: EncryptionConfiguration
        /// </summary>
        [JsonProperty("EncryptionConfiguration")]
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// StorageClass
        /// The storage class to use when replicating objects, such as standard or reduced redundancy. By
        /// default, Amazon S3 uses the storage class of the source object to create object replica. For valid
        /// values, see the StorageClass element of the PUT Bucket replication action in the Amazon Simple
        /// Storage Service API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("StorageClass")]
        public Union<string, IntrinsicFunction> StorageClass { get; set; }

    }
}
