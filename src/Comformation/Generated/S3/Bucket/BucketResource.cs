using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket
    /// The AWS::S3::Bucket resource creates an Amazon S3 bucket in the same AWS Region where you create the AWS
    /// CloudFormation stack.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html
    /// </summary>
    public class BucketResource : ResourceBase
    {
        public class BucketProperties
        {
            /// <summary>
            /// AccelerateConfiguration
            /// Configures the transfer acceleration state for an Amazon S3 bucket. For more information, see Amazon
            /// S3 Transfer Acceleration in the Amazon Simple Storage Service Developer Guide.
            /// Required: No
            /// Type: AccelerateConfiguration
            /// Update requires: No interruption
            /// </summary>
			public AccelerateConfiguration AccelerateConfiguration { get; set; }

            /// <summary>
            /// AccessControl
            /// A canned access control list (ACL) that grants predefined permissions to the bucket. For more
            /// information about canned ACLs, see Canned ACL in the Amazon Simple Storage Service Developer Guide.
            /// Be aware that the syntax for this property differs from the information provided in the Amazon
            /// Simple Storage Service Developer Guide. The AccessControl property is case-sensitive and must be one
            /// of the following values: Private, PublicRead, PublicReadWrite, AuthenticatedRead, LogDeliveryWrite,
            /// BucketOwnerRead, BucketOwnerFullControl, or AwsExecRead.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AccessControl { get; set; }

            /// <summary>
            /// AnalyticsConfigurations
            /// Specifies the configuration and any analyses for the analytics filter of an Amazon S3 bucket.
            /// Required: No
            /// Type: List of AnalyticsConfiguration
            /// Update requires: No interruption
            /// </summary>
			public List<AnalyticsConfiguration> AnalyticsConfigurations { get; set; }

            /// <summary>
            /// BucketEncryption
            /// Specifies default encryption for a bucket using server-side encryption with Amazon S3-managed keys
            /// (SSE-S3) or AWS KMS-managed keys (SSE-KMS) bucket. For information about the Amazon S3 default
            /// encryption feature, see Amazon S3 Default Encryption for S3 Buckets in the Amazon Simple Storage
            /// Service Developer Guide.
            /// Required: No
            /// Type: BucketEncryption
            /// Update requires: No interruption
            /// </summary>
			public BucketEncryption BucketEncryption { get; set; }

            /// <summary>
            /// BucketName
            /// A name for the bucket. If you don&#39;t specify a name, AWS CloudFormation generates a unique ID and
            /// uses that ID for the bucket name. For more information, see Name Type. The bucket name must contain
            /// only lowercase letters, numbers, periods (. ), and dashes (-).
            /// Important If you specify a name, you can&#39;t perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you need to replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BucketName { get; set; }

            /// <summary>
            /// CorsConfiguration
            /// Describes the cross-origin access configuration for objects in an Amazon S3 bucket. For more
            /// information, see Enabling Cross-Origin Resource Sharing in the Amazon Simple Storage Service
            /// Developer Guide.
            /// Required: No
            /// Type: CorsConfiguration
            /// Update requires: No interruption
            /// </summary>
			public CorsConfiguration CorsConfiguration { get; set; }

            /// <summary>
            /// InventoryConfigurations
            /// Specifies the inventory configuration for an Amazon S3 bucket. For more information, see GET Bucket
            /// inventory in the Amazon Simple Storage Service API Reference.
            /// Required: No
            /// Type: List of InventoryConfiguration
            /// Update requires: No interruption
            /// </summary>
			public List<InventoryConfiguration> InventoryConfigurations { get; set; }

            /// <summary>
            /// LifecycleConfiguration
            /// Specifies the lifecycle configuration for objects in an Amazon S3 bucket. For more information, see
            /// Object Lifecycle Management in the Amazon Simple Storage Service Developer Guide.
            /// Required: No
            /// Type: LifecycleConfiguration
            /// Update requires: No interruption
            /// </summary>
			public LifecycleConfiguration LifecycleConfiguration { get; set; }

            /// <summary>
            /// LoggingConfiguration
            /// Settings that define where logs are stored.
            /// Required: No
            /// Type: LoggingConfiguration
            /// Update requires: No interruption
            /// </summary>
			public LoggingConfiguration LoggingConfiguration { get; set; }

            /// <summary>
            /// MetricsConfigurations
            /// Specifies a metrics configuration for the CloudWatch request metrics (specified by the metrics
            /// configuration ID) from an Amazon S3 bucket. If you&#39;re updating an existing metrics configuration,
            /// note that this is a full replacement of the existing metrics configuration. If you don&#39;t include the
            /// elements you want to keep, they are erased. For more information, see PUT Bucket metrics in the
            /// Amazon Simple Storage Service API Reference.
            /// Required: No
            /// Type: List of MetricsConfiguration
            /// Update requires: No interruption
            /// </summary>
			public List<MetricsConfiguration> MetricsConfigurations { get; set; }

            /// <summary>
            /// NotificationConfiguration
            /// Configuration that defines how Amazon S3 handles bucket notifications.
            /// Required: No
            /// Type: NotificationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public NotificationConfiguration NotificationConfiguration { get; set; }

            /// <summary>
            /// ObjectLockConfiguration
            /// Places an Object Lock configuration on the specified bucket. The rule specified in the Object Lock
            /// configuration will be applied by default to every new object placed in the specified bucket.
            /// Note DefaultRetention requires either Days or Years. You can&#39;t specify both at the same time.
            /// Related Resources Locking Objects
            /// Required: No
            /// Type: ObjectLockConfiguration
            /// Update requires: No interruption
            /// </summary>
			public ObjectLockConfiguration ObjectLockConfiguration { get; set; }

            /// <summary>
            /// ObjectLockEnabled
            /// Indicates whether this bucket has an Object Lock configuration enabled.
            /// Required: No
            /// Type: Boolean
            /// Allowed Values: Enabled
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> ObjectLockEnabled { get; set; }

            /// <summary>
            /// PublicAccessBlockConfiguration
            /// Configuration that defines how Amazon S3 handles public access.
            /// Required: No
            /// Type: PublicAccessBlockConfiguration
            /// Update requires: No interruption
            /// </summary>
			public PublicAccessBlockConfiguration PublicAccessBlockConfiguration { get; set; }

            /// <summary>
            /// ReplicationConfiguration
            /// Configuration for replicating objects in an S3 bucket. To enable replication, you must also enable
            /// versioning by using the VersioningConfiguration property.
            /// Amazon S3 can store replicated objects in only one destination bucket. The destination bucket must
            /// already exist and be in a different AWS Region than your source bucket.
            /// Required: No
            /// Type: ReplicationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public ReplicationConfiguration ReplicationConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key-value pairs) for this S3 bucket.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// VersioningConfiguration
            /// Enables multiple versions of all objects in this bucket. You might enable versioning to prevent
            /// objects from being deleted or overwritten by mistake or to archive objects so that you can retrieve
            /// previous versions of them.
            /// Required: No
            /// Type: VersioningConfiguration
            /// Update requires: No interruption
            /// </summary>
			public VersioningConfiguration VersioningConfiguration { get; set; }

            /// <summary>
            /// WebsiteConfiguration
            /// Information used to configure the bucket as a static website. For more information, see Hosting
            /// Websites on Amazon S3.
            /// Required: No
            /// Type: WebsiteConfiguration
            /// Update requires: No interruption
            /// </summary>
			public WebsiteConfiguration WebsiteConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::S3::Bucket";

        public BucketProperties Properties { get; } = new BucketProperties();

    }

	public static class BucketAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DualStackDomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("DualStackDomainName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RegionalDomainName = new ResourceAttribute<Union<string, IntrinsicFunction>>("RegionalDomainName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> WebsiteURL = new ResourceAttribute<Union<string, IntrinsicFunction>>("WebsiteURL");
	}
}
