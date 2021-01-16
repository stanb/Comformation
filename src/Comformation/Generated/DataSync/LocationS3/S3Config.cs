using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.LocationS3
{
    /// <summary>
    /// AWS::DataSync::LocationS3 S3Config
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locations3-s3config.html
    /// </summary>
    public class S3Config
    {

        /// <summary>
        /// BucketAccessRoleArn
        /// The Amazon S3 bucket to access. This bucket is used as a parameter in the CreateLocationS3
        /// operation.
        /// Required: Yes
        /// Type: String
        /// Maximum: 2048
        /// Pattern: ^arn:(aws|aws-cn|aws-us-gov|aws-iso|aws-iso-b):iam::[0-9]{12}:role/. *$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketAccessRoleArn")]
        public Union<string, IntrinsicFunction> BucketAccessRoleArn { get; set; }

    }
}
