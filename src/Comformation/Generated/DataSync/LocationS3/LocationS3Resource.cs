using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationS3
{
    /// <summary>
    /// AWS::DataSync::LocationS3
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locations3.html
    /// </summary>
    public class LocationS3Resource : ResourceBase
    {
        public class LocationS3Properties
        {
            /// <summary>
            /// S3Config
            /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that is used to
            /// access an Amazon S3 bucket.
            /// For detailed information about using such a role, see Creating a Location for Amazon S3 in the AWS
            /// DataSync User Guide.
            /// Required: Yes
            /// Type: S3Config
            /// Update requires: Replacement
            /// </summary>
            public S3Config S3Config { get; set; }

            /// <summary>
            /// S3BucketArn
            /// The ARN of the Amazon S3 bucket.
            /// Required: Yes
            /// Type: String
            /// Maximum: 156
            /// Pattern: ^arn:(aws|aws-cn|aws-us-gov|aws-iso|aws-iso-b):(s3|s3-outposts):[a-z\-0-9]*:[0-9]*:. *$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> S3BucketArn { get; set; }

            /// <summary>
            /// Subdirectory
            /// A subdirectory in the Amazon S3 bucket. This subdirectory in Amazon S3 is used to read data from the
            /// S3 source location or write data to the S3 destination.
            /// Required: No
            /// Type: String
            /// Maximum: 4096
            /// Pattern: ^[a-zA-Z0-9_\-\+\. /\(\)\p{Zs}]*$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Subdirectory { get; set; }

            /// <summary>
            /// S3StorageClass
            /// The Amazon S3 storage class that you want to store your files in when this location is used as a
            /// task destination. For buckets in AWS Regions, the storage class defaults to Standard.
            /// For more information about S3 storage classes, see Amazon S3 Storage Classes. Some storage classes
            /// have behaviors that can affect your S3 storage cost. For detailed information, see Considerations
            /// When Working with Amazon S3 Storage Classes in DataSync.
            /// Required: No
            /// Type: String
            /// Allowed values: DEEP_ARCHIVE | GLACIER | INTELLIGENT_TIERING | ONEZONE_IA | OUTPOSTS | STANDARD |
            /// STANDARD_IA
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> S3StorageClass { get; set; }

            /// <summary>
            /// Tags
            /// The key-value pair that represents the tag that you want to add to the location. The value can be an
            /// empty string. We recommend using tags to name your resources.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DataSync::LocationS3";

        public LocationS3Properties Properties { get; } = new LocationS3Properties();

    }

    public static class LocationS3Attributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LocationUri = new ResourceAttribute<Union<string, IntrinsicFunction>>("LocationUri");
    }
}
