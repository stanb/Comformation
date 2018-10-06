using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Instance
{
    /// <summary>
    /// AWS OpsWorks TimeBasedAutoScaling Type
    /// Describes the automatic time-based scaling configuration for an AWS::OpsWorks::Instance resource type. For
    /// more information, see SetTimeBasedAutoScaling in the AWS OpsWorks Stacks API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-instance-timebasedautoscaling.html
    /// </summary>
    public class TimeBasedAutoScaling
    {

        /// <summary>
        /// Friday
        /// The schedule for Friday.
        /// Required: No
        /// Type: String to string map
        /// </summary>
        [JsonProperty("Friday")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Friday { get; set; }

        /// <summary>
        /// Monday
        /// The schedule for Monday.
        /// Required: No
        /// Type: String to string map
        /// </summary>
        [JsonProperty("Monday")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Monday { get; set; }

        /// <summary>
        /// Saturday
        /// The schedule for Saturday.
        /// Required: No
        /// Type: String to string map
        /// </summary>
        [JsonProperty("Saturday")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Saturday { get; set; }

        /// <summary>
        /// Sunday
        /// The schedule for Sunday.
        /// Required: No
        /// Type: String to string map
        /// </summary>
        [JsonProperty("Sunday")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Sunday { get; set; }

        /// <summary>
        /// Thursday
        /// The schedule for Thursday.
        /// Required: No
        /// Type: String to string map
        /// </summary>
        [JsonProperty("Thursday")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Thursday { get; set; }

        /// <summary>
        /// Tuesday
        /// The schedule for Tuesday.
        /// Required: No
        /// Type: String to string map
        /// </summary>
        [JsonProperty("Tuesday")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Tuesday { get; set; }

        /// <summary>
        /// Wednesday
        /// The schedule for Wednesday.
        /// Required: No
        /// Type: String to string map
        /// </summary>
        [JsonProperty("Wednesday")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Wednesday { get; set; }

    }
}
