using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptFilter
{
    /// <summary>
    /// AWS::SES::ReceiptFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptfilter.html
    /// </summary>
    public class ReceiptFilterResource : ResourceBase
    {
        public class ReceiptFilterProperties
        {
            /// <summary>
            /// Filter
            /// A data structure that describes the IP address filter to create, which consists of a name, an IP
            /// address range, and whether to allow or block mail from it.
            /// Required: Yes
            /// Type: Filter
            /// Update requires: Replacement
            /// </summary>
            public Filter Filter { get; set; }

        }

        public string Type { get; } = "AWS::SES::ReceiptFilter";

        public ReceiptFilterProperties Properties { get; } = new ReceiptFilterProperties();

    }
}
