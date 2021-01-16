using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.DHCPOptions
{
    /// <summary>
    /// AWS::EC2::DHCPOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-dhcp-options.html
    /// </summary>
    public class DHCPOptionsResource : ResourceBase
    {
        public class DHCPOptionsProperties
        {
            /// <summary>
            /// DomainName
            /// This value is used to complete unqualified DNS hostnames. If you&#39;re using AmazonProvidedDNS in
            /// us-east-1, specify ec2. internal. If you&#39;re using AmazonProvidedDNS in another Region, specify
            /// region. compute. internal (for example, ap-northeast-1. compute. internal). Otherwise, specify a
            /// domain name (for example, MyCompany. com).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// DomainNameServers
            /// The IPv4 addresses of up to four domain name servers, or AmazonProvidedDNS. The default DHCP option
            /// set specifies AmazonProvidedDNS. If specifying more than one domain name server, specify the IP
            /// addresses in a single parameter, separated by commas. To have your instance to receive a custom DNS
            /// hostname as specified in DomainName, you must set this to a custom DNS server.
            /// Required: Conditional
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> DomainNameServers { get; set; }

            /// <summary>
            /// NetbiosNameServers
            /// The IPv4 addresses of up to four NetBIOS name servers.
            /// Required: Conditional
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> NetbiosNameServers { get; set; }

            /// <summary>
            /// NetbiosNodeType
            /// The NetBIOS node type (1, 2, 4, or 8). We recommend that you specify 2 (broadcast and multicast are
            /// not currently supported).
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
            public Union<int, IntrinsicFunction> NetbiosNodeType { get; set; }

            /// <summary>
            /// NtpServers
            /// The IPv4 addresses of up to four Network Time Protocol (NTP) servers.
            /// Required: Conditional
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> NtpServers { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// Any tags assigned to the DHCP options set.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EC2::DHCPOptions";

        public DHCPOptionsProperties Properties { get; } = new DHCPOptionsProperties();

    }
}
