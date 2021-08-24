using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule CloudwatchAlarmAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchalarmaction.html
    /// </summary>
    public class CloudwatchAlarmAction
    {

        /// <summary>
        /// StateValue
        /// The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StateValue")]
        public Union<string, IntrinsicFunction> StateValue { get; set; }

        /// <summary>
        /// AlarmName
        /// The CloudWatch alarm name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlarmName")]
        public Union<string, IntrinsicFunction> AlarmName { get; set; }

        /// <summary>
        /// StateReason
        /// The reason for the alarm change.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StateReason")]
        public Union<string, IntrinsicFunction> StateReason { get; set; }

        /// <summary>
        /// RoleArn
        /// The IAM role that allows access to the CloudWatch alarm.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
