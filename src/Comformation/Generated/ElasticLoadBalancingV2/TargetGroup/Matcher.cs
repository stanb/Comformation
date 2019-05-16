using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.TargetGroup
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::TargetGroup Matcher
    /// Specifies the HTTP codes that healthy targets must use when responding to an HTTP health check.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-matcher.html
    /// </summary>
    public class Matcher
    {

        /// <summary>
        /// HttpCode
        /// The HTTP codes.
        /// For Application Load Balancers, you can specify values between 200 and 499, and the default value is
        /// 200. You can specify multiple values (for example, &quot;200,202&quot;) or a range of values (for example,
        /// &quot;200-299&quot;).
        /// For Network Load Balancers, this is 200–399.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpCode")]
        public Union<string, IntrinsicFunction> HttpCode { get; set; }

    }
}
