using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.RuleGroup
{
    /// <summary>
    /// AWS::WAFv2::RuleGroup Rule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// Name
        /// A friendly name of the rule. You can&#39;t change the name of a Rule after you create it.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[\w\-]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Priority
        /// If you define more than one Rule in a WebACL, AWS WAF evaluates each request against the Rules in
        /// order based on the value of Priority. AWS WAF processes rules with lower priority first. The
        /// priorities don&#39;t need to be consecutive, but they must all be different.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Priority")]
        public Union<int, IntrinsicFunction> Priority { get; set; }

        /// <summary>
        /// Statement
        /// The AWS WAF processing statement for the rule, for example ByteMatchStatement or
        /// SizeConstraintStatement.
        /// Required: Yes
        /// Type: StatementOne
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statement")]
        public StatementOne Statement { get; set; }

        /// <summary>
        /// Action
        /// The action that AWS WAF should take on a web request when it matches the rule&#39;s statement. Settings
        /// at the web ACL level can override the rule action setting.
        /// Required: No
        /// Type: RuleAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public RuleAction Action { get; set; }

        /// <summary>
        /// VisibilityConfig
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection.
        /// Required: Yes
        /// Type: VisibilityConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VisibilityConfig")]
        public VisibilityConfig VisibilityConfig { get; set; }

    }
}
