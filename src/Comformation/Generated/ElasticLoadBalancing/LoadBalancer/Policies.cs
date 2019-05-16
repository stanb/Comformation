using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancing::LoadBalancer Policies
    /// Specifies policies for your Classic Load Balancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-policy.html
    /// </summary>
    public class Policies
    {

        /// <summary>
        /// Attributes
        /// The policy attributes.
        /// Required: Yes
        /// Type: List of Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public List<Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction>> Attributes { get; set; }

        /// <summary>
        /// InstancePorts
        /// The instance ports for the policy. Required only for some policy types.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstancePorts")]
        public List<Union<string, IntrinsicFunction>> InstancePorts { get; set; }

        /// <summary>
        /// LoadBalancerPorts
        /// The load balancer ports for the policy. Required only for some policy types.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoadBalancerPorts")]
        public List<Union<string, IntrinsicFunction>> LoadBalancerPorts { get; set; }

        /// <summary>
        /// PolicyName
        /// The name of the policy.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyName")]
        public Union<string, IntrinsicFunction> PolicyName { get; set; }

        /// <summary>
        /// PolicyType
        /// The name of the policy type.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyType")]
        public Union<string, IntrinsicFunction> PolicyType { get; set; }

    }
}
