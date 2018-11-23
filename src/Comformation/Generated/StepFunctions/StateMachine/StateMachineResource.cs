using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.StateMachine
{
    /// <summary>
    /// AWS::StepFunctions::StateMachine
    /// Use the AWS::StepFunctions::StateMachine resource to create an AWS Step Functions state machine.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html
    /// </summary>
    public class StateMachineResource : ResourceBase
    {
        public class StateMachineProperties
        {
            /// <summary>
            /// DefinitionString
            /// The Amazon States Language definition of the state machine. For more information, see Amazon States
            /// Language in the AWS Step Functions Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefinitionString { get; set; }

            /// <summary>
            /// StateMachineName
            /// The name of the state machine. If you do not specify a name one will be generated that is similar to
            /// MyStateMachine-1234abcdefgh. For more information on creating a valid name see Request Parameters in
            /// the AWS Step Functions API Reference.
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

        }

        public string Type { get; } = "AWS::StepFunctions::StateMachine";

        public StateMachineProperties Properties { get; } = new StateMachineProperties();

    }

	public static class StateMachineAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
	}
}
