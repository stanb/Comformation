using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project LogsConfig
    /// LogsConfig is a property of the AWS CodeBuild Project resource that specifies information about logs for a
    /// build project. These can be logs in Amazon CloudWatch Logs, built in a specified S3 bucket, or both.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-logsconfig.html
    /// </summary>
    public class LogsConfig
    {

        /// <summary>
        /// CloudWatchLogs
        /// Information about Amazon CloudWatch Logs for a build project. Amazon CloudWatch Logs are enabled by
        /// default.
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
