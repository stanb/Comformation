using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Synthetics.Canary
{
    /// <summary>
    /// AWS::Synthetics::Canary Code
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-code.html
    /// </summary>
    public class Code
    {

        /// <summary>
        /// S3Bucket
        /// If your canary script is located in S3, specify the bucket name here. The bucket must already exist.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// S3Key
        /// The S3 key of your script. For more information, see Working with Amazon S3 Objects.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Key")]
        public Union<string, IntrinsicFunction> S3Key { get; set; }

        /// <summary>
        /// S3ObjectVersion
        /// The S3 version ID of your script.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3ObjectVersion")]
        public Union<string, IntrinsicFunction> S3ObjectVersion { get; set; }

        /// <summary>
        /// Script
        /// If you input your canary script directly into the canary instead of referring to an S3 location, the
        /// value of this parameter is the script in plain text. It can be up to 5 MB.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Script")]
        public Union<string, IntrinsicFunction> Script { get; set; }

        /// <summary>
        /// Handler
        /// The entry point to use for the source code when running the canary. This value must end with the
        /// string . handler.
        /// Required: Conditional
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Handler")]
        public Union<string, IntrinsicFunction> Handler { get; set; }

    }
}
