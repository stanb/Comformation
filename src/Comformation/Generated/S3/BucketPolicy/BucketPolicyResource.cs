using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.BucketPolicy
{
    /// <summary>
    /// AWS::S3::BucketPolicy
    /// The AWS::S3::BucketPolicy type applies an Amazon S3 bucket policy to an Amazon S3 bucket.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html
    /// </summary>
    public class BucketPolicyResource : ResourceBase
    {
        public class BucketPolicyProperties
        {
            /// <summary>
            /// Bucket
            /// The Amazon S3 bucket that the policy applies to.
            /// Required: Yes
            /// Type: String
            /// You cannot update this property. If you want to add or remove a bucket from a bucket policy, you
            /// must modify your AWS CloudFormation template by creating a new bucket policy resource and removing
            /// the old one. Then use the modified template to update your AWS CloudFormation stack.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html#cfn-s3-bucketpolicy-bucket
            /// </summary>
			public Union<string, IntrinsicFunction> Bucket { get; set; }

            /// <summary>
            /// PolicyDocument
            /// A policy document containing permissions to add to the specified bucket. For more information, see
            /// Access Policy Language Overview in the Amazon Simple Storage Service Developer Guide.
            /// Required: Yes
            /// Type: JSON object
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html#cfn-s3-bucketpolicy-policydocument
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

        }
    
        public string Type { get; } = "AWS::S3::BucketPolicy";
        
        public BucketPolicyProperties Properties { get; } = new BucketPolicyProperties();
    }
}
