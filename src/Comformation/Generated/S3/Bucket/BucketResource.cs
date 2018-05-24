using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html
    /// </summary>
    public class BucketResource : ResourceBase
    {
        public class BucketProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-accelerateconfiguration
            /// </summary>
			public Union<AccelerateConfiguration, IntrinsicFunction> AccelerateConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-accesscontrol
            /// </summary>
			public Union<string, IntrinsicFunction> AccessControl { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-analyticsconfigurations
            /// </summary>
			public Union<List<AnalyticsConfiguration>, IntrinsicFunction> AnalyticsConfigurations { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-bucketencryption
            /// </summary>
			public Union<BucketEncryption, IntrinsicFunction> BucketEncryption { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-name
            /// </summary>
			public Union<string, IntrinsicFunction> BucketName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-crossoriginconfig
            /// </summary>
			public Union<CorsConfiguration, IntrinsicFunction> CorsConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-inventoryconfigurations
            /// </summary>
			public Union<List<InventoryConfiguration>, IntrinsicFunction> InventoryConfigurations { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-lifecycleconfig
            /// </summary>
			public Union<LifecycleConfiguration, IntrinsicFunction> LifecycleConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-loggingconfig
            /// </summary>
			public Union<LoggingConfiguration, IntrinsicFunction> LoggingConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-metricsconfigurations
            /// </summary>
			public Union<List<MetricsConfiguration>, IntrinsicFunction> MetricsConfigurations { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-notification
            /// </summary>
			public Union<NotificationConfiguration, IntrinsicFunction> NotificationConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-replicationconfiguration
            /// </summary>
			public Union<ReplicationConfiguration, IntrinsicFunction> ReplicationConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-versioning
            /// </summary>
			public Union<VersioningConfiguration, IntrinsicFunction> VersioningConfiguration { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-websiteconfiguration
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
