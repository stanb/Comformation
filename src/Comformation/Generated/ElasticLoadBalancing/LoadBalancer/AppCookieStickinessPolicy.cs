using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancing::LoadBalancer AppCookieStickinessPolicy
    /// Specifies a policy for application-controlled session stickiness for your Classic Load Balancer.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-AppCookieStickinessPolicy.html
    /// </summary>
    public class AppCookieStickinessPolicy
    {

        /// <summary>
        /// CookieName
        /// The name of the application cookie used for stickiness.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CookieName")]
        public Union<string, IntrinsicFunction> CookieName { get; set; }

        /// <summary>
        /// PolicyName
        /// The mnemonic name for the policy being created. The name must be unique within a set of policies for
        /// this load balancer.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyName")]
        public Union<string, IntrinsicFunction> PolicyName { get; set; }

    }
}
