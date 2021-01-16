using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.Macro
{
    /// <summary>
    /// AWS::CloudFormation::Macro
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html
    /// </summary>
    public class MacroResource : ResourceBase
    {
        public class MacroProperties
        {
            /// <summary>
            /// Description
            /// A description of the macro.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// FunctionName
            /// The Amazon Resource Name (ARN) of the underlying AWS Lambda function that you want AWS
            /// CloudFormation to invoke when the macro is run.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// LogGroupName
            /// The Amazon CloudWatch log group to which AWS CloudFormation sends error logging information when
            /// invoking the macro&#39;s underlying AWS Lambda function.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LogGroupName { get; set; }

            /// <summary>
            /// LogRoleARN
            /// The ARN of the role AWS CloudFormation should assume when sending log entries to CloudWatch logs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LogRoleARN { get; set; }

            /// <summary>
            /// Name
            /// The name of the macro. The name of the macro must be unique across all macros in the account.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::Macro";

        public MacroProperties Properties { get; } = new MacroProperties();

    }
}
