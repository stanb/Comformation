using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule CloudwatchLogsAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchlogsaction.html
    /// </summary>
    public class CloudwatchLogsAction
    {

        /// <summary>
        /// LogGroupName
        /// The CloudWatch log name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogGroupName")]
        public Union<string, IntrinsicFunction> LogGroupName { get; set; }

        /// <summary>
        /// RoleArn
        /// The IAM role that allows access to the CloudWatch log.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
