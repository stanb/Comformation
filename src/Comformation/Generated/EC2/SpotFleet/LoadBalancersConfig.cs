using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet LoadBalancersConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-loadbalancersconfig.html
    /// </summary>
    public class LoadBalancersConfig
    {

        /// <summary>
        /// ClassicLoadBalancersConfig
        /// The Classic Load Balancers.
        /// Required: No
        /// Type: ClassicLoadBalancersConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ClassicLoadBalancersConfig")]
        public ClassicLoadBalancersConfig ClassicLoadBalancersConfig { get; set; }

        /// <summary>
        /// TargetGroupsConfig
        /// The target groups.
        /// Required: No
        /// Type: TargetGroupsConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TargetGroupsConfig")]
        public TargetGroupsConfig TargetGroupsConfig { get; set; }

    }
}
