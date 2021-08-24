using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration ScheduledTriggerProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-scheduledtriggerproperties.html
    /// </summary>
    public class ScheduledTriggerProperties
    {

        /// <summary>
        /// ScheduleExpression
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleExpression")]
        public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

        /// <summary>
        /// DataPullMode
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataPullMode")]
        public Union<string, IntrinsicFunction> DataPullMode { get; set; }

        /// <summary>
        /// ScheduleStartTime
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleStartTime")]
        public Union<double, IntrinsicFunction> ScheduleStartTime { get; set; }

        /// <summary>
        /// ScheduleEndTime
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleEndTime")]
        public Union<double, IntrinsicFunction> ScheduleEndTime { get; set; }

        /// <summary>
        /// Timezone
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Timezone")]
        public Union<string, IntrinsicFunction> Timezone { get; set; }

        /// <summary>
        /// ScheduleOffset
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleOffset")]
        public Union<int, IntrinsicFunction> ScheduleOffset { get; set; }

        /// <summary>
        /// FirstExecutionFrom
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FirstExecutionFrom")]
        public Union<double, IntrinsicFunction> FirstExecutionFrom { get; set; }

    }
}
