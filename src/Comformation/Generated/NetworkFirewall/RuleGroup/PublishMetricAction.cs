using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup PublishMetricAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-publishmetricaction.html
    /// </summary>
    public class PublishMetricAction
    {

        /// <summary>
        /// Dimensions
        /// Required: Yes
        /// Type: List of Dimension
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<Dimension> Dimensions { get; set; }

    }
}
