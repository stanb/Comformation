using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Route53RecoveryControl.SafetyRule
{
    /// <summary>
    /// AWS::Route53RecoveryControl::SafetyRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoverycontrol-safetyrule.html
    /// </summary>
    public class SafetyRuleResource : ResourceBase
    {
        public class SafetyRuleProperties
        {
            /// <summary>
            /// AssertionRule
            /// An assertion rule enforces that, when a routing control state is changed, that the criteria set by
            /// the rule configuration is met. 		Otherwise, the change to the routing control is not accepted.
            /// Required: No
            /// Type: AssertionRule
            /// Update requires: No interruption
            /// </summary>
            public AssertionRule AssertionRule { get; set; }

            /// <summary>
            /// GatingRule
            /// A gating rule verifies that a set of gating controls evaluates as true, based on a rule
            /// configuration that you specify. If the gating rule evaluates to true, Amazon Route 53 Application
            /// Recovery Controller allows 		a set of routing control state changes to run and complete against the
            /// set of target controls.
            /// Required: No
            /// Type: GatingRule
            /// Update requires: No interruption
            /// </summary>
            public GatingRule GatingRule { get; set; }

            /// <summary>
            /// Name
            /// The name of the assertion rule. You can use any non-white space character in the name.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ControlPanelArn
            /// The Amazon Resource Name (ARN) for the control panel.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ControlPanelArn { get; set; }

            /// <summary>
            /// RuleConfig
            /// The criteria that you set for specific assertion controls (routing controls) that designate 				how
            /// many controls must be enabled as the result of a transaction. For example, if you have three
            /// 				assertion controls, you might specify atleast 2 for your rule configuration. This means that at
            /// least two assertion controls must be enabled, so that at least two AWS Regions are enabled.
            /// Required: Yes
            /// Type: RuleConfig
            /// Update requires: Replacement
            /// </summary>
            public RuleConfig RuleConfig { get; set; }

        }

        public string Type { get; } = "AWS::Route53RecoveryControl::SafetyRule";

        public SafetyRuleProperties Properties { get; } = new SafetyRuleProperties();

    }

    public static class SafetyRuleAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SafetyRuleArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("SafetyRuleArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Status = new ResourceAttribute<Union<string, IntrinsicFunction>>("Status");
    }
}
