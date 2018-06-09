using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScalingPlans.ScalingPlan
{
    /// <summary>
    /// AWS Auto Scaling ScalingPlan TagFilter
    /// The TagFilter property type specifies a tag for an application source for an AWS Auto Scaling scaling plan.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-tagfilter.html
    /// </summary>
    public class TagFilter
    {

        /// <summary>
        /// Values
        /// The tag values (0 to 20).
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public Union<List<string>, IntrinsicFunction> Values { get; set; }

        /// <summary>
        /// Key
        /// The tag key.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
