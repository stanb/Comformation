using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRuleSet
{
    /// <summary>
    /// AWS::SES::ReceiptRuleSet
    /// The AWS::SES::ReceiptRuleSet resource specifies an empty rule set for Amazon SES. For more information, see
    /// CreateReceiptRuleSet in the Amazon Simple Email Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptruleset.html
    /// </summary>
    public class ReceiptRuleSetResource : ResourceBase
    {
        public class ReceiptRuleSetProperties
        {
            /// <summary>
            /// RuleSetName
            /// The name of the rule set to create. The name must:
            /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). Start and end
            /// with a letter or number. Contain less than 64 characters.
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
