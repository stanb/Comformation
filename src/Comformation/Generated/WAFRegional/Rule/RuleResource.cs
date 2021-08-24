using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.Rule
{
    /// <summary>
    /// AWS::WAFRegional::Rule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-rule.html
    /// </summary>
    public class RuleResource : ResourceBase
    {
        public class RuleProperties
        {
            /// <summary>
            /// MetricName
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// Predicates
            /// The Predicates object contains one Predicate element for each ByteMatchSet, IPSet, or
            /// SqlInjectionMatchSet object that you want to include in a Rule.
            /// 	
            /// Required: No
            /// Type: List of Predicate
            /// Update requires: No interruption
            /// </summary>
            public List<Predicate> Predicates { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// The friendly name or description for the Rule. You can&#39;t change the name of a Rule after you create
            /// it.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::Rule";

        public RuleProperties Properties { get; } = new RuleProperties();

    }
}
