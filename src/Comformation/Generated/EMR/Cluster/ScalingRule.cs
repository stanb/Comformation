using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster ScalingRule
    /// The ScalingRule property type represents a scale-in or scale-out rule that defines scaling activity, including
    /// the CloudWatch metric alarm that triggers activity, how Amazon EC2 instances are added or removed, and the
    /// periodicity of adjustments. The Rules subproperty of the Amazon EMR Cluster JobFlowInstancesConfig property
    /// contains a list of one or more ScalingRule property types.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig-autoscalingpolicy-constraints-scalingrule.html
    /// </summary>
    public class ScalingRule
    {

        /// <summary>
        /// Action
        /// The conditions that trigger an automatic scaling activity.
        /// Required: Yes
        /// Type: Amazon EMR Cluster ScalingAction
        /// </summary>
        [JsonProperty("Action")]
        public Union<ScalingAction, IntrinsicFunction> Action { get; set; }

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
        /// The name used to identify an automatic scaling rule. Rule names must be unique within a scaling
        /// policy.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Trigger
        /// The CloudWatch alarm definition that determines when automatic scaling activity is triggered.
        /// Required: Yes
        /// Type: Amazon EMR Cluster ScalingTrigger
        /// </summary>
        [JsonProperty("Trigger")]
        public Union<ScalingTrigger, IntrinsicFunction> Trigger { get; set; }

    }
}
