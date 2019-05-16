using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptFilter
{
    /// <summary>
    /// AWS::SES::ReceiptFilter IpFilter
    /// Receipt IP address filters enable you to specifically accept or reject incoming email that originates from an
    /// IP address or range of IP addresses.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-ipfilter.html
    /// </summary>
    public class IpFilter
    {

        /// <summary>
        /// Policy
        /// Indicates whether to block or allow incoming mail from the specified IP addresses.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Policy")]
        public Union<string, IntrinsicFunction> Policy { get; set; }

        /// <summary>
        /// Cidr
        /// An IP address or a range of IP addresses that you want to block or allow, specified in Classless
        /// Inter-Domain Routing (CIDR) notation. An example of a single email address is 10. 0. 0. 1. An
        /// example of a range of IP addresses is 10. 0. 0. 1/24. For more information about CIDR notation, see
        /// RFC 2317.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cidr")]
        public Union<string, IntrinsicFunction> Cidr { get; set; }

    }
}
