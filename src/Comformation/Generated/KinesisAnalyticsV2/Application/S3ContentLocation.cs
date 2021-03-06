using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application S3ContentLocation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentlocation.html
    /// </summary>
    public class S3ContentLocation
    {

        /// <summary>
        /// BucketARN
        /// The Amazon Resource Name (ARN) for the S3 bucket containing the application code.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketARN")]
        public Union<string, IntrinsicFunction> BucketARN { get; set; }

        /// <summary>
        /// FileKey
        /// The file key for the object containing the application code.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileKey")]
        public Union<string, IntrinsicFunction> FileKey { get; set; }

        /// <summary>
        /// ObjectVersion
        /// The version of the object containing the application code.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectVersion")]
        public Union<string, IntrinsicFunction> ObjectVersion { get; set; }

    }
}
