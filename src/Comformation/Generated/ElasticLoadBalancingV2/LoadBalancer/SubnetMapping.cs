using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.LoadBalancer
{
    /// <summary>
    /// Elastic Load Balancing LoadBalancer SubnetMapping
    /// The SubnetMapping property type specifies the ID of a subnet to attach to an Elastic Load Balancing
    /// Application or Network Load Balancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-subnetmapping.html
    /// </summary>
    public class SubnetMapping
    {

        /// <summary>
        /// AllocationId
        /// [Network Load Balancer] The ID that represents the allocation of the Elastic IP address.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllocationId")]
        public Union<string, IntrinsicFunction> AllocationId { get; set; }

        /// <summary>
        /// SubnetId
        /// The ID of the subnet.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubnetId")]
        public Union<string, IntrinsicFunction> SubnetId { get; set; }

    }
}
