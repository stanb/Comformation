using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow ErrorHandlingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-errorhandlingconfig.html
    /// </summary>
    public class ErrorHandlingConfig
    {

        /// <summary>
        /// FailOnFirstError
        /// Specifies if the flow should fail after the first instance of a failure when attempting to place
        /// data in the destination.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FailOnFirstError")]
        public Union<bool, IntrinsicFunction> FailOnFirstError { get; set; }

        /// <summary>
        /// BucketPrefix
        /// Specifies the Amazon S3 bucket prefix.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketPrefix")]
        public Union<string, IntrinsicFunction> BucketPrefix { get; set; }

        /// <summary>
        /// BucketName
        /// Specifies the name of the Amazon S3 bucket.
        /// Required: No
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

    }
}
