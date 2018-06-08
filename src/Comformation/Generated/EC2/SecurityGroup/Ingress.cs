using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroup
{
    /// <summary>
    /// EC2 Security Group Rule Property Type
    /// The EC2 Security Group Rule is an embedded property of the AWS::EC2::SecurityGroup type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html
    /// </summary>
    public class Ingress
    {

        /// <summary>
        /// CidrIp
        /// Specifies an IPv4 CIDR range.
        /// Required: Conditional. You must specify only one of the following properties: CidrIp, CidrIpv6,
        /// DestinationPrefixListId, DestinationSecurityGroupId, or SourceSecurityGroupId.
        /// Type: String
        /// </summary>
        [JsonProperty("CidrIp")]
        public Union<string, IntrinsicFunction> CidrIp { get; set; }

        /// <summary>
        /// CidrIpv6
        /// Specifies an IPv6 CIDR range.
        /// Required: Conditional. You must specify only one of the following properties: CidrIp, CidrIpv6,
        /// DestinationPrefixListId, DestinationSecurityGroupId, or SourceSecurityGroupId.
        /// Type: String
        /// </summary>
        [JsonProperty("CidrIpv6")]
        public Union<string, IntrinsicFunction> CidrIpv6 { get; set; }

        /// <summary>
        /// Description
        /// Description of the security group rule.
        /// Type: String
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// FromPort
        /// The start of port range for the TCP and UDP protocols, or an ICMP type number. An ICMP type number
        /// of -1 indicates a wildcard (i. e. , any ICMP type number).
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("FromPort")]
        public Union<int, IntrinsicFunction> FromPort { get; set; }

        /// <summary>
        /// IpProtocol
        /// An IP protocol name or number. For valid values, go to the IpProtocol parameter in
        /// AuthorizeSecurityGroupIngress
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("IpProtocol")]
        public Union<string, IntrinsicFunction> IpProtocol { get; set; }

        /// <summary>
        /// SourceSecurityGroupId
        /// For VPC security groups only. Specifies the ID of the Amazon EC2 Security Group to allow access. You
        /// can use the Ref intrinsic function to refer to the logical ID of a security group defined in the
        /// same template.
        /// Required: Conditional. You must specify only one of the following properties: CidrIp, CidrIpv6,
        /// DestinationPrefixListId, DestinationSecurityGroupId, or SourceSecurityGroupId.
        /// Type: String
        /// </summary>
        [JsonProperty("SourceSecurityGroupId")]
        public Union<string, IntrinsicFunction> SourceSecurityGroupId { get; set; }

        /// <summary>
        /// SourceSecurityGroupName
        /// For non-VPC security groups only. Specifies the name of the Amazon EC2 Security Group to use for
        /// access. You can use the Ref intrinsic function to refer to the logical name of a security group that
        /// is defined in the same template.
        /// Required: Conditional. If you specify CidrIp, do not specify SourceSecurityGroupName.
        /// Type: String
        /// </summary>
        [JsonProperty("SourceSecurityGroupName")]
        public Union<string, IntrinsicFunction> SourceSecurityGroupName { get; set; }

        /// <summary>
        /// SourceSecurityGroupOwnerId
        /// Specifies the AWS Account ID of the owner of the Amazon EC2 Security Group that is specified in the
        /// SourceSecurityGroupName property.
        /// Required: Conditional. If you specify SourceSecurityGroupName and that security group is owned by a
        /// different account than the account creating the stack, you must specify the
        /// SourceSecurityGroupOwnerId; otherwise, this property is optional.
        /// Type: String
        /// </summary>
        [JsonProperty("SourceSecurityGroupOwnerId")]
        public Union<string, IntrinsicFunction> SourceSecurityGroupOwnerId { get; set; }

        /// <summary>
        /// ToPort
        /// The end of port range for the TCP and UDP protocols, or an ICMP code. An ICMP code of -1 indicates a
        /// wildcard (i. e. , any ICMP code).
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("ToPort")]
        public Union<int, IntrinsicFunction> ToPort { get; set; }

    }
}
