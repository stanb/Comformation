using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule
    /// The AWS::Events::Rule resource creates a rule that matches incoming events and routes them to one or more
    /// targets for processing. For more information, see What Is Amazon Eventbridge?.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html
    /// </summary>
    public class RuleResource : ResourceBase
    {
        public class RuleProperties
        {
            /// <summary>
            /// Description
            /// The description of the rule.
            /// Required: No
            /// Type: String
            /// Maximum: 512
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EventPattern
            /// Describes which events are routed to the specified target. For more information, see Events and
            /// Event Patterns in EventBridge in the Amazon EventBridge User Guide.
            /// When using CloudFormation, you must enclose each part of the event pattern in square brackets, as
            /// follows:
            /// &quot;EventPattern&quot;: { &quot;source&quot;: [ &quot;aws. ec2&quot; ], &quot;detail-type&quot;: [ &quot;EC2 Instance State-change
            /// Notification&quot; ] }
            /// A rule must contain either EventPattern or ScheduleExpression.
            /// Required: Conditional
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> EventPattern { get; set; }

            /// <summary>
            /// Name
            /// The name of the rule. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID
            /// and uses that ID for the rule name.
            /// Important If you specify a name, you can&#39;t perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 64
            /// Pattern: [\. \-_A-Za-z0-9]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the role that is used for target invocation.
            /// If you&#39;re setting an event bus in another account as the target and that account granted permission
            /// to your account through an organization instead of directly by the account ID, you must specify a
            /// RoleArn with proper permissions in the Target structure, instead of here in this parameter.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1600
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// ScheduleExpression
            /// The scheduling expression that determines when and how often the rule runs. For more information,
            /// see Schedule Expressions for Rules.
            /// A rule must contain either ScheduleExpression or EventPattern.
            /// Required: Conditional
            /// Type: String
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

            /// <summary>
            /// State
            /// Indicates whether the rule is enabled.
            /// Required: No
            /// Type: String
            /// Allowed Values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// Targets
            /// The AWS resources that are invoked when the rule is triggered. For information about valid targets,
            /// see PutTargets.
            /// If you&#39;re setting the event bus of another account as the target and that account granted permission
            /// to your account through an organization instead of directly by the account ID, you must specify a
            /// RoleArn with proper permissions in the Target structure. For more information, see Sending and
            /// Receiving Events Between AWS Accounts in the Amazon EventBridge User Guide.
            /// Required: No
            /// Type: List of Target
            /// Update requires: No interruption
            /// </summary>
			public List<Target> Targets { get; set; }

        }

        public string Type { get; } = "AWS::Events::Rule";

        public RuleProperties Properties { get; } = new RuleProperties();

    }

	public static class RuleAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
