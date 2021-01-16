using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.IPSet
{
    /// <summary>
    /// AWS::WAFRegional::IPSet
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
            /// originate from.
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

        public string Type { get; } = "AWS::WAFRegional::IPSet";

        public IPSetProperties Properties { get; } = new IPSetProperties();

    }
}
