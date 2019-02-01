using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// Elastic Load Balancing V1 AppCookieStickinessPolicy
    /// The AppCookieStickinessPolicy type is an embedded property of the AWS::ElasticLoadBalancing::LoadBalancer
    /// type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-AppCookieStickinessPolicy.html
    /// </summary>
    public class AppCookieStickinessPolicy
    {

        /// <summary>
        /// CookieName
        /// Name of the application cookie used for stickiness.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("CookieName")]
        public Union<string, IntrinsicFunction> CookieName { get; set; }

        /// <summary>
        /// PolicyName
        /// The name of the policy being created. The name must be unique within the set of policies for this
        /// Load Balancer.
        /// Note To associate this policy with a listener, include the policy name in the listener&#39;s PolicyNames
        /// property.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("PolicyName")]
        public Union<string, IntrinsicFunction> PolicyName { get; set; }

    }
}
