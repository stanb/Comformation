using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.Stack
{
    /// <summary>
    /// AWS::CloudFormation::Stack
    /// The AWS::CloudFormation::Stack type nests a stack as a resource in a top-level template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-stack.html
    /// </summary>
    public class StackResource : ResourceBase
    {
        public class StackProperties
        {
            /// <summary>
            /// NotificationARNs
            /// A list of existing Amazon SNS topics where notifications about stack events are sent.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> NotificationARNs { get; set; }

            /// <summary>
            /// Parameters
            /// The set of parameters passed to AWS CloudFormation when this nested stack is created.
            /// Note If you use the Ref function to pass a parameter value to a nested stack, comma-delimited list
            /// parameters must be of type String. In other words, you cannot pass values that are of type
            /// CommaDelimitedList to nested stacks.
            /// Required: Conditional (required if the nested stack requires input parameters).
            /// Type: AWS CloudFormation Stack Parameters
            /// Update requires: Whether an update causes interruptions depends on the resources that are being
            /// updated. An update never causes a nested stack to be replaced.
            /// </summary>
			public Dictionary<string, Union<string, IntrinsicFunction>> Parameters { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) to describe this stack.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption.
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// TemplateURL
            /// The URL of a template that specifies the stack that you want to create as a resource. Template files
            /// can use any extension, such as . json, . yaml, . template, or . txt. The template must be stored on
            /// an Amazon S3 bucket, so the URL must have the form: https://s3. amazonaws. com/. . . /TemplateName.
            /// extension
            /// Required: Yes
            /// Type: String
            /// Update requires: Whether an update causes interruptions depends on the resources that are being
            /// updated. An update never causes a nested stack to be replaced.
            /// </summary>
			public Union<string, IntrinsicFunction> TemplateURL { get; set; }

            /// <summary>
            /// TimeoutInMinutes
            /// The length of time, in minutes, that AWS CloudFormation waits for the nested stack to reach the
            /// CREATE_COMPLETE state. The default is no timeout. When AWS CloudFormation detects that the nested
            /// stack has reached the CREATE_COMPLETE state, it marks the nested stack resource as CREATE_COMPLETE
            /// in the parent stack and resumes creating the parent stack. If the timeout period expires before the
            /// nested stack reaches CREATE_COMPLETE, AWS CloudFormation marks the nested stack as failed and rolls
            /// back both the nested stack and parent stack.
            /// Required: No
            /// Type: Integer
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<int, IntrinsicFunction> TimeoutInMinutes { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::Stack";

        public StackProperties Properties { get; } = new StackProperties();

    }
}
