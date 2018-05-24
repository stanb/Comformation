using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.StateMachine
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html
    /// </summary>
    public class StateMachineResource : ResourceBase
    {
        public class StateMachineProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitionstring
            /// </summary>
			public Union<string, IntrinsicFunction> DefinitionString { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-statemachinename
            /// </summary>
			public Union<string, IntrinsicFunction> StateMachineName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-rolearn
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }
    
        public string Type { get; } = "AWS::StepFunctions::StateMachine";
        
        public StateMachineProperties Properties { get; } = new StateMachineProperties();
    }

	public static class StateMachineAttributes
	{
        public static readonly ResourceAttribute<string> Name = new ResourceAttribute<string>("Name");
	}
}
