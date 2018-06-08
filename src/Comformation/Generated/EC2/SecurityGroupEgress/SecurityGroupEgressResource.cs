using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroupEgress
{
    /// <summary>
    /// AWS::EC2::SecurityGroupEgress
    /// The AWS::EC2::SecurityGroupEgress resource adds an egress rule to an Amazon VPC security group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html
    /// </summary>
    public class SecurityGroupEgressResource : ResourceBase
    {
        public class SecurityGroupEgressProperties
        {
            /// <summary>
            /// CidrIp
            /// An IPv4 CIDR range.
            /// Required: Conditional. You must specify a destination security group (DestinationPrefixListId or
            /// DestinationSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CidrIp { get; set; }

            /// <summary>
            /// CidrIpv6
            /// An IPv6 CIDR range.
            /// Type: String
            /// Required: Conditional. You must specify a destination security group (DestinationPrefixListId or
            /// DestinationSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CidrIpv6 { get; set; }

            /// <summary>
            /// Description
            /// Description of the egress rule.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DestinationPrefixListId
            /// The AWS service prefix of an Amazon VPC endpoint. For more information, see VPC Endpoints in the
            /// Amazon VPC User Guide.
            /// Required: Conditional. You must specify a destination security group (DestinationPrefixListId or
            /// DestinationSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationPrefixListId { get; set; }

            /// <summary>
            /// DestinationSecurityGroupId
            /// Specifies the group ID of the destination Amazon VPC security group.
            /// Required: Conditional. You must specify a destination security group (DestinationPrefixListId or
            /// DestinationSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DestinationSecurityGroupId { get; set; }

            /// <summary>
            /// FromPort
            /// Start of port range for the TCP and UDP protocols, or an ICMP type number. If you specify icmp for
            /// the IpProtocol property, you can specify -1 as a wildcard (i. e. , any ICMP type number).
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> FromPort { get; set; }

            /// <summary>
            /// GroupId
            /// ID of the Amazon VPC security group to modify. This value can be a reference to an
            /// AWS::EC2::SecurityGroup resource that has a valid VpcId property or the ID of an existing Amazon VPC
            /// security group.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupId { get; set; }

            /// <summary>
            /// IpProtocol
            /// IP protocol name or number. For valid values, see the IpProtocol parameter in
            /// AuthorizeSecurityGroupIngress
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> IpProtocol { get; set; }

            /// <summary>
            /// ToPort
            /// End of port range for the TCP and UDP protocols, or an ICMP code. If you specify icmp for the
            /// IpProtocol property, you can specify -1 as a wildcard (i. e. , any ICMP code).
            /// Required: Yes
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> ToPort { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::SecurityGroupEgress";
        
        public SecurityGroupEgressProperties Properties { get; } = new SecurityGroupEgressProperties();
    }
}
