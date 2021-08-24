using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3Outposts.Bucket
{
    /// <summary>
    /// AWS::S3Outposts::Bucket
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-bucket.html
    /// </summary>
    public class BucketResource : ResourceBase
    {
        public class BucketProperties
        {
            /// <summary>
            /// BucketName
            /// A name for the S3 on Outposts bucket. If you don&#39;t specify a name, AWS CloudFormation generates a
            /// unique ID and uses that ID for the bucket name. The bucket name must contain only lowercase letters,
            /// numbers, periods (. ), and dashes (-) and must follow Amazon S3 bucket restrictions and limitations.
            /// For more information, see Bucket naming rules.
            /// Important If you specify a name, you can&#39;t perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you need to replace the
            /// resource, specify a new name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BucketName { get; set; }

            /// <summary>
            /// OutpostId
            /// The ID of the Outpost of the specified bucket.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> OutpostId { get; set; }

            /// <summary>
            /// Tags
            /// Sets the tags for an S3 on Outposts bucket. For more information, see Using Amazon S3 on Outposts.
            /// Use tags to organize your AWS bill to reflect your own cost structure. To do this, sign up to get
            /// your AWS account bill with tag key values included. Then, to see the cost of combined resources,
            /// organize your billing information according to resources with the same tag key values. For example,
            /// you can tag several resources with a specific application name, and then organize your billing
            /// information to see the total cost of that application across several services. For more information,
            /// see Cost allocation and tags.
            /// Note Within a bucket, if you add a tag that has the same key as an existing tag, the new value
            /// overwrites the old value. For more information, see Using cost allocation and bucket tags.
            /// To use this resource, you must have permissions to perform the s3-outposts:PutBucketTagging. The S3
            /// on Outposts bucket owner has this permission by default and can grant this permission to others. For
            /// more information about permissions, see Permissions Related to Bucket Subresource Operations and
            /// Managing access permissions to your Amazon S3 resources.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// LifecycleConfiguration
            /// Creates a new lifecycle configuration for the S3 on Outposts bucket or replaces an existing
            /// lifecycle configuration. Outposts buckets only support lifecycle configurations that delete/expire
            /// objects after a certain period of time and abort incomplete multipart uploads.
            /// Required: No
            /// Type: LifecycleConfiguration
            /// Update requires: No interruption
            /// </summary>
            public LifecycleConfiguration LifecycleConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::S3Outposts::Bucket";

        public BucketProperties Properties { get; } = new BucketProperties();

    }

    public static class BucketAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
