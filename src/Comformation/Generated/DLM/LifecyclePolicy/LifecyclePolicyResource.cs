using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy
    /// The AWS::DLM::LifecyclePolicy resource creates a lifecycle policy for Amazon Data Lifecycle Manager. For more
    /// information, see Automating the Amazon EBS Snapshot Lifecycle in the Amazon EC2 User Guide for Linux Instances
    /// and CreateLifecyclePolicy in the Amazon Data Lifecycle Manager API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html
    /// </summary>
    public class LifecyclePolicyResource : ResourceBase
    {
        public class LifecyclePolicyProperties
        {
            /// <summary>
            /// ExecutionRoleArn
            /// The Amazon Resource Name (ARN) of the IAM role used to run the operations specified by the lifecycle
            /// policy.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// Description
            /// The description of the lifecycle policy.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// State
            /// The activation state of the lifecycle policy.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// PolicyDetails
            /// The configuration of the lifecycle policy.
            /// Required: No
            /// Type: PolicyDetails
            /// Update requires: No interruption
            /// </summary>
			public PolicyDetails PolicyDetails { get; set; }

        }

        public string Type { get; } = "AWS::DLM::LifecyclePolicy";

        public LifecyclePolicyProperties Properties { get; } = new LifecyclePolicyProperties();

    }

	public static class LifecyclePolicyAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
