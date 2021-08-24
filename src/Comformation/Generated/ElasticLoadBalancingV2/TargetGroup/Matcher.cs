using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.TargetGroup
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::TargetGroup Matcher
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-matcher.html
    /// </summary>
    public class Matcher
    {

        /// <summary>
        /// GrpcCode
        /// You can specify values between 0 and 99. You can specify multiple values (for example, &quot;0,1&quot;) or a
        /// range of values (for example, &quot;0-5&quot;). The default value is 12.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GrpcCode")]
        public Union<string, IntrinsicFunction> GrpcCode { get; set; }

        /// <summary>
        /// HttpCode
        /// For Application Load Balancers, you can specify values between 200 and 499, and the default value is
        /// 200. You can specify multiple values (for example, &quot;200,202&quot;) or a range of values (for example,
        /// &quot;200-299&quot;).
        /// For Network Load Balancers and Gateway Load Balancers, this must be &quot;200–399&quot;.
        /// Note that when using shorthand syntax, some values such as commas need to be escaped.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpCode")]
        public Union<string, IntrinsicFunction> HttpCode { get; set; }

    }
}
