using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.StepFunctions.StateMachine
{
    /// <summary>
    /// AWS::StepFunctions::StateMachine
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html
    /// </summary>
    public class StateMachineResource : ResourceBase
    {
        public class StateMachineProperties
        {
            /// <summary>
            /// DefinitionString
            /// The Amazon States Language definition of the state machine. The state machine definition must be in
            /// JSON. See Amazon States Language.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefinitionString { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role to use for this state machine.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// StateMachineName
            /// The name of the state machine.
            /// A name must not contain:
            /// white space brackets &amp;lt; &amp;gt; { } [ ] wildcard characters ? * special characters &quot; # % \ ^ | ~ ` $
            /// &amp;amp; , ; : / control characters (U+0000-001F, U+007F-009F)
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StateMachineName { get; set; }

            /// <summary>
            /// StateMachineType
            /// Determines whether a STANDARD or EXPRESS state machine is created. The default is STANDARD. You
            /// cannot update the type of a state machine once it has been created. For more information on STANDARD
            /// and EXPRESS workflows, see Standard Versus Express Workflows in the AWS Step Functions Developer
            /// Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> StateMachineType { get; set; }

            /// <summary>
            /// LoggingConfiguration
            /// Defines what execution history events are logged and where they are logged.
            /// Note By default, the level is set to OFF. For more information see Log Levels in the AWS Step
            /// Functions User Guide.
            /// Required: No
            /// Type: LoggingConfiguration
            /// Update requires: No interruption
            /// </summary>
            public LoggingConfiguration LoggingConfiguration { get; set; }

            /// <summary>
            /// TracingConfiguration
            /// Selects whether or not the state machine&#39;s AWS X-Ray tracing is enabled.
            /// Required: No
            /// Type: TracingConfiguration
            /// Update requires: No interruption
            /// </summary>
            public TracingConfiguration TracingConfiguration { get; set; }

            /// <summary>
            /// DefinitionS3Location
            /// The name of the S3 bucket where the state machine definition is stored. The state machine definition
            /// must be a JSON or YAML file.
            /// Required: No
            /// Type: S3Location
            /// Update requires: No interruption
            /// </summary>
            public S3Location DefinitionS3Location { get; set; }

            /// <summary>
            /// DefinitionSubstitutions
            /// A map (string to string) that specifies the mappings for placeholder variables in the state machine
            /// definition. This enables the customer to inject values obtained at runtime, for example from
            /// intrinsic functions, in the state machine definition. Variables can be template parameter names,
            /// resource logical IDs, resource attributes, or a variable in a key-value map.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> DefinitionSubstitutions { get; set; }

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
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
