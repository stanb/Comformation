using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html
    /// </summary>
    public class ReceiptRuleResource : ResourceBase
    {
        public class ReceiptRuleProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-after
            /// </summary>
			public Union<string, IntrinsicFunction> After { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-rule
            /// </summary>
			public Union<Rule, IntrinsicFunction> Rule { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-rulesetname
            /// </summary>
			public Union<string, IntrinsicFunction> RuleSetName { get; set; }

        }
    
        public string Type { get; } = "AWS::SES::ReceiptRule";
        
        public ReceiptRuleProperties Properties { get; } = new ReceiptRuleProperties();
    }
}
