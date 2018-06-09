using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53.HealthCheck
{
    /// <summary>
    /// Amazon Route&#160;53 HealthCheck HealthCheckTags
    /// The HealthCheckTags property describes key-value pairs that are associated with an AWS::Route53::HealthCheck
    /// resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53-healthcheck-healthchecktags.html
    /// </summary>
    public class HealthCheckTag
    {

        /// <summary>
        /// Key
        /// The key name of the tag.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Value
        /// The value for the tag.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
