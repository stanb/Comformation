using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroup
{
    /// <summary>
    /// AWS::EC2::SecurityGroup Egress
    /// Specifies an outbound rule for a security group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html
    /// </summary>
    public class Ingress
    {

        /// <summary>
        /// CidrIp
        /// The IPv4 address range, in CIDR format.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CidrIp")]
        public Union<string, IntrinsicFunction> CidrIp { get; set; }

        /// <summary>
        /// CidrIpv6
        /// [EC2-VPC only] The IPv6 ranges.
        /// The IPv6 address range, in CIDR format.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CidrIpv6")]
        public Union<string, IntrinsicFunction> CidrIpv6 { get; set; }

        /// <summary>
        /// Description
        /// A description for the security group rule.
        /// Constraints: Up to 255 characters in length. Allowed characters are a-z, A-Z, 0-9, spaces, and .
        /// _-:/()#,@[]+=;{}!$*
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// FromPort
        /// The start of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 type number. A value of -1
        /// indicates all ICMP/ICMPv6 types. If you specify all 		ICMP/ICMPv6 types, you must specify all codes.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FromPort")]
        public Union<int, IntrinsicFunction> FromPort { get; set; }

        /// <summary>
        /// IpProtocol
        /// The IP protocol name (tcp, udp, icmp, icmpv6) or number (see Protocol Numbers).
        /// [VPC only] Use -1 to specify all protocols. When authorizing security group rules, specifying -1 or
        /// a protocol number other than tcp, udp, icmp, or icmpv6 allows traffic on all ports, regardless of
        /// any port range you specify. For tcp, udp, and icmp, you must specify a port range. For icmpv6, the
        /// port range is optional; if you omit the port range, traffic for all types and codes is allowed.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IpProtocol")]
        public Union<string, IntrinsicFunction> IpProtocol { get; set; }

        /// <summary>
        /// SourcePrefixListId
        /// </summary>
        [JsonProperty("SourcePrefixListId")]
        public Union<string, IntrinsicFunction> SourcePrefixListId { get; set; }

        /// <summary>
        /// SourceSecurityGroupId
        /// </summary>
        [JsonProperty("SourceSecurityGroupId")]
        public Union<string, IntrinsicFunction> SourceSecurityGroupId { get; set; }

        /// <summary>
        /// SourceSecurityGroupName
        /// </summary>
        [JsonProperty("SourceSecurityGroupName")]
        public Union<string, IntrinsicFunction> SourceSecurityGroupName { get; set; }

        /// <summary>
        /// SourceSecurityGroupOwnerId
        /// </summary>
        [JsonProperty("SourceSecurityGroupOwnerId")]
        public Union<string, IntrinsicFunction> SourceSecurityGroupOwnerId { get; set; }

        /// <summary>
        /// ToPort
        /// The end of port range for the TCP and UDP protocols, or an ICMP/ICMPv6 code. A value 		of -1
        /// indicates all ICMP/ICMPv6 codes. If you specify all ICMP/ICMPv6 types, you must specify all codes.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ToPort")]
        public Union<int, IntrinsicFunction> ToPort { get; set; }

    }
}
