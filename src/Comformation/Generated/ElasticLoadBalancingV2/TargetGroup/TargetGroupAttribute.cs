using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.TargetGroup
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::TargetGroup TargetGroupAttribute
    /// Specifies a target group attribute.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-targetgroup-targetgroupattribute.html
    /// </summary>
    public class TargetGroupAttribute
    {

        /// <summary>
        /// Key
        /// The name of the attribute.
        /// The following attribute is supported by both Application Load Balancers and Network Load Balancers:
        /// deregistration_delay. timeout_seconds - The amount of time, in seconds, for Elastic Load Balancing
        /// to wait before changing the state of a deregistering target from draining to unused. The range is
        /// 0-3600 seconds. The default value is 300 seconds. If the target is a Lambda function, this attribute
        /// is not supported.
        /// The following attributes are supported by Application Load Balancers if the target is not a Lambda
        /// function:
        /// slow_start. duration_seconds - The time period, in seconds, during which a newly registered target
        /// receives a linearly increasing share of the traffic to the target group. After this time period
        /// ends, the target receives its full share of traffic. The range is 30-900 seconds (15 minutes). Slow
        /// start mode is disabled by default. stickiness. enabled - Indicates whether sticky sessions are
        /// enabled. The value is true or false. The default is false. stickiness. type - The type of sticky
        /// sessions. The possible value is lb_cookie. stickiness. lb_cookie. duration_seconds - The time
        /// period, in seconds, during which requests from a client should be routed to the same target. After
        /// this time period expires, the load balancer-generated cookie is considered stale. The range is 1
        /// second to 1 week (604800 seconds). The default value is 1 day (86400 seconds).
        /// The following attribute is supported only if the target is a Lambda function.
        /// lambda. multi_value_headers. enabled - Indicates whether the request and response headers exchanged
        /// between the load balancer and the Lambda function include arrays of values or strings. The value is
        /// true or false. The default is false. If the value is false and the request contains a duplicate
        /// header field name or query parameter key, the load balancer uses the last value sent by the client.
        /// The following attribute is supported only by Network Load Balancers:
        /// proxy_protocol_v2. enabled - Indicates whether Proxy Protocol version 2 is enabled. The value is
        /// true or false. The default is false.
        /// Required: No
        /// Type: String
        /// Maximum: 256
        /// Pattern: ^[a-zA-Z0-9. _]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value of the attribute.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
