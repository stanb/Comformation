using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancing.LoadBalancer
{
    /// <summary>
    /// ElasticLoadBalancing LBCookieStickinessPolicy Type
    /// The LBCookieStickinessPolicy type is an embedded property of the AWS::ElasticLoadBalancing::LoadBalancer type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-LBCookieStickinessPolicy.html
    /// </summary>
    public class LBCookieStickinessPolicy
    {

        /// <summary>
        /// CookieExpirationPeriod
        /// The time period, in seconds, after which the cookie should be considered stale. If this parameter
        /// isn't specified, the sticky session will last for the duration of the browser session.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CookieExpirationPeriod")]
        public Union<string, IntrinsicFunction> CookieExpirationPeriod { get; set; }

        /// <summary>
        /// PolicyName
        /// The name of the policy being created. The name must be unique within the set of policies for this
        /// load balancer.
        /// Note To associate this policy with a listener, include the policy name in the listener's PolicyNames
        /// property.
        /// </summary>
        [JsonProperty("PolicyName")]
        public Union<string, IntrinsicFunction> PolicyName { get; set; }

    }
}
