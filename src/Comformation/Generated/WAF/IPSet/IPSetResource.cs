using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.IPSet
{
    /// <summary>
    /// AWS::WAF::IPSet
    /// The AWS::WAF::IPSet resource creates an AWS WAF IPSet that specifies which web requests to permit or block
    /// based on the IP addresses from which the requests originate. For more information, see CreateIPSet in the AWS
    /// WAF API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-ipset.html
    /// </summary>
    public class IPSetResource : ResourceBase
    {
        public class IPSetProperties
        {
            /// <summary>
            /// IPSetDescriptors
            /// The IP address type and IP address range (in CIDR notation) from which web requests originate. If
            /// you associate the IPSet with a web ACL that is associated with an Amazon CloudFront (CloudFront)
            /// distribution and the viewer did not use an HTTP proxy or a load balancer to send the request, this
            /// descriptor is the value of the c-ip field in the CloudFront access logs.
            /// Required: No
            /// Type: List of AWS WAF IPSet IPSetDescriptors
            /// Update requires: No interruption
            /// </summary>
			public List<IPSetDescriptor> IPSetDescriptors { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the IPSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAF::IPSet";

        public IPSetProperties Properties { get; } = new IPSetProperties();

    }
}
