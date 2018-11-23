using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// Amazon Data Lifecycle Manager LifecyclePolicy CreateRule
    /// The CreateRule property type specifies when to create snapshots of EBS volumes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html
    /// </summary>
    public class CreateRule
    {

        /// <summary>
        /// IntervalUnit
        /// The time unit. The supported unit is HOURS.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntervalUnit")]
        public Union<string, IntrinsicFunction> IntervalUnit { get; set; }

        /// <summary>
        /// Times
        /// The time, in UTC, to start the operation.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Times")]
        public List<Union<string, IntrinsicFunction>> Times { get; set; }

        /// <summary>
        /// Interval
        /// The time interval between snapshots. Supported values are 12 and 24.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Union<int, IntrinsicFunction> Interval { get; set; }

    }
}
