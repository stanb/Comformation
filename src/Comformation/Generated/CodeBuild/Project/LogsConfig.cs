using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project LogsConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-logsconfig.html
    /// </summary>
    public class LogsConfig
    {

        /// <summary>
        /// CloudWatchLogs
        /// Information about CloudWatch Logs for a build project. CloudWatch Logs are enabled by default.
        /// Required: No
        /// Type: CloudWatchLogsConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogs")]
        public CloudWatchLogsConfig CloudWatchLogs { get; set; }

        /// <summary>
        /// S3Logs
        /// Information about logs built to an S3 bucket for a build project. S3 logs are not enabled by
        /// default.
        /// Required: No
        /// Type: S3LogsConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Logs")]
        public S3LogsConfig S3Logs { get; set; }

    }
}
