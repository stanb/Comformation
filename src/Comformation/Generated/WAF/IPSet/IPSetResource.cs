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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-ipset.html
    /// </summary>
    public class IPSetResource : ResourceBase
    {
        public class IPSetProperties
        {
            /// <summary>
            /// x-forwarded-for
            /// If the viewer did use an HTTP proxy or a load balancer to send the request
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-ipset.html#cfn-waf-ipset-ipsetdescriptors
            /// </summary>
			public Union<List<IPSetDescriptor>, IntrinsicFunction> IPSetDescriptors { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the IPSet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-ipset.html#cfn-waf-ipset-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::WAF::IPSet";
        
        public IPSetProperties Properties { get; } = new IPSetProperties();
    }
}
