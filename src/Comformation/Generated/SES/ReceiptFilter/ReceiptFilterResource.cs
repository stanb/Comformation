using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptFilter
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptfilter.html
    /// </summary>
    public class ReceiptFilterResource : ResourceBase
    {
        public class ReceiptFilterProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptfilter.html#cfn-ses-receiptfilter-filter
            /// </summary>
			public Union<Filter, IntrinsicFunction> Filter { get; set; }

        }
    
        public string Type { get; } = "AWS::SES::ReceiptFilter";
        
        public ReceiptFilterProperties Properties { get; } = new ReceiptFilterProperties();
    }
}
