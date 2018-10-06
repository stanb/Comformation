using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroupIngress
{
    /// <summary>
    /// AWS::EC2::SecurityGroupIngress
    /// The AWS::EC2::SecurityGroupIngress resource adds an ingress rule to an Amazon EC2 or Amazon VPC security
    /// group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-ingress.html
    /// </summary>
    public class SecurityGroupIngressResource : ResourceBase
    {
        public class SecurityGroupIngressProperties
        {
            /// <summary>
            /// CidrIp
            /// An IPv4 CIDR range.
            /// For an overview of CIDR ranges, go to the Wikipedia Tutorial.
            /// Type: String
            /// Required: Conditional. You must specify a source security group (SourceSecurityGroupName or
            /// SourceSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CidrIp { get; set; }

            /// <summary>
            /// CidrIpv6
            /// An IPv6 CIDR range.
            /// Type: String
            /// Required: Conditional. You must specify a source security group (SourceSecurityGroupName or
            /// SourceSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CidrIpv6 { get; set; }

            /// <summary>
            /// Description
            /// Description of the ingress rule.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// FromPort
            /// Start of port range for the TCP and UDP protocols, or an ICMP type number. If you specify icmp for
            /// the IpProtocol property, you can specify -1 as a wildcard (i. e. , any ICMP type number).
            /// Type: Integer
            /// Required: Yes, for ICMP and any protocol that uses ports.
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> FromPort { get; set; }

            /// <summary>
            /// GroupId
            /// ID of the Amazon EC2 or VPC security group to modify. The group must belong to your account.
            /// Type: String
            /// Required: Conditional. You must specify the GroupName property or the GroupId property. For security
            /// groups that are in a VPC, you must use the GroupId property. For example, EC2-VPC accounts must use
            /// the GroupId property.
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupId { get; set; }

            /// <summary>
            /// GroupName
            /// Name of the Amazon EC2 security group (non-VPC security group) to modify. This value can be a
            /// reference to an AWS::EC2::SecurityGroup resource or the name of an existing Amazon EC2 security
            /// group.
            /// Type: String
            /// Required: Conditional. You must specify the GroupName property or the GroupId property. For security
            /// groups that are in a VPC, you must use the GroupId property. For example, EC2-VPC accounts must use
            /// the GroupId property.
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// IpProtocol
            /// IP protocol name or number. For valid values, see the IpProtocol parameter in
            /// AuthorizeSecurityGroupIngress
            /// Type: String
            /// Required: Yes
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> IpProtocol { get; set; }

            /// <summary>
            /// SourceSecurityGroupId
            /// Specifies the ID of the source security group or uses the Ref intrinsic function to refer to the
            /// logical ID of a security group defined in the same template.
            /// Type: String
            /// Required: Conditional. You must specify a source security group (SourceSecurityGroupName or
            /// SourceSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceSecurityGroupId { get; set; }

            /// <summary>
            /// SourceSecurityGroupName
            /// Specifies the name of the Amazon EC2 security group (non-VPC security group) to allow access or use
            /// the Ref intrinsic function to refer to the logical ID of a security group defined in the same
            /// template. For instances in a VPC, specify the SourceSecurityGroupId property.
            /// Type: String
            /// Required: Conditional. You must specify a source security group (SourceSecurityGroupName or
            /// SourceSecurityGroupId) or a CIDR range (CidrIp or CidrIpv6).
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceSecurityGroupName { get; set; }

            /// <summary>
            /// SourceSecurityGroupOwnerId
            /// Specifies the AWS Account ID of the owner of the Amazon EC2 security group specified in the
            /// SourceSecurityGroupName property.
            /// Type: String
            /// Required: Conditional. If you specify SourceSecurityGroupName and that security group is owned by a
            /// different account than the account creating the stack, you must specify the
            /// SourceSecurityGroupOwnerId; otherwise, this property is optional.
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SourceSecurityGroupOwnerId { get; set; }

            /// <summary>
            /// ToPort
            /// End of port range for the TCP and UDP protocols, or an ICMP code. If you specify icmp for the
            /// IpProtocol property, you can specify -1 as a wildcard (i. e. , any ICMP code).
            /// Type: Integer
            /// Required: Yes, for ICMP and any protocol that uses ports.
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> ToPort { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::SecurityGroupIngress";
        
        public SecurityGroupIngressProperties Properties { get; } = new SecurityGroupIngressProperties();

    }
}
