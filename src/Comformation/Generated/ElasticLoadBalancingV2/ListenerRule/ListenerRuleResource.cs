using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule
    /// Specifies a listener rule.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html
    /// </summary>
    public class ListenerRuleResource : ResourceBase
    {
        public class ListenerRuleProperties
        {
            /// <summary>
            /// Actions
            /// The actions.
            /// Required: Yes
            /// Type: List of Action
            /// Update requires: No interruption
            /// </summary>
			public List<Action> Actions { get; set; }

            /// <summary>
            /// Conditions
            /// The conditions.
            /// Required: Yes
            /// Type: List of RuleCondition
            /// Update requires: No interruption
            /// </summary>
			public List<RuleCondition> Conditions { get; set; }

            /// <summary>
            /// ListenerArn
            /// The Amazon Resource Name (ARN) of the listener.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ListenerArn { get; set; }

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

        }

        public string Type { get; } = "AWS::ElasticLoadBalancingV2::ListenerRule";

        public ListenerRuleProperties Properties { get; } = new ListenerRuleProperties();

    }
}
