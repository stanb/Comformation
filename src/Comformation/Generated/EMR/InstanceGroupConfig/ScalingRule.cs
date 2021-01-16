using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// AWS::EMR::InstanceGroupConfig ScalingRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingrule.html
    /// </summary>
    public class ScalingRule
    {

        /// <summary>
        /// Action
        /// The conditions that trigger an automatic scaling activity.
        /// Required: Yes
        /// Type: ScalingAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public ScalingAction Action { get; set; }

        /// <summary>
        /// Description
        /// A friendly, more verbose description of the automatic scaling rule.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Name
        /// The name used to identify an automatic scaling rule. Rule names must be unique within a scaling
        /// policy.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Trigger
        /// The CloudWatch alarm definition that determines when automatic scaling activity is triggered.
        /// Required: Yes
        /// Type: ScalingTrigger
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Trigger")]
        public ScalingTrigger Trigger { get; set; }

    }
}
