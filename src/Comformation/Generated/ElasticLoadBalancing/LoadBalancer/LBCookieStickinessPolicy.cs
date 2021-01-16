using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// AWS::ElasticLoadBalancing::LoadBalancer LBCookieStickinessPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-LBCookieStickinessPolicy.html
    /// </summary>
    public class LBCookieStickinessPolicy
    {

        /// <summary>
        /// CookieExpirationPeriod
        /// The time period, in seconds, after which the cookie should be considered stale. If this parameter is
        /// not specified, the stickiness session lasts for the duration of the browser session.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CookieExpirationPeriod")]
        public Union<string, IntrinsicFunction> CookieExpirationPeriod { get; set; }

        /// <summary>
        /// PolicyName
        /// The name of the policy. This name must be unique within the set of policies for this load balancer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyName")]
        public Union<string, IntrinsicFunction> PolicyName { get; set; }

    }
}
