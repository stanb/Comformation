using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.IPSet
{
    /// <summary>
    /// AWS::WAFRegional::IPSet
    /// Contains one or more IP addresses or blocks of IP addresses specified in Classless Inter-Domain Routing (CIDR)
    /// notation. AWS WAF supports IPv4 address ranges: /8 and any range between /16 through /32. AWS WAF supports
    /// IPv6 address ranges: /24, /32, /48, /56, /64, and /128.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ipset.html
    /// </summary>
    public class IPSetResource : ResourceBase
    {
        public class IPSetProperties
        {
            /// <summary>
            /// IPSetDescriptors
            /// 		
            /// The IP address type (IPV4 or IPV6) and the IP address range (in CIDR notation) that web requests
            /// originate from. 			If the WebACL is associated with a CloudFront distribution and the viewer did not
            /// use an HTTP proxy or a load balancer to send the request, this is the value of the c-ip field in the
            /// CloudFront access logs.
            /// 			 	
            /// Required: No
            /// Type: List of IPSetDescriptor
            /// Update requires: No interruption
            /// </summary>
			public List<IPSetDescriptor> IPSetDescriptors { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the IPSet. You can&#39;t change the name of an IPSet after you create
            /// it.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::IPSet";

        public IPSetProperties Properties { get; } = new IPSetProperties();

    }
}
