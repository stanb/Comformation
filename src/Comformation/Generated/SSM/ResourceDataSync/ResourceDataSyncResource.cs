using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.ResourceDataSync
{
    /// <summary>
    /// AWS::SSM::ResourceDataSync
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html
    /// </summary>
    public class ResourceDataSyncResource : ResourceBase
    {
        public class ResourceDataSyncProperties
        {
            /// <summary>
            /// S3Destination
            /// Configuration information for the target S3 bucket.
            /// Required: No
            /// Type: S3Destination
            /// Update requires: Replacement
            /// </summary>
            public S3Destination S3Destination { get; set; }

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
            /// SyncSource
            /// Information about the source where the data was synchronized.
            /// Required: No
            /// Type: SyncSource
            /// Update requires: No interruption
            /// </summary>
            public SyncSource SyncSource { get; set; }

            /// <summary>
            /// BucketName
            /// The name of the S3 bucket where the aggregated data is stored.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BucketName { get; set; }

            /// <summary>
            /// BucketRegion
            /// The AWS Region with the S3 bucket targeted by the resource data sync.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BucketRegion { get; set; }

            /// <summary>
            /// SyncFormat
            /// A supported sync format. The following format is currently supported: JsonSerDe
            /// Required: No
            /// Type: String
            /// Allowed values: JsonSerDe
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SyncFormat { get; set; }

            /// <summary>
            /// SyncName
            /// A name for the resource data sync.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SyncName { get; set; }

            /// <summary>
            /// SyncType
            /// The type of resource data sync. If SyncType is SyncToDestination, then the resource data sync
            /// synchronizes data to an S3 bucket. If the SyncType is SyncFromSource then the resource data sync
            /// synchronizes data from AWS Organizations or from multiple AWS Regions.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SyncType { get; set; }

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

    public static class ResourceDataSyncAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SyncName = new ResourceAttribute<Union<string, IntrinsicFunction>>("SyncName");
    }
}
