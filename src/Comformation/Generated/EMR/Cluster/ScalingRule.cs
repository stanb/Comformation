using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster ScalingRule
    /// ScalingRule is a subproperty of the AutoScalingPolicy property type. ScalingRule defines the scale-in or
    /// scale-out rules for scaling activity, including the CloudWatch metric alarm that triggers activity, how EC2
    /// instances are added or removed, and the periodicity of adjustments. The automatic scaling policy for an
    /// instance group can comprise one or more automatic scaling rules.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingrule.html
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
