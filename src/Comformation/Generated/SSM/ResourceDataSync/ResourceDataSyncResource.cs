using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.ResourceDataSync
{
    /// <summary>
    /// AWS::SSM::ResourceDataSync
    /// The AWS::SSM::ResourceDataSync resource creates or deletes a Resource Data Sync for AWS Systems Manager
    /// Inventory. You can use Resource Data Sync to send Inventory data collected from all of your Systems Manager
    /// managed instances to a single Amazon S3 bucket that you have already created in your account. Resource Data
    /// Sync then automatically updates the centralized data when new Inventory data is collected.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html
    /// </summary>
    public class ResourceDataSyncResource : ResourceBase
    {
        public class ResourceDataSyncProperties
        {
            /// <summary>
            /// KMSKeyArn
            /// The ARN of an encryption key for a destination in Amazon S3. You can use a KMS key to encrypt
            /// inventory data in Amazon S3. You must specify a key that exist in the same region as the destination
            /// Amazon S3 bucket.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: arn:. *
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KMSKeyArn { get; set; }

            /// <summary>
            /// BucketName
            /// The name of the Amazon S3 bucket where the aggregated data is stored.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BucketName { get; set; }

            /// <summary>
            /// BucketRegion
            /// The AWS Region with the Amazon S3 bucket targeted by the Resource Data Sync.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BucketRegion { get; set; }

            /// <summary>
            /// SyncFormat
            /// A supported sync format. The following format is currently supported: JsonSerDe
            /// Required: Yes
            /// Type: String
            /// Allowed Values: JsonSerDe
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SyncFormat { get; set; }

            /// <summary>
            /// SyncName
            /// A name for the Resource Data Sync.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SyncName { get; set; }

            /// <summary>
            /// BucketPrefix
            /// An Amazon S3 prefix for the bucket.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BucketPrefix { get; set; }

        }

        public string Type { get; } = "AWS::SSM::ResourceDataSync";

        public ResourceDataSyncProperties Properties { get; } = new ResourceDataSyncProperties();

    }
}
