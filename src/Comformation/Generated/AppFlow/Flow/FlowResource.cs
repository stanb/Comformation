using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html
    /// </summary>
    public class FlowResource : ResourceBase
    {
        public class FlowProperties
        {
            /// <summary>
            /// FlowName
            /// The specified name of the flow. Spaces are not allowed. Use underscores (_) or hyphens (-) only.
            /// Required: Yes
            /// Type: String
            /// Maximum: 256
            /// Pattern: [a-zA-Z0-9][\w!@#. -]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FlowName { get; set; }

            /// <summary>
            /// Description
            /// A user-entered description of the flow.
            /// Required: No
            /// Type: String
            /// Maximum: 2048
            /// Pattern: [\w!@#\-. ?,\s]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// KMSArn
            /// The ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide for encryption.
            /// This is required if you do not want to use the Amazon AppFlow-managed KMS key. If you don&#39;t provide
            /// anything here, Amazon AppFlow uses the Amazon AppFlow-managed KMS key.
            /// Required: No
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: arn:aws:kms:. *:[0-9]+:. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KMSArn { get; set; }

            /// <summary>
            /// TriggerConfig
            /// The trigger settings that determine how and when Amazon AppFlow runs the specified flow.
            /// Required: Yes
            /// Type: TriggerConfig
            /// Update requires: No interruption
            /// </summary>
            public TriggerConfig TriggerConfig { get; set; }

            /// <summary>
            /// SourceFlowConfig
            /// Contains information about the configuration of the source connector used in the flow.
            /// Required: Yes
            /// Type: SourceFlowConfig
            /// Update requires: No interruption
            /// </summary>
            public SourceFlowConfig SourceFlowConfig { get; set; }

            /// <summary>
            /// DestinationFlowConfigList
            /// The configuration that controls how Amazon AppFlow places data in the destination connector.
            /// Required: Yes
            /// Type: List of DestinationFlowConfig
            /// Update requires: No interruption
            /// </summary>
            public List<DestinationFlowConfig> DestinationFlowConfigList { get; set; }

            /// <summary>
            /// Tasks
            /// A list of tasks that Amazon AppFlow performs while transferring the data in the flow run.
            /// Required: Yes
            /// Type: List of Task
            /// Update requires: No interruption
            /// </summary>
            public List<Task> Tasks { get; set; }

            /// <summary>
            /// Tags
            /// The tags used to organize, track, or control access for your flow.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::AppFlow::Flow";

        public FlowProperties Properties { get; } = new FlowProperties();

    }

    public static class FlowAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FlowArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("FlowArn");
    }
}
