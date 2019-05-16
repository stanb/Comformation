using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule
    /// Specifies a receipt rule.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html
    /// </summary>
    public class ReceiptRuleResource : ResourceBase
    {
        public class ReceiptRuleProperties
        {
            /// <summary>
            /// After
            /// The name of the existing rule that you want to place the current rule after. If this parameter is
            /// null, the new rule is added as the first entry in the receipt rule set.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> After { get; set; }

            /// <summary>
            /// Rule
            /// A data structure that contains the specified rule&#39;s name, actions, recipients, domains, enabled
            /// status, scan status, and TLS policy.
            /// Required: Yes
            /// Type: Rule
            /// Update requires: No interruption
            /// </summary>
			public Rule Rule { get; set; }

            /// <summary>
            /// RuleSetName
            /// The name of the rule set that you want to add the receipt rule to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RuleSetName { get; set; }

        }

        public string Type { get; } = "AWS::SES::ReceiptRule";

        public ReceiptRuleProperties Properties { get; } = new ReceiptRuleProperties();

    }
}
