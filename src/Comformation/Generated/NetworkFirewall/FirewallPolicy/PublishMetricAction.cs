using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.FirewallPolicy
{
    /// <summary>
    /// AWS::NetworkFirewall::FirewallPolicy PublishMetricAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-publishmetricaction.html
    /// </summary>
    public class PublishMetricAction
    {

        /// <summary>
        /// Dimensions
        /// Required: Yes
        /// Type: Dimensions
        /// Maximum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Dimensions")]
        public List<Dimension> Dimensions { get; set; }

    }
}
