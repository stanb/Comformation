using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS::SSM::Association S3OutputLocation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-s3outputlocation.html
    /// </summary>
    public class S3OutputLocation
    {

        /// <summary>
        /// OutputS3Region
        /// (Deprecated) You can no longer specify this parameter. The system ignores it. Instead, AWS Systems
        /// Manager automatically determines the Region of the S3 bucket.
        /// Required: No
        /// Type: String
        /// Minimum: 3
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3Region")]
        public Union<string, IntrinsicFunction> OutputS3Region { get; set; }

        /// <summary>
        /// OutputS3BucketName
        /// The name of the S3 bucket.
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
        /// The S3 bucket subfolder.
        /// Required: No
        /// Type: String
        /// Maximum: 500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3KeyPrefix")]
        public Union<string, IntrinsicFunction> OutputS3KeyPrefix { get; set; }

    }
}
