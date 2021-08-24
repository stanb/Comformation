using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// AWS::CodeBuild::Project CloudWatchLogsConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-cloudwatchlogsconfig.html
    /// </summary>
    public class CloudWatchLogsConfig
    {

        /// <summary>
        /// Status
        /// The current status of the logs in CloudWatch Logs for a build project. Valid values are:
        /// ENABLED: CloudWatch Logs are enabled for this build project. DISABLED: CloudWatch Logs are not
        /// enabled for this build project.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// GroupName
        /// The group name of the logs in CloudWatch Logs. For more information, see Working with Log Groups and
        /// Log Streams.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GroupName")]
        public Union<string, IntrinsicFunction> GroupName { get; set; }

        /// <summary>
        /// StreamName
        /// The prefix of the stream name of the CloudWatch Logs. For more information, see Working with Log
        /// Groups and Log Streams.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamName")]
        public Union<string, IntrinsicFunction> StreamName { get; set; }

    }
}
