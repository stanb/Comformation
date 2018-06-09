using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptFilter
{
    /// <summary>
    /// AWS::SES::ReceiptFilter
    /// The AWS::SES::ReceiptFilter resource whether to accept or reject mail originating from an IP address or range
    /// of IP addresses for Amazon SES. For more information, see Creating IP Address Filters for Amazon SES Email
    /// Receiving in the Amazon Simple Email Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptfilter.html
    /// </summary>
    public class ReceiptFilterResource : ResourceBase
    {
        public class ReceiptFilterProperties
        {
            /// <summary>
            /// Filter
            /// The IP addresses to block or allow, and whether to block or allow incoming mail from them.
            /// Required: Yes
            /// Type: Amazon SES ReceiptFilter Filter
            /// Update requires: Replacement
            /// </summary>
			public Union<Filter, IntrinsicFunction> Filter { get; set; }

        }
    
        public string Type { get; } = "AWS::SES::ReceiptFilter";
        
        public ReceiptFilterProperties Properties { get; } = new ReceiptFilterProperties();
    }
}
