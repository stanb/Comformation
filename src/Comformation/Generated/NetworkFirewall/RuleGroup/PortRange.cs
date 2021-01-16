using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup PortRange
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portrange.html
    /// </summary>
    public class PortRange
    {

        /// <summary>
        /// FromPort
        /// The lower limit of the port range. This must be less than or equal to the ToPort specification.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FromPort")]
        public Union<int, IntrinsicFunction> FromPort { get; set; }

        /// <summary>
        /// ToPort
        /// The upper limit of the port range. This must be greater than or equal to the FromPort specification.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 65535
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ToPort")]
        public Union<int, IntrinsicFunction> ToPort { get; set; }

    }
}
