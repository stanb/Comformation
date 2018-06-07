using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.Rule
{
    /// <summary>
    /// AWS::WAFRegional::Rule
    /// The AWS::WAFRegional::Rule resource creates an AWS WAF Regional rule that specifies a combination of IPSet,
    /// ByteMatchSet, and SqlInjectionMatchSet objects that identify the web requests to allow, block, or count. To
    /// implement rules, you must associate them with a web ACL.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-rule.html
    /// </summary>
    public class RuleResource : ResourceBase
    {
        public class RuleProperties
        {
            /// <summary>
            /// MetricName
            /// A friendly name or description for the metrics of the rule. For valid values, see the MetricName
            /// parameter for the CreateRule action in the AWS WAF Regional API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-rule.html#cfn-wafregional-rule-metricname
            /// </summary>
			public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// Predicates
            /// The ByteMatchSet, IPSet, SizeConstraintSet, SqlInjectionMatchSet, or XssMatchSet objects to include
            /// in a rule. If you add more than one predicate to a rule, a request must match all conditions in
            /// order to be allowed or blocked.
            /// Required: No
            /// Type: List of AWS WAF Regional Rule Predicates
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-rule.html#cfn-wafregional-rule-predicates
            /// </summary>
			public Union<List<Predicate>, IntrinsicFunction> Predicates { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description of the rule.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-rule.html#cfn-wafregional-rule-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::WAFRegional::Rule";
        
        public RuleProperties Properties { get; } = new RuleProperties();
    }
}
