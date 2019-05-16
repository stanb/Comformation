using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// AWS::EC2::SpotFleet ClassicLoadBalancersConfig
    /// Specifies the Classic Load Balancers to attach to a Spot Fleet. Spot Fleet registers the running Spot
    /// Instances with these Classic Load Balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-classicloadbalancersconfig.html
    /// </summary>
    public class ClassicLoadBalancersConfig
    {

        /// <summary>
        /// ClassicLoadBalancers
        /// One or more Classic Load Balancers.
        /// Required: Yes
        /// Type: List of ClassicLoadBalancer
        /// Maximum: 5
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClassicLoadBalancers")]
        public List<ClassicLoadBalancer> ClassicLoadBalancers { get; set; }

    }
}
