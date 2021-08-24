using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html
    /// </summary>
    public class ReceiptRuleResource : ResourceBase
    {
        public class ReceiptRuleProperties
        {
            /// <summary>
            /// After
            /// The name of an existing rule after which the new rule is placed. If this parameter is null, the new
            /// rule is inserted at the beginning of the rule list.
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
            /// The name of the rule set where the receipt rule is added.
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
