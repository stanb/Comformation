using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.WebACL
{
    /// <summary>
    /// AWS::WAFv2::WebACL Rule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-rule.html
    /// </summary>
    public class Rule
    {

        /// <summary>
        /// Name
        /// The descriptive name of the rule. You can&#39;t change the name of a Rule after you create it.
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
        /// Type: Statement
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Statement")]
        public Statement Statement { get; set; }

        /// <summary>
        /// Action
        /// The action that AWS WAF should take on a web request when it matches the rule&#39;s statement. Settings
        /// at the web ACL level can override the rule action setting.
        /// This is used only for rules whose statements don&#39;t reference a rule group. Rule statements that
        /// reference a rule group are RuleGroupReferenceStatement and ManagedRuleGroupStatement.
        /// You must set either this Action setting or the rule&#39;s OverrideAction, but not both:
        /// If the rule statement doesn&#39;t reference a rule group, you must set this rule action setting and you
        /// must not set the rule&#39;s override action setting. If the rule statement references a rule group, you
        /// must not set this action setting, because the actions are already set on the rules inside the rule
        /// group. You must set the rule&#39;s override action setting to indicate specifically whether to override
        /// the actions that are set on the rules in the rule group.
        /// Required: Conditional
        /// Type: RuleAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public RuleAction Action { get; set; }

        /// <summary>
        /// OverrideAction
        /// The override action to apply to the rules in a rule group, instead of the individual rule action
        /// settings. This is used only for rules whose statements reference a rule group. Rule statements that
        /// reference a rule group are RuleGroupReferenceStatement and ManagedRuleGroupStatement.
        /// Set the override action to none to leave the rule group rule actions in effect. Set it to count to
        /// only count matches, regardless of the rule action settings.
        /// You must set either this OverrideAction setting or the Action setting, but not both:
        /// If the rule statement references a rule group, you must set this override action setting and you
        /// must not set the rule&#39;s action setting. If the rule statement doesn&#39;t reference a rule group, you
        /// must set the rule action setting and you must not set the rule&#39;s override action setting.
        /// Required: Conditional
        /// Type: OverrideAction
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OverrideAction")]
        public OverrideAction OverrideAction { get; set; }

        /// <summary>
        /// RuleLabels
        /// Labels to apply to web requests that match the rule match statement. AWS WAF applies fully qualified
        /// labels to matching web requests. A fully qualified label is the concatenation of a label namespace
        /// and a rule label. The rule&#39;s rule group or web ACL defines the label namespace.
        /// Rules that run after this rule in the web ACL can match against these labels using a
        /// LabelMatchStatement.
        /// For each label, provide a case-sensitive string containing optional namespaces and a label name,
        /// according to the following guidelines:
        /// Separate each component of the label with a colon. Each namespace or name can have up to 128
        /// characters. You can specify up to 5 namespaces in a label. Don&#39;t use the following reserved words in
        /// your label specification: aws, waf, managed, rulegroup, webacl, regexpatternset, or ipset.
        /// For example, myLabelName or nameSpace1:nameSpace2:myLabelName.
        /// Required: No
        /// Type: List of Label
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RuleLabels")]
        public List<Label> RuleLabels { get; set; }

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
