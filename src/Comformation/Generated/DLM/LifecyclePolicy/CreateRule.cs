using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy CreateRule
    /// Specifies when to create snapshots of EBS volumes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html
    /// </summary>
    public class CreateRule
    {

        /// <summary>
        /// IntervalUnit
        /// The interval unit.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: HOURS
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntervalUnit")]
        public Union<string, IntrinsicFunction> IntervalUnit { get; set; }

        /// <summary>
        /// Times
        /// The time, in UTC, to start the operation. The supported format is hh:mm.
        /// The operation occurs within a one-hour window following the specified time.
        /// Required: No
        /// Type: List of String
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Times")]
        public List<Union<string, IntrinsicFunction>> Times { get; set; }

        /// <summary>
        /// Interval
        /// The interval between snapshots. The supported values are 2, 3, 4, 6, 8, 12, and 24.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Interval")]
        public Union<int, IntrinsicFunction> Interval { get; set; }

    }
}
