using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroupEgress
{
    /// <summary>
    /// AWS::EC2::SecurityGroupEgress
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html
    /// </summary>
    public class SecurityGroupEgressResource : ResourceBase
    {
        public class SecurityGroupEgressProperties
        {
            /// <summary>
            /// CidrIp
            /// The IPv4 address range, in CIDR format.
            /// You must specify a destination security group (DestinationPrefixListId or
            /// DestinationSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CidrIp { get; set; }

            /// <summary>
            /// CidrIpv6
            /// The IPv6 address range, in CIDR format.
            /// You must specify a destination security group (DestinationPrefixListId or
            /// DestinationSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CidrIpv6 { get; set; }

            /// <summary>
            /// Description
            /// 		
            /// The description of an egress (outbound) security group rule.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DestinationPrefixListId
            /// [EC2-VPC only] The prefix list IDs for an AWS service. This is the AWS service that you want to
            /// access through a VPC endpoint from instances associated with the security group.
            /// You must specify a destination security group (DestinationPrefixListId or
            /// DestinationSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationPrefixListId { get; set; }

            /// <summary>
            /// DestinationSecurityGroupId
            /// The ID of the security group.
            /// You must specify a destination security group (DestinationPrefixListId or
            /// DestinationSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DestinationSecurityGroupId { get; set; }

            /// <summary>
            /// FromPort
            /// The start of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type number. A value of -1
            /// indicates all ICMP/ICMPv6 types. If you specify all 		ICMP/ICMPv6 types, you must specify all codes.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> FromPort { get; set; }

            /// <summary>
            /// GroupId
            /// 		
            /// The ID of the security group. You must specify either the security group ID or the 			security group
            /// name in the request. For security groups in a nondefault VPC, you must 			specify the security group
            /// ID.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GroupId { get; set; }

            /// <summary>
            /// IpProtocol
            /// The IP protocol name (tcp, udp, icmp, icmpv6) or number (see Protocol Numbers).
            /// [VPC only] Use -1 to specify all protocols. When authorizing security group rules, specifying -1 or
            /// a protocol number other than tcp, udp, icmp, or icmpv6 allows traffic on all ports, regardless of
            /// any port range you specify. For tcp, udp, and icmp, you must specify a port range. For icmpv6, the
            /// port range is optional; if you omit the port range, traffic for all types and codes is allowed.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> IpProtocol { get; set; }

            /// <summary>
            /// ToPort
            /// The end of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code. A value 		of -1
            /// indicates all ICMP/ICMPv6 codes. If you specify all ICMP/ICMPv6 types, you must specify all codes.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> ToPort { get; set; }

        }

        public string Type { get; } = "AWS::EC2::SecurityGroupEgress";

        public SecurityGroupEgressProperties Properties { get; } = new SecurityGroupEgressProperties();

    }
}
