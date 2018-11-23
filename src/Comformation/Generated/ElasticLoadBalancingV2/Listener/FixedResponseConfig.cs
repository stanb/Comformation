using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.Listener
{
    /// <summary>
    /// Elastic Load Balancing Listener FixedResponseConfig
    /// The FixedResponseConfig property type specifies information about an action that returns a custom HTTP
    /// response.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-fixedresponseconfig.html
    /// </summary>
    public class FixedResponseConfig
    {

        /// <summary>
        /// ContentType
        /// The content type.
        /// Valid Values: text/plain | text/css | text/html | application/javascript | application/json
        /// Length Constraints: Minimum length of 0. Maximum length of 32.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContentType")]
        public Union<string, IntrinsicFunction> ContentType { get; set; }

        /// <summary>
        /// MessageBody
        /// The message.
        /// Length Constraints: Minimum length of 0. Maximum length of 1024.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageBody")]
        public Union<string, IntrinsicFunction> MessageBody { get; set; }

        /// <summary>
        /// StatusCode
        /// The HTTP response code (2XX, 4XX, or 5XX).
        /// Pattern: ^(2|4|5)\d\d$
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatusCode")]
        public Union<string, IntrinsicFunction> StatusCode { get; set; }

    }
}
