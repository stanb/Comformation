using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon EC2 SpotFleet ClassicLoadBalancer
    /// The ClassicLoadBalancer property type specifies a Classic Load Balancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-classicloadbalancer.html
    /// </summary>
    public class ClassicLoadBalancer
    {

        /// <summary>
        /// Name
        /// The name of the load balancer.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
