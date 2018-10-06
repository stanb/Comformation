using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// Amazon EMR InstanceGroupConfig ScalingRule
    /// The ScalingRule property type represents a scale-in or scale-out rule that defines scaling activity, including
    /// the CloudWatch metric alarm that triggers activity, how EC2 instances are added or removed, and the
    /// periodicity of adjustments. The Rules subproperty of the Amazon EMR InstanceGroupConfig AutoScalingPolicy
    /// property contains a list of one or more ScalingRule property types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingrule.html
    /// </summary>
    public class ScalingRule
    {

        /// <summary>
        /// Action
        /// The conditions that trigger an automatic scaling activity.
        /// Required: Yes
        /// Type: Amazon EMR InstanceGroupConfig ScalingAction
        /// </summary>
        [JsonProperty("Action")]
        public ScalingAction Action { get; set; }

        /// <summary>
        /// Description
        /// A friendly, more verbose description of the automatic scaling rule.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Name
        /// The identifier of the automatic scaling rule. Rule names must be unique within a scaling policy.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Trigger
        /// The CloudWatch alarm definition that determines when automatic scaling activity is triggered.
        /// Required: Yes
        /// Type: Amazon EMR InstanceGroupConfig ScalingTrigger
        /// </summary>
        [JsonProperty("Trigger")]
        public ScalingTrigger Trigger { get; set; }

    }
}
