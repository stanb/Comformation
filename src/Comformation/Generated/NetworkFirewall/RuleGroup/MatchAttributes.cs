using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup MatchAttributes
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html
    /// </summary>
    public class MatchAttributes
    {

        /// <summary>
        /// Sources
        /// The source IP addresses and address ranges to inspect for, in CIDR notation. If not specified, this
        /// matches with any source address.
        /// Required: No
        /// Type: List of Address
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sources")]
        public List<Address> Sources { get; set; }

        /// <summary>
        /// Destinations
        /// The destination IP addresses and address ranges to inspect for, in CIDR notation. If not specified,
        /// this matches with any destination address.
        /// Required: No
        /// Type: List of Address
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destinations")]
        public List<Address> Destinations { get; set; }

        /// <summary>
        /// SourcePorts
        /// The source ports to inspect for. If not specified, this matches with any source port. This setting
        /// is only used for protocols 6 (TCP) and 17 (UDP).
        /// You can specify individual ports, for example 1994 and you can specify port ranges, for example
        /// 1990:1994.
        /// Required: No
        /// Type: List of PortRange
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourcePorts")]
        public List<PortRange> SourcePorts { get; set; }

        /// <summary>
        /// DestinationPorts
        /// The destination ports to inspect for. If not specified, this matches with any destination port. This
        /// setting is only used for protocols 6 (TCP) and 17 (UDP).
        /// You can specify individual ports, for example 1994 and you can specify port ranges, for example
        /// 1990:1994.
        /// Required: No
        /// Type: List of PortRange
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationPorts")]
        public List<PortRange> DestinationPorts { get; set; }

        /// <summary>
        /// Protocols
        /// The protocols to inspect for, specified using each protocol&#39;s assigned internet protocol number
        /// (IANA). If not specified, this matches with any protocol.
        /// Required: No
        /// Type: List of Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocols")]
        public List<Union<int, IntrinsicFunction>> Protocols { get; set; }

        /// <summary>
        /// TCPFlags
        /// The TCP flags and masks to inspect for. If not specified, this matches with any settings. This
        /// setting is only used for protocol 6 (TCP).
        /// Required: No
        /// Type: List of TCPFlagField
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TCPFlags")]
        public List<TCPFlagField> TCPFlags { get; set; }

    }
}
