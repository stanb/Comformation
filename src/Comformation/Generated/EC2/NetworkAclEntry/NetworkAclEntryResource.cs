using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkAclEntry
{
    /// <summary>
    /// AWS::EC2::NetworkAclEntry
    /// Specifies an entry, known as a rule, in a network ACL with a rule number you specify. Each network ACL has a
    /// set of numbered ingress rules and a separate set of numbered egress rules.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html
    /// </summary>
    public class NetworkAclEntryResource : ResourceBase
    {
        public class NetworkAclEntryProperties
        {
            /// <summary>
            /// CidrBlock
            /// The IPv4 CIDR range to allow or deny, in CIDR notation (for example, 172. 16. 0. 0/24). Requirement
            /// is conditional: You must specify the CidrBlock or Ipv6CidrBlock property.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CidrBlock { get; set; }

            /// <summary>
            /// Egress
            /// Whether this rule applies to egress traffic from the subnet (true) or ingress traffic to the subnet
            /// (false). By default, AWS CloudFormation specifies false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> Egress { get; set; }

            /// <summary>
            /// Icmp
            /// The Internet Control Message Protocol (ICMP) code and type. Requirement is conditional: Required if
            /// specifying 1 (ICMP) for the protocol parameter.
            /// Required: No
            /// Type: Icmp
            /// Update requires: No interruption
            /// </summary>
			public Icmp Icmp { get; set; }

            /// <summary>
            /// Ipv6CidrBlock
            /// The IPv6 network range to allow or deny, in CIDR notation. Requirement is conditional: You must
            /// specify the CidrBlock or Ipv6CidrBlock property.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Ipv6CidrBlock { get; set; }

            /// <summary>
            /// NetworkAclId
            /// The ID of the ACL for the entry.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkAclId { get; set; }

            /// <summary>
            /// PortRange
            /// The range of port numbers for the UDP/TCP protocol. Conditional required if specifying 6 (TCP) or 17
            /// (UDP) for the protocol parameter.
            /// Required: No
            /// Type: PortRange
            /// Update requires: No interruption
            /// </summary>
			public PortRange PortRange { get; set; }

            /// <summary>
            /// Protocol
            /// The IP protocol that the rule applies to. You must specify -1 or a protocol number. You can specify
            /// -1 for all protocols.
            /// Note If you specify -1, all ports are opened and the PortRange property is ignored.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// RuleAction
            /// Whether to allow or deny traffic that matches the rule; valid values are &quot;allow&quot; or &quot;deny&quot;.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: allow | deny
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RuleAction { get; set; }

            /// <summary>
            /// RuleNumber
            /// Rule number to assign to the entry, such as 100. ACL entries are processed in ascending order by
            /// rule number. Entries can&#39;t use the same rule number unless one is an egress rule and the other is an
            /// ingress rule.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> RuleNumber { get; set; }

        }

        public string Type { get; } = "AWS::EC2::NetworkAclEntry";

        public NetworkAclEntryProperties Properties { get; } = new NetworkAclEntryProperties();

    }
}
