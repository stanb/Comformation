using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeBuild.Project
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-cloudwatchlogsconfig.html
    /// </summary>
    public class CloudWatchLogsConfig
    {

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

        /// <summary>
        /// GroupName
        /// </summary>
        [JsonProperty("GroupName")]
        public Union<string, IntrinsicFunction> GroupName { get; set; }

        /// <summary>
        /// StreamName
        /// </summary>
        [JsonProperty("StreamName")]
        public Union<string, IntrinsicFunction> StreamName { get; set; }

    }
}
