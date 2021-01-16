using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup Address
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-address.html
    /// </summary>
    public class Address
    {

        /// <summary>
        /// AddressDefinition
        /// Specify an IP address or a block of IP addresses in Classless Inter-Domain Routing (CIDR) notation.
        /// Network Firewall supports all address ranges for IPv4.
        /// Examples:
        /// To configure Network Firewall to inspect for the IP address 192. 0. 2. 44, specify 192. 0. 2. 44/32.
        /// To configure Network Firewall to inspect for IP addresses from 192. 0. 2. 0 to 192. 0. 2. 255,
        /// specify 192. 0. 2. 0/24.
        /// For more information about CIDR notation, see the Wikipedia entry Classless Inter-Domain Routing.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: ^([a-fA-F\d:\. ]+/\d{1,3})$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AddressDefinition")]
        public Union<string, IntrinsicFunction> AddressDefinition { get; set; }

    }
}
