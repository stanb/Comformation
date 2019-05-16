using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceGroupConfig
{
    /// <summary>
    /// AWS::EMR::InstanceGroupConfig ScalingAction
    /// ScalingAction is a subproperty of the ScalingRule property type. ScalingAction determines the type of
    /// adjustment the automatic scaling activity makes when triggered, and the periodicity of the adjustment.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingaction.html
    /// </summary>
    public class ScalingAction
    {

        /// <summary>
        /// Market
        /// Not available for instance groups. Instance groups use the market type specified for the group.
        /// Required: No
        /// Type: String
        /// Allowed Values: ON_DEMAND | SPOT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Market")]
        public Union<string, IntrinsicFunction> Market { get; set; }

        /// <summary>
        /// SimpleScalingPolicyConfiguration
        /// The type of adjustment the automatic scaling activity makes when triggered, and the periodicity of
        /// the adjustment.
        /// Required: Yes
        /// Type: SimpleScalingPolicyConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SimpleScalingPolicyConfiguration")]
        public SimpleScalingPolicyConfiguration SimpleScalingPolicyConfiguration { get; set; }

    }
}
