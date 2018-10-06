using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule
    /// The AWS::SES::ReceiptRule resource specifies which actions Amazon SES should take when it receives mail on
    /// behalf of one or more email addresses or domains that you own. For more information, see Creating Receipt
    /// Rules for Amazon SES Email Receiving in the Amazon Simple Email Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html
    /// </summary>
    public class ReceiptRuleResource : ResourceBase
    {
        public class ReceiptRuleProperties
        {
            /// <summary>
            /// After
            /// The name of an existing rule after which the new rule will be placed. If this parameter is null, the
            /// new rule will be inserted at the beginning of the rule list.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> After { get; set; }

            /// <summary>
            /// Rule
            /// The specified rule&#39;s name, actions, recipients, domains, enabled status, scan status, and TLS
            /// policy.
            /// Required: Yes
            /// Type: Amazon SES ReceiptRule Rule
            /// Update requires: No interruption
            /// </summary>
			public Rule Rule { get; set; }

            /// <summary>
            /// RuleSetName
            /// The name of the rule set that the receipt rule will be added to.
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
