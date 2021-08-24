using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3Outposts.BucketPolicy
{
    /// <summary>
    /// AWS::S3Outposts::BucketPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3outposts-bucketpolicy.html
    /// </summary>
    public class BucketPolicyResource : ResourceBase
    {
        public class BucketPolicyProperties
        {
            /// <summary>
            /// Bucket
            /// The name of the Amazon S3 Outposts bucket to which the policy applies.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Bucket { get; set; }

            /// <summary>
            /// PolicyDocument
            /// A policy document containing permissions to add to the specified bucket. In IAM, you must provide
            /// policy documents in JSON format. However, in CloudFormation, you can provide the policy in JSON or
            /// YAML format because CloudFormation converts YAML to JSON before submitting it to IAM. For more
            /// information, see the AWS::IAM::Policy PolicyDocument resource description in this guide and Access
            /// Policy Language Overview.
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

        }

        public string Type { get; } = "AWS::S3Outposts::BucketPolicy";

        public BucketPolicyProperties Properties { get; } = new BucketPolicyProperties();

    }
}
