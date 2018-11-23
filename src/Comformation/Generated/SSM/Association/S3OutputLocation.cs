using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS Systems Manager Association S3OutputLocation
    /// S3OutputLocation is a property of the InstanceAssociationOutputLocation property that specifies an Amazon S3
    /// bucket where you want to store the results of this request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-s3outputlocation.html
    /// </summary>
    public class S3OutputLocation
    {

        /// <summary>
        /// OutputS3BucketName
        /// The name of the Amazon S3 bucket.
        /// Minimum length of 3. Maximum length of 63.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3BucketName")]
        public Union<string, IntrinsicFunction> OutputS3BucketName { get; set; }

        /// <summary>
        /// OutputS3KeyPrefix
        /// The Amazon S3 bucket subfolder.
        /// Maximum length of 500.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputS3KeyPrefix")]
        public Union<string, IntrinsicFunction> OutputS3KeyPrefix { get; set; }

    }
}
