using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Script
{
    /// <summary>
    /// AWS::GameLift::Script S3Location
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-script-s3location.html
    /// </summary>
    public class S3Location
    {

        /// <summary>
        /// ObjectVersion
        /// The version of the file, if object versioning is turned on for the bucket. Amazon Web Services uses
        /// this information when retrieving files from an S3 bucket that you own. Use this parameter to specify
        /// a specific version of the file. If not set, the latest version of the file is retrieved.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectVersion")]
        public Union<string, IntrinsicFunction> ObjectVersion { get; set; }

        /// <summary>
        /// Bucket
        /// An Amazon S3 bucket identifier. This is the name of the S3 bucket.
        /// Note GameLift currently does not support uploading from Amazon S3 buckets with names that contain a
        /// dot (. ).
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// Key
        /// The name of the zip file that contains the build files or script files.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) for an IAM role that allows Amazon Web Services to access the S3
        /// bucket.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
