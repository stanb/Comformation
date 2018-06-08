using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule
    /// The AWS::Events::Rule resource creates a rule that matches incoming Amazon CloudWatch Events (CloudWatch
    /// Events) events and routes them to one or more targets for processing. For more information, see Using
    /// CloudWatch Events in the Amazon CloudWatch User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html
    /// </summary>
    public class RuleResource : ResourceBase
    {
        public class RuleProperties
        {
            /// <summary>
            /// Description
            /// A description of the rule's purpose.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EventPattern
            /// Describes which events CloudWatch Events routes to the specified target. These routed events are
            /// matched events. For more information, see Events and Event Patterns in the Amazon CloudWatch User
            /// Guide.
            /// Required: Conditional. You must specify this property, the ScheduleExpression property, or both.
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> EventPattern { get; set; }

            /// <summary>
            /// Name
            /// A name for the rule. If you don't specify a name, AWS CloudFormation generates a unique physical ID
            /// and uses that ID for the rule name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoleArn
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// ScheduleExpression
            /// The schedule or rate (frequency) that determines when CloudWatch Events runs the rule. For more
            /// information, see Schedule Expression Syntax for Rules in the Amazon CloudWatch User Guide.
            /// Required: Conditional. You must specify this property, the EventPattern property, or both.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

            /// <summary>
            /// State
            /// Indicates whether the rule is enabled. For valid values, see the State parameter for the PutRule
            /// action in the Amazon CloudWatch Events API Reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// Targets
            /// The resources, such as Lambda functions or Kinesis streams, that CloudWatch Events routes events to
            /// and invokes when the rule is triggered. For information about valid targets, see the PutTargets
            /// action in the Amazon CloudWatch Events API Reference.
            /// Note Creating rules with built-in targets is supported only in the AWS Management Console.
            /// Required: No
            /// Type: List of Amazon CloudWatch Events Rule Target
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Target>, IntrinsicFunction> Targets { get; set; }

        }
    
        public string Type { get; } = "AWS::Events::Rule";
        
        public RuleProperties Properties { get; } = new RuleProperties();
    }

	public static class RuleAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
