using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application S3ContentLocation
    /// The S3ContentLocation property type specifies a description of an Amazon S3 object, including the Amazon
    /// Resource Name (ARN) of the S3 bucket, the name of the Amazon S3 object that contains the data, and the version
    /// number of the Amazon S3 object that contains the data for a Java-based Amazon Kinesis Data Analytics
    /// application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-s3contentlocation.html
    /// </summary>
    public class S3ContentLocation
    {

        /// <summary>
        /// BucketARN
        /// The Amazon Resource Name (ARN) for the S3 bucket containing the application code.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketARN")]
        public Union<string, IntrinsicFunction> BucketARN { get; set; }

        /// <summary>
        /// FileKey
        /// The file key for the object containing the application code.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileKey")]
        public Union<string, IntrinsicFunction> FileKey { get; set; }

        /// <summary>
        /// ObjectVersion
        /// The version of the object containing the application code.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectVersion")]
        public Union<string, IntrinsicFunction> ObjectVersion { get; set; }

    }
}
