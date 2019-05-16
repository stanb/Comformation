using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptFilter
{
    /// <summary>
    /// AWS::SES::ReceiptFilter
    /// Specify a new IP address filter. You use IP address filters when you receive email with Amazon SES. For more
    /// information, see the Amazon SES Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptfilter.html
    /// </summary>
    public class ReceiptFilterResource : ResourceBase
    {
        public class ReceiptFilterProperties
        {
            /// <summary>
            /// Filter
            /// A data structure that describes the IP address filter that you want to specify. This object consists
            /// of a name, an IP address range, and a boolean that indicates whether to allow or block mail from the
            /// IP range.
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
