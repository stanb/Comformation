using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// ElasticLoadBalancing Policy Type
    /// The ElasticLoadBalancing policy type is an embedded property of the AWS::ElasticLoadBalancing::LoadBalancer
    /// resource. You associate policies with a listener by referencing a policy&#39;s name in the listener&#39;s PolicyNames
    /// property.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-policy.html
    /// </summary>
    public class Policies
    {

        /// <summary>
        /// Attributes
        /// A list of arbitrary attributes for this policy. If you don&#39;t need to specify any policy attributes,
        /// specify an empty list ([]).
        /// Required: Yes
        /// Type: List of JSON name-value pairs.
        /// </summary>
        [JsonProperty("Attributes")]
        public List<Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction>> Attributes { get; set; }

        /// <summary>
        /// InstancePorts
        /// A list of instance ports for the policy. These are the ports associated with the back-end server.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("InstancePorts")]
        public List<Union<string, IntrinsicFunction>> InstancePorts { get; set; }

        /// <summary>
        /// LoadBalancerPorts
        /// A list of external load balancer ports for the policy.
        /// Required: Only for some policies. For more information, see the Elastic Load Balancing Developer
        /// Guide.
        /// Type: List of String values
        /// </summary>
        [JsonProperty("LoadBalancerPorts")]
        public List<Union<string, IntrinsicFunction>> LoadBalancerPorts { get; set; }

        /// <summary>
        /// PolicyName
        /// A name for this policy that is unique to the load balancer.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("PolicyName")]
        public Union<string, IntrinsicFunction> PolicyName { get; set; }

        /// <summary>
        /// PolicyType
        /// The name of the policy type for this policy. This must be one of the types reported by the Elastic
        /// Load Balancing DescribeLoadBalancerPolicyTypes action.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("PolicyType")]
        public Union<string, IntrinsicFunction> PolicyType { get; set; }

    }
}
