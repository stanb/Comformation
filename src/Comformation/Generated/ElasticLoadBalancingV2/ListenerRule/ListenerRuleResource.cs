using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    /// AWS::ElasticLoadBalancingV2::ListenerRule
    /// The AWS::ElasticLoadBalancingV2::ListenerRule resource defines the rules for a listener. For more information,
    /// see Listener Rules for Your Application Load Balancer in the User Guide for Application Load Balancers.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html
    /// </summary>
    public class ListenerRuleResource : ResourceBase
    {
        public class ListenerRuleProperties
        {
            /// <summary>
            /// Actions
            /// The actions that the listener takes when the specified conditions are met.
            /// Required: Yes
            /// Type: List of Elastic Load Balancing V2 Actions
            /// Update requires: No interruption
            /// </summary>
			public List<Action> Actions { get; set; }

            /// <summary>
            /// Conditions
            /// The conditions under which the rule takes effect.
            /// Required: Yes
            /// Type: List of Elastic Load Balancing V2 Conditions
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
            /// The priority for the rule. Elastic Load Balancing evaluates rules in priority order, from the lowest
            /// value to the highest value. If a request satisfies a rule, Elastic Load Balancing ignores all
            /// subsequent rules.
            /// Note A listener can&#39;t have multiple rules with the same priority.
            /// For the valid range of values, see the Priority parameter for the CreateRule action in the Elastic
            /// Load Balancing API Reference version 2015-12-01.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Priority { get; set; }

        }

        public string Type { get; } = "AWS::ElasticLoadBalancingV2::ListenerRule";

        public ListenerRuleProperties Properties { get; } = new ListenerRuleProperties();

    }
}
