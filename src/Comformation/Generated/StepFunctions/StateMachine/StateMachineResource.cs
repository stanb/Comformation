using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.StateMachine
{
    /// <summary>
    /// AWS::StepFunctions::StateMachine
    /// Provisions a state machine. A state machine consists of a collection of states that can do work (Task states),
    /// determine to which states to transition next (Choice states), stop an execution with an error (Fail states),
    /// and so on. State machines are specified using a JSON-based, structured language.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html
    /// </summary>
    public class StateMachineResource : ResourceBase
    {
        public class StateMachineProperties
        {
            /// <summary>
            /// DefinitionString
            /// The Amazon States Language definition of the state machine. See Amazon States Language.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefinitionString { get; set; }

            /// <summary>
            /// StateMachineName
            /// The name of the state machine.
            /// A name must not contain:
            /// white space brackets &amp;lt; &amp;gt; { } [ ] wildcard characters ? * special characters &quot; # % \ ^ | ~ ` $
            /// &amp;amp; , ; : / control characters (U+0000-001F, U+007F-009F)
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> StateMachineName { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role to use for this state machine.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// The list of tags to add to a resource.
            /// Tags may only contain Unicode letters, digits, white space, or these symbols: _ . : / = + - @.
            /// Required: No
            /// Type: List of TagsEntry
            /// Update requires: No interruption
            /// </summary>
			public List<TagsEntry> Tags { get; set; }

        }

        public string Type { get; } = "AWS::StepFunctions::StateMachine";

        public StateMachineProperties Properties { get; } = new StateMachineProperties();

    }

	public static class StateMachineAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
