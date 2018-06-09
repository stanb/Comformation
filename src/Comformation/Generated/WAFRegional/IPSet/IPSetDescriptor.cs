using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.IPSet
{
    /// <summary>
    /// AWS WAF Regional IPSet IPSetDescriptors
    /// IPSetDescriptors is a property of the AWS::WAFRegional::IPSet resource that specifies the IP address type and
    /// IP address range (in CIDR notation) from which web requests originate.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ipset-ipsetdescriptors.html
    /// </summary>
    public class IPSetDescriptor
    {

        /// <summary>
        /// Type
        /// The IP address type, such as IPV4. For valid values, see the Type contents of the IPSetDescriptor
        /// data type in the AWS WAF Regional API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Value
        /// An IP address (in CIDR notation) that AWS WAF permits, blocks, or counts. For example, to specify a
        /// single IP address such as 192. 0. 2. 44, specify 192. 0. 2. 44/32. To specify a range of IP
        /// addresses such as 192. 0. 2. 0 to 192. 0. 2. 255, specify 192. 0. 2. 0/24.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
