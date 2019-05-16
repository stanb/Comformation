using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket LoggingConfiguration
    /// Describes where logs are stored and the prefix that Amazon S3 assigns to all log object keys for a bucket. For
    /// more information, see PUT Bucket logging in the Amazon Simple Storage Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-loggingconfig.html
    /// </summary>
    public class LoggingConfiguration
    {

        /// <summary>
        /// DestinationBucketName
        /// The name of the bucket where Amazon S3 should store server access log files. You can store log files
        /// in any bucket that you own. By default, logs are stored in the bucket where the LoggingConfiguration
        /// property is defined.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationBucketName")]
        public Union<string, IntrinsicFunction> DestinationBucketName { get; set; }

        /// <summary>
        /// LogFilePrefix
        /// A prefix for all log object keys. If you store log files from multiple Amazon S3 buckets in a single
        /// bucket, you can use a prefix to distinguish which log files came from which bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogFilePrefix")]
        public Union<string, IntrinsicFunction> LogFilePrefix { get; set; }

    }
}
