using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticLoadBalancingV2.ListenerRule
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html
    /// </summary>
    public class ListenerRuleResource : ResourceBase
    {
        public class ListenerRuleProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-actions
            /// </summary>
			public Union<List<Action>, IntrinsicFunction> Actions { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-conditions
            /// </summary>
			public Union<List<RuleCondition>, IntrinsicFunction> Conditions { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-listenerarn
            /// </summary>
			public Union<string, IntrinsicFunction> ListenerArn { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-priority
            /// </summary>
			public Union<int, IntrinsicFunction> Priority { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticLoadBalancingV2::ListenerRule";
        
        public ListenerRuleProperties Properties { get; } = new ListenerRuleProperties();
    }
}
