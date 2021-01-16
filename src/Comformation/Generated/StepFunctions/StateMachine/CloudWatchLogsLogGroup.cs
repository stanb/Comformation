using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.StateMachine
{
    /// <summary>
    /// AWS::StepFunctions::StateMachine CloudWatchLogsLogGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stepfunctions-statemachine-cloudwatchlogsloggroup.html
    /// </summary>
    public class CloudWatchLogsLogGroup
    {

        /// <summary>
        /// LogGroupArn
        /// The ARN of the the CloudWatch log group to which you want your logs emitted to. The ARN must end
        /// with :*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogGroupArn")]
        public Union<string, IntrinsicFunction> LogGroupArn { get; set; }

    }
}
