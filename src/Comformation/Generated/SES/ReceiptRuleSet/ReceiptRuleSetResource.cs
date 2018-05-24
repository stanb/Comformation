using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRuleSet
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptruleset.html
    /// </summary>
    public class ReceiptRuleSetResource : ResourceBase
    {
        public class ReceiptRuleSetProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptruleset.html#cfn-ses-receiptruleset-rulesetname
            /// </summary>
			public Union<string, IntrinsicFunction> RuleSetName { get; set; }

        }
    
        public string Type { get; } = "AWS::SES::ReceiptRuleSet";
        
        public ReceiptRuleSetProperties Properties { get; } = new ReceiptRuleSetProperties();
    }
}
