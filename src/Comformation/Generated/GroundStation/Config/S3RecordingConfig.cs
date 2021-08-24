using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config S3RecordingConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-s3recordingconfig.html
    /// </summary>
    public class S3RecordingConfig
    {

        /// <summary>
        /// BucketArn
        /// S3 Bucket where the data is written. The name of the S3 Bucket provided must begin with
        /// aws-groundstation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketArn")]
        public Union<string, IntrinsicFunction> BucketArn { get; set; }

        /// <summary>
        /// RoleArn
        /// Defines the ARN of the role assumed for putting archives to S3.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Prefix
        /// The prefix of the S3 data object. If you choose to use any optional keys for substitution, these
        /// values will be replaced with the corresponding information from your contact details. For example, a
        /// prefix of {satellite_id}/{year}/{month}/{day}/ will replaced with fake_satellite_id/2021/01/10/
        /// Optional keys for substitution: {satellite_id} | {config-name} | {config-id} | {year} | {month} |
        /// {day}
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

    }
}
