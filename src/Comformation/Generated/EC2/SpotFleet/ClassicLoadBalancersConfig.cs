using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon EC2 SpotFleet ClassicLoadBalancersConfig
    /// The ClassicLoadBalancersConfig property type specifies the Classic Load Balancers to attach to a Spot Fleet.
    /// Spot Fleet registers the running Spot Instances with these Classic Load Balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-classicloadbalancersconfig.html
    /// </summary>
    public class ClassicLoadBalancersConfig
    {

        /// <summary>
        /// ClassicLoadBalancers
        /// One or more Classic Load Balancers to attach to the Spot Fleet. Duplicates not allowed. For property
        /// constraints, see ClassicLoadBalancersConfig in the Amazon EC2 API Reference.
        /// Required: Yes
        /// Type: List of Amazon EC2 SpotFleet ClassicLoadBalancer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClassicLoadBalancers")]
        public List<ClassicLoadBalancer> ClassicLoadBalancers { get; set; }

    }
}
