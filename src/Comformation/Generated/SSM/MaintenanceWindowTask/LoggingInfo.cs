using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS Systems Manager MaintenanceWindowTask LoggingInfo
    /// The LoggingInfo property type specifies information about the Amazon S3 bucket to write instance-level logs
    /// to.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-logginginfo.html
    /// </summary>
    public class LoggingInfo
    {

        /// <summary>
        /// S3Bucket
        /// The name of the Amazon S3 bucket where execution logs are stored.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Bucket")]
        public Union<string, IntrinsicFunction> S3Bucket { get; set; }

        /// <summary>
        /// Region
        /// The region where the Amazon S3 bucket is located.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

        /// <summary>
        /// S3Prefix
        /// The Amazon S3 bucket subfolder.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Prefix")]
        public Union<string, IntrinsicFunction> S3Prefix { get; set; }

    }
}
