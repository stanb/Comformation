using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html
    /// </summary>
    public class ListenerRuleResource : ResourceBase
    {
        public class ListenerRuleProperties
        {
            /// <summary>
            /// ListenerArn
            /// The Amazon Resource Name (ARN) of the listener.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ListenerArn { get; set; }

            /// <summary>
            /// Actions
            /// The actions.
            /// The rule must include exactly one of the following types of actions: forward, fixed-response, or
            /// redirect, and it must be the last action to be performed. If the rule is for an HTTPS listener, it
            /// can also optionally include an authentication action.
            /// Required: Yes
            /// Type: List of Action
            /// Update requires: No interruption
            /// </summary>
            public List<Action> Actions { get; set; }

            /// <summary>
            /// Priority
            /// The rule priority. A listener can&#39;t have multiple rules with the same priority.
            /// If you try to reorder rules by updating their priorities, do not specify a new priority if an
            /// existing rule already uses this priority, as this can cause an error. If you need to reuse a
            /// priority with a different rule, you must remove it as a priority first, and then specify it in a
            /// subsequent update.
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 50000
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Priority { get; set; }

            /// <summary>
            /// Conditions
            /// The conditions.
            /// The rule can optionally include up to one of each of the following conditions: http-request-method,
            /// host-header, path-pattern, and source-ip. A rule can also optionally include one or more of each of
            /// the following conditions: http-header and query-string.
            /// Required: Yes
            /// Type: List of RuleCondition
            /// Update requires: No interruption
            /// </summary>
            public List<RuleCondition> Conditions { get; set; }

        }

        public string Type { get; } = "AWS::ElasticLoadBalancingV2::ListenerRule";

        public ListenerRuleProperties Properties { get; } = new ListenerRuleProperties();

    }

    public static class ListenerRuleAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RuleArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("RuleArn");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> IsDefault = new ResourceAttribute<Union<bool, IntrinsicFunction>>("IsDefault");
    }
}
