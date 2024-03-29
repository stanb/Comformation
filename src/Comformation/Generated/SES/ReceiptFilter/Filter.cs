using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptFilter
{
    /// <summary>
    /// AWS::SES::ReceiptFilter Filter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-filter.html
    /// </summary>
    public class Filter
    {

        /// <summary>
        /// IpFilter
        /// A structure that provides the IP addresses to block or allow, and whether to block or allow incoming
        /// mail from them.
        /// Required: Yes
        /// Type: IpFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IpFilter")]
        public IpFilter IpFilter { get; set; }

        /// <summary>
        /// Name
        /// The name of the IP address filter. The name must meet the following requirements:
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). Start and end
        /// with a letter or number. Contain 64 characters or fewer.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
