using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket
    /// The AWS::S3::Bucket resource creates an Amazon Simple Storage Service (Amazon S3) bucket in the same AWS
    /// Region where you create the AWS CloudFormation stack.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html
    /// </summary>
    public class BucketResource : ResourceBase
    {
        public class BucketProperties
        {
            /// <summary>
            /// AccelerateConfiguration
            /// Configuration for the transfer acceleration state. For more information, see Amazon S3 Transfer
            /// Acceleration in the Amazon Simple Storage Service Developer Guide.
            /// Required: No
            /// Type: Amazon S3 Bucket AccelerateConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<AccelerateConfiguration, IntrinsicFunction> AccelerateConfiguration { get; set; }

            /// <summary>
            /// AccessControl
            /// A canned access control list (ACL) that grants predefined permissions to the bucket. For more
            /// information about canned ACLs, see Canned ACLs in the Amazon S3 documentation in the Amazon Simple
            /// Storage Service Developer Guide.
            /// Required: No
            /// Type: String
            /// Valid values: AuthenticatedRead | AwsExecRead | BucketOwnerRead | BucketOwnerFullControl |
            /// LogDeliveryWrite | Private | PublicRead | PublicReadWrite
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AccessControl { get; set; }

            /// <summary>
            /// AnalyticsConfigurations
            /// The configuration and any analyses for the analytics filter of an Amazon S3 bucket. Duplicates not
            /// allowed.
            /// Required: No
            /// Type: List of Amazon S3 Bucket AnalyticsConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<List<AnalyticsConfiguration>, IntrinsicFunction> AnalyticsConfigurations { get; set; }

            /// <summary>
            /// BucketEncryption
            /// Specifies default encryption for a bucket using server-side encryption with Amazon S3-managed keys
            /// SSE-S3 or AWS KMS-managed Keys (SSE-KMS) bucket. .
            /// Required: No
            /// Type: Amazon S3 Bucket BucketEncryption
            /// Update requires: No interruption
            /// </summary>
			public Union<BucketEncryption, IntrinsicFunction> BucketEncryption { get; set; }

            /// <summary>
            /// BucketName
            /// A name for the bucket. If you don't specify a name, AWS CloudFormation generates a unique physical
            /// ID and uses that ID for the bucket name. For more information, see Name Type. The bucket name must
            /// contain only lowercase letters, numbers, periods (. ), and dashes (-).
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BucketName { get; set; }

            /// <summary>
            /// CorsConfiguration
            /// Rules that define cross-origin resource sharing of objects in this bucket. For more information, see
            /// Enabling Cross-Origin Resource Sharing in the Amazon Simple Storage Service Developer Guide.
            /// Required: No
            /// Type: Amazon S3 Bucket CorsConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<CorsConfiguration, IntrinsicFunction> CorsConfiguration { get; set; }

            /// <summary>
            /// InventoryConfigurations
            /// The inventory configuration for an Amazon S3 bucket. Duplicates not allowed.
            /// Required: No
            /// Type: List of Amazon S3 Bucket InventoryConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<List<InventoryConfiguration>, IntrinsicFunction> InventoryConfigurations { get; set; }

            /// <summary>
            /// LifecycleConfiguration
            /// Rules that define how Amazon S3 manages objects during their lifetime. For more information, see
            /// Object Lifecycle Management in the Amazon Simple Storage Service Developer Guide.
            /// Required: No
            /// Type: Amazon S3 Bucket LifecycleConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<LifecycleConfiguration, IntrinsicFunction> LifecycleConfiguration { get; set; }

            /// <summary>
            /// LoggingConfiguration
            /// Settings that define where logs are stored.
            /// Required: No
            /// Type: Amazon S3 Bucket LoggingConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<LoggingConfiguration, IntrinsicFunction> LoggingConfiguration { get; set; }

            /// <summary>
            /// MetricsConfigurations
            /// Settings that define a metrics configuration for the CloudWatch request metrics from the bucket.
            /// Required: No
            /// Type: List of Amazon S3 Bucket MetricsConfiguration
            /// Update requires: No interruption
            /// Duplicates not allowed.
            /// </summary>
			public Union<List<MetricsConfiguration>, IntrinsicFunction> MetricsConfigurations { get; set; }

            /// <summary>
            /// NotificationConfiguration
            /// Configuration that defines how Amazon S3 handles bucket notifications.
            /// Required: No
            /// Type: Amazon S3 Bucket NotificationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<NotificationConfiguration, IntrinsicFunction> NotificationConfiguration { get; set; }

            /// <summary>
            /// ReplicationConfiguration
            /// Configuration for replicating objects in an S3 bucket. To enable replication, you must also enable
            /// versioning by using the VersioningConfiguration property.
            /// Amazon S3 can store replicated objects in only one destination (S3 bucket). The destination bucket
            /// must already exist and be in a different AWS Region than your source bucket.
            /// Required: No
            /// Type: Amazon S3 Bucket ReplicationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<ReplicationConfiguration, IntrinsicFunction> ReplicationConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key-value pairs) for this S3 bucket.
            /// Important We recommend limiting the number of tags to seven. Applying more than seven tags prevents
            /// the AWS CLI and the AWS CloudFormation console and API actions from listing the tags for the S3
            /// bucket.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// VersioningConfiguration
            /// Enables multiple variants of all objects in this bucket. You might enable versioning to prevent
            /// objects from being deleted or overwritten by mistake or to archive objects so that you can retrieve
            /// previous versions of them.
            /// Required: No
            /// Type: Amazon S3 Bucket VersioningConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<VersioningConfiguration, IntrinsicFunction> VersioningConfiguration { get; set; }

            /// <summary>
            /// WebsiteConfiguration
            /// Information used to configure the bucket as a static website. For more information, see Hosting
            /// Websites on Amazon S3.
            /// Required: No
            /// Type: Website Configuration Type
            /// Update requires: No interruption
            /// </summary>
			public Union<WebsiteConfiguration, IntrinsicFunction> WebsiteConfiguration { get; set; }

        }
    
        public string Type { get; } = "AWS::S3::Bucket";
        
        public BucketProperties Properties { get; } = new BucketProperties();
    }

	public static class BucketAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> DomainName = new ResourceAttribute<string>("DomainName");
        public static readonly ResourceAttribute<string> DualStackDomainName = new ResourceAttribute<string>("DualStackDomainName");
        public static readonly ResourceAttribute<string> WebsiteURL = new ResourceAttribute<string>("WebsiteURL");
	}
}
