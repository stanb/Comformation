using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SecurityGroup
{
    /// <summary>
    /// AWS::EC2::SecurityGroup Egress
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-security-group-rule.html
    /// </summary>
    public class Egress
    {

        /// <summary>
        /// CidrIp
        /// The destination IPv4 address range, in CIDR format.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CidrIp")]
        public Union<string, IntrinsicFunction> CidrIp { get; set; }

        /// <summary>
        /// CidrIpv6
        /// [EC2-VPC only] The IPv6 ranges.
        /// 	
        /// The destination IPv6 address range, in CIDR format.
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
        /// DestinationPrefixListId
        /// 	
        /// [EC2-VPC only] The prefix list IDs for the destination AWS service. This is the AWS service that you
        /// want to access through a VPC endpoint from instances associated with the security group.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationPrefixListId")]
        public Union<string, IntrinsicFunction> DestinationPrefixListId { get; set; }

        /// <summary>
        /// DestinationSecurityGroupId
        /// The ID of the destination VPC security group.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationSecurityGroupId")]
        public Union<string, IntrinsicFunction> DestinationSecurityGroupId { get; set; }

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
