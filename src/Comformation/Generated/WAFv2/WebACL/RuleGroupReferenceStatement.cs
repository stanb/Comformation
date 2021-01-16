using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL RuleGroupReferenceStatement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rulegroupreferencestatement.html
    /// </summary>
    public class RuleGroupReferenceStatement
    {

        /// <summary>
        /// Arn
        /// The Amazon Resource Name (ARN) of the entity.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// ExcludedRules
        /// The names of rules that are in the referenced rule group, but that you want AWS WAF to exclude from
        /// processing for this rule statement.
        /// Required: No
        /// Type: List of ExcludedRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExcludedRules")]
        public List<ExcludedRule> ExcludedRules { get; set; }

    }
}
