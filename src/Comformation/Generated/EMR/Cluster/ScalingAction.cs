using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster ScalingAction
    /// The ScalingAction property type specifies the scaling actions for an Auto Scaling group policy. ScalingAction
    /// is the property type for the Action subproperty of the Amazon EMR Cluster ScalingRule property type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html
    /// </summary>
    public class ScalingAction
    {

        /// <summary>
        /// Market
        /// Not available for instance groups. Instance groups use the market type specified for the group.
        /// Valid values: ON_DEMAND or SPOT
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Market")]
        public Union<string, IntrinsicFunction> Market { get; set; }

        /// <summary>
        /// SimpleScalingPolicyConfiguration
        /// The type of adjustment the automatic scaling activity makes when triggered, and the periodicity of
        /// the adjustment.
        /// Required: Yes
        /// Type: Amazon EMR Cluster SimpleScalingPolicyConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SimpleScalingPolicyConfiguration")]
        public SimpleScalingPolicyConfiguration SimpleScalingPolicyConfiguration { get; set; }

    }
}
