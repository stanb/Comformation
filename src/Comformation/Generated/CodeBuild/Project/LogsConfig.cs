using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS CodeBuild Project LogsConfig
    /// LogsConfig is a property of the AWS::CodeBuild::Project resource that specifies settings for logs generated by
    /// an AWS CodeBuild build.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-logsconfig.html
    /// </summary>
    public class LogsConfig
    {

        /// <summary>
        /// CloudWatchLogs
        /// Information about CloudWatch Logs for a build project.
        /// Required: No
        /// Type: CloudWatchLogs
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudWatchLogs")]
        public CloudWatchLogsConfig CloudWatchLogs { get; set; }

        /// <summary>
        /// S3Logs
        /// Information about logs built to an S3 bucket for a build project.
        /// Required: No
        /// Type: S3Logs
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Logs")]
        public S3LogsConfig S3Logs { get; set; }

    }
}
