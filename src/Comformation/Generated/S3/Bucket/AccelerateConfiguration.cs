using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket AccelerateConfiguration
    /// The AccelerateConfiguration property type configures the transfer acceleration state for an Amazon S3 bucket.
    /// For more information, see Amazon S3 Transfer Acceleration in the Amazon Simple Storage Service Developer
    /// Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-accelerateconfiguration.html
    /// </summary>
    public class AccelerateConfiguration
    {

        /// <summary>
        /// AccelerationStatus
        /// Sets the transfer acceleration state of the bucket.
        /// Required: Yes
        /// Type: String
        /// Valid values: Enabled, Suspended
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccelerationStatus")]
        public Union<string, IntrinsicFunction> AccelerationStatus { get; set; }

    }
}
