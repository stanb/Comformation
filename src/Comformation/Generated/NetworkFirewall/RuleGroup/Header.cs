using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.RuleGroup
{
    /// <summary>
    /// AWS::NetworkFirewall::RuleGroup Header
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html
    /// </summary>
    public class Header
    {

        /// <summary>
        /// Protocol
        /// The protocol to inspect for. To specify all, you can use IP, because all traffic on AWS and on the
        /// internet is IP.
        /// Required: Yes
        /// Type: String
        /// Allowed values: DCERPC | DHCP | DNS | FTP | HTTP | ICMP | IKEV2 | IMAP | IP | KRB5 | MSN | NTP | SMB
        /// | SMTP | SSH | TCP | TFTP | TLS | UDP
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// Source
        /// The source IP address or address range to inspect for, in CIDR notation. To match with any address,
        /// specify ANY.
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
        /// Maximum: 1024
        /// Pattern: ^. *$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source")]
        public Union<string, IntrinsicFunction> Source { get; set; }

        /// <summary>
        /// SourcePort
        /// The source port to inspect for. You can specify an individual port, for example 1994 and you can
        /// specify a port range, for example 1990:1994. To match with any port, specify ANY.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^. *$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourcePort")]
        public Union<string, IntrinsicFunction> SourcePort { get; set; }

        /// <summary>
        /// Direction
        /// The direction of traffic flow to inspect. If set to ANY, the inspection matches bidirectional
        /// traffic, both from the source to the destination and from the destination to the source. If set to
        /// FORWARD, the inspection only matches traffic going from the source to the destination.
        /// Required: Yes
        /// Type: String
        /// Allowed values: ANY | FORWARD
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Direction")]
        public Union<string, IntrinsicFunction> Direction { get; set; }

        /// <summary>
        /// Destination
        /// The destination IP address or address range to inspect for, in CIDR notation. To match with any
        /// address, specify ANY.
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
        /// Maximum: 1024
        /// Pattern: ^. *$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public Union<string, IntrinsicFunction> Destination { get; set; }

        /// <summary>
        /// DestinationPort
        /// The destination port to inspect for. You can specify an individual port, for example 1994 and you
        /// can specify a port range, for example 1990:1994. To match with any port, specify ANY.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^. *$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationPort")]
        public Union<string, IntrinsicFunction> DestinationPort { get; set; }

    }
}
