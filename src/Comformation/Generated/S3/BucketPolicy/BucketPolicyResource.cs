using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.BucketPolicy
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html
    /// </summary>
    public class BucketPolicyResource : ResourceBase
    {
        public class BucketPolicyProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html#aws-properties-s3-policy-bucket
            /// </summary>
			public Union<string, IntrinsicFunction> Bucket { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html#aws-properties-s3-policy-policydocument
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> PolicyDocument { get; set; }

        }
    
        public string Type { get; } = "AWS::S3::BucketPolicy";
        
        public BucketPolicyProperties Properties { get; } = new BucketPolicyProperties();
    }
}
