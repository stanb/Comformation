using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFRegional.RateBasedRule
{
    /// <summary>
    /// AWS::WAFRegional::RateBasedRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ratebasedrule.html
    /// </summary>
    public class RateBasedRuleResource : ResourceBase
    {
        public class RateBasedRuleProperties
        {
            /// <summary>
            /// MetricName
            /// A friendly name or description for the metrics for a RateBasedRule. The name can contain only
            /// alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128 and minimum length one. It can&#39;t
            /// contain whitespace or metric names reserved for AWS WAF, including &quot;All&quot; and &quot;Default_Action. &quot; You
            /// can&#39;t change the name of the metric after you create the RateBasedRule.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> MetricName { get; set; }

            /// <summary>
            /// RateLimit
            /// The maximum number of requests, which have an identical value in the field specified by the RateKey,
            /// allowed in a five-minute period. If the number of requests exceeds the RateLimit and the other
            /// predicates specified in the rule are also met, AWS WAF triggers the action that is specified for
            /// this rule.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> RateLimit { get; set; }

            /// <summary>
            /// MatchPredicates
            /// The Predicates object contains one Predicate element for each ByteMatchSet, IPSet, or
            /// SqlInjectionMatchSet&amp;gt; object that you want to include in a RateBasedRule.
            /// Required: No
            /// Type: List of Predicate
            /// Update requires: No interruption
            /// </summary>
            public List<Predicate> MatchPredicates { get; set; }

            /// <summary>
            /// RateKey
            /// The field that AWS WAF uses to determine if requests are likely arriving from single source and thus
            /// subject to rate monitoring. The only valid value for RateKey is IP. IP indicates that requests
            /// arriving from the same IP address are subject to the RateLimit that is specified in the
            /// RateBasedRule.
            /// Required: Yes
            /// Type: String
            /// Allowed values: IP
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RateKey { get; set; }

            /// <summary>
            /// Name
            /// A friendly name or description for a RateBasedRule. You can&#39;t change the name of a RateBasedRule
            /// after you create it.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::WAFRegional::RateBasedRule";

        public RateBasedRuleProperties Properties { get; } = new RateBasedRuleProperties();

    }
}
