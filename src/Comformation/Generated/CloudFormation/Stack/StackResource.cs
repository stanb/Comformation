using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.Stack
{
    /// <summary>
    /// AWS::CloudFormation::Stack
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stack.html
    /// </summary>
    public class StackResource : ResourceBase
    {
        public class StackProperties
        {
            /// <summary>
            /// NotificationARNs
            /// The Simple Notification Service (SNS) topic ARNs to publish stack related events. You can find your
            /// SNS topic ARNs using the SNS console or your Command Line Interface (CLI).
            /// Required: No
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> NotificationARNs { get; set; }

            /// <summary>
            /// Parameters
            /// The set value pairs that represent the parameters passed to CloudFormation when this nested stack is
            /// created. Each parameter has a name corresponding to a parameter defined in the embedded template and
            /// a value representing the value that you want to set for the parameter.
            /// Note If you use the Ref function to pass a parameter value to a nested stack, comma-delimited list
            /// parameters must be of type String. In other words, you cannot pass values that are of type
            /// CommaDelimitedList to nested stacks.
            /// Conditional. Required if the nested stack requires input parameters.
            /// Whether an update causes interruptions depends on the resources that are being updated. An update
            /// never causes a nested stack to be replaced.
            /// Required: Conditional
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// Key-value pairs to associate with this stack. AWS CloudFormation also propagates these tags to the
            /// resources created in the stack. A maximum number of 50 tags can be specified.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TemplateURL
            /// Location of file containing the template body. The URL must point to a template (max size: 460,800
            /// bytes) that is located in an Amazon S3 bucket. For more information, see Template anatomy.
            /// Whether an update causes interruptions depends on the resources that are being updated. An update
            /// never causes a nested stack to be replaced.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateURL { get; set; }

            /// <summary>
            /// TimeoutInMinutes
            /// The length of time, in minutes, that CloudFormation waits for the nested stack to reach the
            /// CREATE_COMPLETE state. The default is no timeout. When CloudFormation detects that the nested stack
            /// has reached the CREATE_COMPLETE state, it marks the nested stack resource as CREATE_COMPLETE in the
            /// parent stack and resumes creating the parent stack. If the timeout period expires before the nested
            /// stack reaches CREATE_COMPLETE, CloudFormation marks the nested stack as failed and rolls back both
            /// the nested stack and parent stack.
            /// Updates are not supported.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> TimeoutInMinutes { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::Stack";

        public StackProperties Properties { get; } = new StackProperties();

    }
}
