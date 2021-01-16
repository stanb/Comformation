using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRuleSet
{
    /// <summary>
    /// AWS::SES::ReceiptRuleSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptruleset.html
    /// </summary>
    public class ReceiptRuleSetResource : ResourceBase
    {
        public class ReceiptRuleSetProperties
        {
            /// <summary>
            /// RuleSetName
            /// The name of the receipt rule set that you want to reorder.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RuleSetName { get; set; }

        }

        public string Type { get; } = "AWS::SES::ReceiptRuleSet";

        public ReceiptRuleSetProperties Properties { get; } = new ReceiptRuleSetProperties();

    }
}
