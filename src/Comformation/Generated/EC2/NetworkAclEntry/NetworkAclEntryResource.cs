using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.NetworkAclEntry
{
    /// <summary>
    /// AWS::EC2::NetworkAclEntry
    /// Creates an entry (i. e. , a rule) in a network ACL with a rule number you specify. Each network ACL has a set
    /// of numbered ingress rules and a separate set of numbered egress rules.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html
    /// </summary>
    public class NetworkAclEntryResource : ResourceBase
    {
        public class NetworkAclEntryProperties
        {
            /// <summary>
            /// CidrBlock
            /// The IPv4 CIDR range to allow or deny, in CIDR notation (e. g. , 172. 16. 0. 0/24).
            /// Required: Conditional. You must specify the CidrBlock or Ipv6CidrBlock property.
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-cidrblock
            /// </summary>
			public Union<string, IntrinsicFunction> CidrBlock { get; set; }

            /// <summary>
            /// Egress
            /// Whether this rule applies to egress traffic from the subnet (true) or ingress traffic to the subnet
            /// (false). By default, AWS CloudFormation specifies false.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-egress
            /// </summary>
			public Union<bool, IntrinsicFunction> Egress { get; set; }

            /// <summary>
            /// Icmp
            /// The Internet Control Message Protocol (ICMP) code and type.
            /// Required: Conditional required if specifying 1 (ICMP) for the protocol parameter.
            /// Type: EC2 NetworkAclEntry Icmp
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-icmp
            /// </summary>
			public Union<Icmp, IntrinsicFunction> Icmp { get; set; }

            /// <summary>
            /// Ipv6CidrBlock
            /// The IPv6 CIDR range to allow or deny, in CIDR notation.
            /// Required: Conditional. You must specify the CidrBlock or Ipv6CidrBlock property.
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-ipv6cidrblock
            /// </summary>
			public Union<string, IntrinsicFunction> Ipv6CidrBlock { get; set; }

            /// <summary>
            /// NetworkAclId
            /// ID of the ACL where the entry will be created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-networkaclid
            /// </summary>
			public Union<string, IntrinsicFunction> NetworkAclId { get; set; }

            /// <summary>
            /// PortRange
            /// The range of port numbers for the UDP/TCP protocol.
            /// Required: Conditional Required if specifying 6 (TCP) or 17 (UDP) for the protocol parameter.
            /// Type: EC2 NetworkAclEntry PortRange
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-portrange
            /// </summary>
			public Union<PortRange, IntrinsicFunction> PortRange { get; set; }

            /// <summary>
            /// Protocol
            /// The IP protocol that the rule applies to. You must specify -1 or a protocol number (go to Protocol
            /// Numbers at iana. org). You can specify -1 for all protocols.
            /// Note If you specify -1, all ports are opened and the PortRange property is ignored.
            /// Required: Yes
            /// Type: Number
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-protocol
            /// </summary>
			public Union<int, IntrinsicFunction> Protocol { get; set; }

            /// <summary>
            /// RuleAction
            /// Whether to allow or deny traffic that matches the rule; valid values are "allow" or "deny".
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-ruleaction
            /// </summary>
			public Union<string, IntrinsicFunction> RuleAction { get; set; }

            /// <summary>
            /// RuleNumber
            /// Rule number to assign to the entry, such as 100. ACL entries are processed in ascending order by
            /// rule number. Entries can't use the same rule number unless one is an egress rule and the other is an
            /// ingress rule. For valid values, see the CreateNetworkAclEntry action in the Amazon EC2 API
            /// Reference.
            /// Required: Yes
            /// Type: Number
            /// Update requires: Replacement.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-rulenumber
            /// </summary>
			public Union<int, IntrinsicFunction> RuleNumber { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::NetworkAclEntry";
        
        public NetworkAclEntryProperties Properties { get; } = new NetworkAclEntryProperties();
    }
}
