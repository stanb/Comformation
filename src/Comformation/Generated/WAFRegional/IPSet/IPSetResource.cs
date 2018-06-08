using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.IPSet
{
    /// <summary>
    /// AWS::WAFRegional::IPSet
    /// The AWS::WAFRegional::IPSet resource creates an AWS WAF Regional IPSet that specifies which web requests to
    /// permit or block based on the IP addresses from which the requests originate. For more information, see
    /// CreateIPSet in the AWS WAF Regional API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ipset.html
    /// </summary>
    public class IPSetResource : ResourceBase
    {
        public class IPSetProperties
        {
            /// <summary>
            /// IPSetDescriptors
            /// The IP address type and IP address range (in CIDR notation) from which web requests originate. If
            /// you associate the IPSet with a web ACL that is associated with a Amazon CloudFront (CloudFront)
            /// distribution, this descriptor is the value of one of the following fields in the CloudFront access
            /// logs:
            /// c-ip If the viewer did not use an HTTP proxy or a load balancer to send the request x-forwarded-for
            /// If the viewer did use an HTTP proxy or a load balancer to send the request
            /// Required: No
            /// Type: List of AWS WAF Regional IPSet IPSetDescriptors
            /// Update requires: No interruption
            /// </summary>
			public Union<List<IPSetDescriptor>, IntrinsicFunction> IPSetDescriptors { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the IPSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::WAFRegional::IPSet";
        
        public IPSetProperties Properties { get; } = new IPSetProperties();
    }
}
