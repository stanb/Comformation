using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.TargetGroup
{
    /// <summary>
    /// Elastic Load Balancing V2 Matcher
    /// Matcher is a property of the AWS::ElasticLoadBalancingV2::TargetGroup resource that specifies the HTTP codes
    /// that healthy targets must use when responding to an Elastic Load Balancing health check.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-matcher.html
    /// </summary>
    public class Matcher
    {

        /// <summary>
        /// HttpCode
        /// The HTTP codes that a healthy target must use when responding to a health check, such as 200,202 or
        /// 200-399.
        /// For valid and default values, see the HttpCode contents for the Matcher data type in the Elastic
        /// Load Balancing API Reference version 2015-12-01.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("HttpCode")]
        public Union<string, IntrinsicFunction> HttpCode { get; set; }

    }
}
