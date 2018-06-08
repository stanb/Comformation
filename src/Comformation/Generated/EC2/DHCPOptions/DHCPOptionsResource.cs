using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.DHCPOptions
{
    /// <summary>
    /// AWS::EC2::DHCPOptions
    /// Creates a set of DHCP options for your VPC.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcp-options.html
    /// </summary>
    public class DHCPOptionsResource : ResourceBase
    {
        public class DHCPOptionsProperties
        {
            /// <summary>
            /// DomainName
            /// A domain name of your choice.
            /// Required: Conditional; see note.
            /// Type: String
            /// Update requires: Replacement
            /// Example: "example. com"
            /// </summary>
			public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// DomainNameServers
            /// The IP (IPv4) address of a domain name server. You can specify up to four addresses.
            /// Required: Conditional; see note.
            /// Type: List of String values
            /// Update requires: Replacement
            /// Example: "DomainNameServers" : [ "10. 0. 0. 1", "10. 0. 0. 2" ]
            /// Example: To preserve the order of IP addresses, specify a comma delimited list as a single string:
            /// "DomainNameServers" : [ "10. 0. 0. 1, 10. 0. 0. 2" ]
            /// </summary>
			public Union<List<string>, IntrinsicFunction> DomainNameServers { get; set; }

            /// <summary>
            /// NetbiosNameServers
            /// The IP address (IPv4) of a NetBIOS name server. You can specify up to four addresses.
            /// Required: Conditional; see note.
            /// Type: List of String values
            /// Update requires: Replacement
            /// Example: "NetbiosNameServers" : [ "10. 0. 0. 1", "10. 0. 0. 2" ]
            /// Example: To preserve the order of IP addresses, specify a comma delimited list as a single string:
            /// "NetbiosNameServers" : [ "10. 0. 0. 1, 10. 0. 0. 2" ]
            /// </summary>
			public Union<List<string>, IntrinsicFunction> NetbiosNameServers { get; set; }

            /// <summary>
            /// NetbiosNodeType
            /// An integer value indicating the NetBIOS node type:
            /// 1: Broadcast ("B") 2: Point-to-point ("P") 4: Mixed mode ("M") 8: Hybrid ("H")
            /// For more information about these values and about NetBIOS node types, see RFC 2132, RFC 1001, and
            /// RFC 1002. We recommend that you use only the value 2 at this time (broadcast and multicast are not
            /// currently supported).
            /// Required: Required if NetBiosNameServers is specified; optional otherwise.
            /// Type: List of numbers
            /// Update requires: Replacement
            /// Example: "NetbiosNodeType" : 2
            /// </summary>
			public Union<int, IntrinsicFunction> NetbiosNodeType { get; set; }

            /// <summary>
            /// NtpServers
            /// The IP address (IPv4) of a Network Time Protocol (NTP) server. You can specify up to four addresses.
            /// Required: Conditional; see note.
            /// Type: List of String values
            /// Update requires: Replacement
            /// Example: "NtpServers" : [ "10. 0. 0. 1" ]
            /// Example: To preserve the order of IP addresses, specify a comma delimited list as a single string:
            /// "NtpServers" : [ "10. 0. 0. 1, 10. 0. 0. 2" ]
            /// </summary>
			public Union<List<string>, IntrinsicFunction> NtpServers { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this resource.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption.
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::DHCPOptions";
        
        public DHCPOptionsProperties Properties { get; } = new DHCPOptionsProperties();
    }
}
