using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy
    /// Specifies a lifecycle policy, which is used to automate operations on Amazon EBS resources.
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
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// Description
            /// A description of the lifecycle policy. The characters ^[0-9A-Za-z _-]+$ are supported.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 0
            /// Maximum: 500
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// State
            /// The activation state of the lifecycle policy.
            /// Required: Conditional
            /// Type: String
            /// Allowed Values: DISABLED | ENABLED | ERROR
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// PolicyDetails
            /// The configuration details of the lifecycle policy.
            /// Required: Conditional
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
