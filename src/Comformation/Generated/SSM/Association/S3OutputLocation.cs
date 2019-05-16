using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS::SSM::Association S3OutputLocation
    /// S3OutputLocation is a property of the AWS::SSM::Association resource that specifies an Amazon S3 bucket where
    /// you want to store the results of this association request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-s3outputlocation.html
    /// </summary>
    public class S3OutputLocation
    {

        /// <summary>
        /// OutputS3BucketName
        /// The name of the Amazon S3 bucket.
        /// Required: No
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3BucketName")]
        public Union<string, IntrinsicFunction> OutputS3BucketName { get; set; }

        /// <summary>
        /// OutputS3KeyPrefix
        /// The Amazon S3 bucket subfolder.
        /// Required: No
        /// Type: String
        /// Maximum: 500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3KeyPrefix")]
        public Union<string, IntrinsicFunction> OutputS3KeyPrefix { get; set; }

    }
}
