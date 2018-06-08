using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule CloudwatchAlarmAction
    /// CloudwatchAlarm is a property of the Actions property that describes an action that updates a CloudWatch
    /// alarm.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchalarmaction.html
    /// </summary>
    public class CloudwatchAlarmAction
    {

        /// <summary>
        /// AlarmName
        /// The CloudWatch alarm name.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("AlarmName")]
        public Union<string, IntrinsicFunction> AlarmName { get; set; }

        /// <summary>
        /// RoleArn
        /// The IAM role that allows access to the CloudWatch alarm.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// StateReason
        /// The reason for the change of the alarm state.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("StateReason")]
        public Union<string, IntrinsicFunction> StateReason { get; set; }

        /// <summary>
        /// StateValue
        /// The value of the alarm state.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("StateValue")]
        public Union<string, IntrinsicFunction> StateValue { get; set; }

    }
}
