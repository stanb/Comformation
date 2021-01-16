using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.InfrastructureConfiguration
{
    /// <summary>
    /// AWS::ImageBuilder::InfrastructureConfiguration S3Logs
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-s3logs.html
    /// </summary>
    public class S3Logs
    {

        /// <summary>
        /// S3BucketName
        /// The Amazon S3 bucket in which to store the logs.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3BucketName")]
        public Union<string, IntrinsicFunction> S3BucketName { get; set; }

        /// <summary>
        /// S3KeyPrefix
        /// The Amazon S3 path in which to store the logs.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3KeyPrefix")]
        public Union<string, IntrinsicFunction> S3KeyPrefix { get; set; }

    }
}
