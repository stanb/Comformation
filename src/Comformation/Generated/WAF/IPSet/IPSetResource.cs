using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.IPSet
{
    /// <summary>
    /// AWS::WAF::IPSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-ipset.html
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
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAF::IPSet";

        public IPSetProperties Properties { get; } = new IPSetProperties();

    }
}
