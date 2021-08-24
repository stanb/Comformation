using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAF.IPSet
{
    /// <summary>
    /// AWS::WAF::IPSet IPSetDescriptor
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-ipset-ipsetdescriptors.html
    /// </summary>
    public class IPSetDescriptor
    {

        /// <summary>
        /// Type
        /// 	
        /// Specify IPV4 or IPV6.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: IPV4 | IPV6
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// 		
        /// Specify an IPv4 address by using CIDR notation. For example:
        /// 		
        /// 			 			 		 To configure AWS WAF to allow, block, or count requests that originated from the IP
        /// address 192. 0. 2. 44, specify 192. 0. 2. 44/32. To configure AWS WAF to allow, block, or count
        /// requests that originated from IP addresses from 192. 0. 2. 0 to 192. 0. 2. 255, specify 				192. 0.
        /// 2. 0/24.
        /// 		 	
        /// For more information about CIDR notation, see the Wikipedia entry 	 Classless Inter-Domain Routing.
        /// 	
        /// Specify an IPv6 address by using CIDR notation. For example:
        /// 	
        /// 	 	 	 To configure AWS WAF to allow, block, or count requests that originated from the IP address
        /// 1111:0000:0000:0000:0000:0000:0000:0111, specify 1111:0000:0000:0000:0000:0000:0000:0111/128. 	 To
        /// configure AWS WAF to allow, block, or count requests that originated from IP addresses
        /// 1111:0000:0000:0000:0000:0000:0000:0000 to 1111:0000:0000:0000:ffff:ffff:ffff:ffff, specify
        /// 1111:0000:0000:0000:0000:0000:0000:0000/64. 	
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 50
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
