using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application S3ContentBaseLocation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentbaselocation.html
    /// </summary>
    public class S3ContentBaseLocation
    {

        /// <summary>
        /// BucketARN
        /// The Amazon Resource Name (ARN) of the S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 2048
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketARN")]
        public Union<string, IntrinsicFunction> BucketARN { get; set; }

        /// <summary>
        /// BasePath
        /// The base path for the S3 bucket.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: [a-zA-Z0-9/!-_. *&#39;()]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BasePath")]
        public Union<string, IntrinsicFunction> BasePath { get; set; }

    }
}
