using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule FixedResponseConfig
    /// Specifies information required when returning a custom HTTP response.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-fixedresponseconfig.html
    /// </summary>
    public class FixedResponseConfig
    {

        /// <summary>
        /// ContentType
        /// The content type.
        /// Valid Values: text/plain | text/css | text/html | application/javascript | application/json
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 32
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContentType")]
        public Union<string, IntrinsicFunction> ContentType { get; set; }

        /// <summary>
        /// MessageBody
        /// The message.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageBody")]
        public Union<string, IntrinsicFunction> MessageBody { get; set; }

        /// <summary>
        /// StatusCode
        /// The HTTP response code (2XX, 4XX, or 5XX).
        /// Required: Yes
        /// Type: String
        /// Pattern: ^(2|4|5)\d\d$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatusCode")]
        public Union<string, IntrinsicFunction> StatusCode { get; set; }

    }
}
