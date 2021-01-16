using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket AccelerateConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-accelerateconfiguration.html
    /// </summary>
    public class AccelerateConfiguration
    {

        /// <summary>
        /// AccelerationStatus
        /// Specifies the transfer acceleration status of the bucket.
        /// Required: Yes
        /// Type: String
        /// Allowed values: Enabled | Suspended
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccelerationStatus")]
        public Union<string, IntrinsicFunction> AccelerationStatus { get; set; }

    }
}
