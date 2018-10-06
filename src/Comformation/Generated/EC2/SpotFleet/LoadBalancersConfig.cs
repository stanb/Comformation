using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon EC2 SpotFleet LoadBalancersConfig
    /// The LoadBalancersConfig property type specifies the Classic Load Balancers and target groups to attach to a
    /// Spot Fleet request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-loadbalancersconfig.html
    /// </summary>
    public class LoadBalancersConfig
    {

        /// <summary>
        /// ClassicLoadBalancersConfig
        /// The Classic Load Balancers to attach to the SpotFleet request.
        /// Required: No
        /// Type: Amazon EC2 SpotFleet ClassicLoadBalancersConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClassicLoadBalancersConfig")]
        public ClassicLoadBalancersConfig ClassicLoadBalancersConfig { get; set; }

        /// <summary>
        /// TargetGroupsConfig
        /// The target groups to attach to the SpotFleet request.
        /// Required: No
        /// Type: Amazon EC2 SpotFleet TargetGroupsConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetGroupsConfig")]
        public TargetGroupsConfig TargetGroupsConfig { get; set; }

    }
}
