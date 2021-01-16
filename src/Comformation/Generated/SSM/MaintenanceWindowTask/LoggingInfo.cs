using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTask LoggingInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-logginginfo.html
    /// </summary>
    public class LoggingInfo
    {

        /// <summary>
        /// S3Bucket
        /// The name of an S3 bucket where execution logs are stored .
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// Region
        /// The Region where the S3 bucket is located.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 20
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

        /// <summary>
        /// S3Prefix
        /// The Amazon S3 bucket subfolder.
        /// Required: No
        /// Type: String
        /// Maximum: 500
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Prefix")]
        public Union<string, IntrinsicFunction> S3Prefix { get; set; }

    }
}
