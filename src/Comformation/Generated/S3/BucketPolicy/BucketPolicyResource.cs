using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.BucketPolicy
{
    /// <summary>
    /// AWS::S3::BucketPolicy
    /// Applies an Amazon S3 bucket policy to an Amazon S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html
    /// </summary>
    public class BucketPolicyResource : ResourceBase
    {
        public class BucketPolicyProperties
        {
            /// <summary>
            /// Bucket
            /// The name of the Amazon S3 bucket to which the policy applies.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Bucket { get; set; }

            /// <summary>
            /// PolicyDocument
            /// A policy document containing permissions to add to the specified bucket. For more information, see
            /// Access Policy Language Overview in the Amazon Simple Storage Service Developer Guide.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

        }

        public string Type { get; } = "AWS::S3::BucketPolicy";

        public BucketPolicyProperties Properties { get; } = new BucketPolicyProperties();

    }
}
