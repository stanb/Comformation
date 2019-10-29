using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroupIngress
{
    /// <summary>
    /// AWS::EC2::SecurityGroupIngress
    /// Adds an inbound rule to a security group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-ingress.html
    /// </summary>
    public class SecurityGroupIngressResource : ResourceBase
    {
        public class SecurityGroupIngressProperties
        {
            /// <summary>
            /// CidrIp
            /// The IPv4 ranges.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CidrIp { get; set; }

            /// <summary>
            /// CidrIpv6
            /// [VPC only] The IPv6 ranges.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CidrIpv6 { get; set; }

            /// <summary>
            /// Description
            /// Updates the description of an ingress (inbound) security group rule. You can replace an 			existing
            /// description, or add a description to a rule that did not have one 			previously.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// FromPort
            /// The start of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type number. 			A value of
            /// -1 indicates all ICMP/ICMPv6 types. If you specify all 			ICMP/ICMPv6 types, you must specify all
            /// codes.
            /// Use this for ICMP and any protocol that uses ports.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> FromPort { get; set; }

            /// <summary>
            /// GroupId
            /// The ID of the security group. You must specify either the security group ID or the 			security group
            /// name in the request. For security groups in a nondefault VPC, you must 			specify the security group
            /// ID.
            /// You must specify the GroupName property or the GroupId property. For security groups that are in a
            /// VPC, you must use the GroupId property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupId { get; set; }

            /// <summary>
            /// GroupName
            /// The name of the security group.
            /// Constraints: Up to 255 characters in length. Cannot start with sg-.
            /// Constraints for EC2-Classic: ASCII characters
            /// Constraints for EC2-VPC: a-z, A-Z, 0-9, spaces, and . _-:/()#,@[]+=&amp;amp;;{}!$*
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupName { get; set; }

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
            /// SourcePrefixListId
            /// [EC2-VPC only] The prefix list IDs for an AWS service. This is the AWS service that you want to
            /// access through a VPC endpoint from instances associated with the security group.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourcePrefixListId { get; set; }

            /// <summary>
            /// SourceSecurityGroupId
            /// The ID of the security group. You must specify either the security group ID or the security group
            /// name. For security groups in a nondefault VPC, you must specify the security group ID.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceSecurityGroupId { get; set; }

            /// <summary>
            /// SourceSecurityGroupName
            /// [EC2-Classic, default VPC] The name of the source security group.
            /// You must specify the GroupName property or the GroupId property. For security groups that are in a
            /// VPC, you must use the GroupId property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceSecurityGroupName { get; set; }

            /// <summary>
            /// SourceSecurityGroupOwnerId
            /// [nondefault VPC] The AWS account ID for the source security group, if the source security group is
            /// in a different account. You can&#39;t specify this parameter in combination with the following
            /// parameters: the CIDR IP address range, the IP protocol, the start of the port range, and the end of
            /// the port range. Creates rules that grant full ICMP, UDP, and TCP access.
            /// If you specify SourceSecurityGroupName or SourceSecurityGroupId and that security group is owned by
            /// a different account than the account creating the stack, you must specify the
            /// SourceSecurityGroupOwnerId; otherwise, this property is optional.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceSecurityGroupOwnerId { get; set; }

            /// <summary>
            /// ToPort
            /// The end of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code. A value 			of -1
            /// indicates all ICMP/ICMPv6 codes for the specified ICMP type. If you 			specify all ICMP/ICMPv6
            /// types, you must specify all codes.
            /// Use this for ICMP and any protocol that uses ports.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> ToPort { get; set; }

        }

        public string Type { get; } = "AWS::EC2::SecurityGroupIngress";

        public SecurityGroupIngressProperties Properties { get; } = new SecurityGroupIngressProperties();

    }
}
