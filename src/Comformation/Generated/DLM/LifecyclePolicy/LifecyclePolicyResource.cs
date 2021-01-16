using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DLM.LifecyclePolicy
{
    /// <summary>
    /// AWS::DLM::LifecyclePolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html
    /// </summary>
    public class LifecyclePolicyResource : ResourceBase
    {
        public class LifecyclePolicyProperties
        {
            /// <summary>
            /// ExecutionRoleArn
            /// 		
            /// The Amazon Resource Name (ARN) of the IAM role used to run the operations specified by 			the
            /// lifecycle policy.
            /// 	
            /// Required: Conditional
            /// Type: String
            /// Minimum: 0
            /// Maximum: 2048
            /// Pattern: arn:aws(-[a-z]{1,3}){0,2}:iam::\d+:role/. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// Description
            /// 		
            /// A description of the lifecycle policy. The characters ^[0-9A-Za-z _-]+$ are 			supported.
            /// 	
            /// Required: Conditional
            /// Type: String
            /// Minimum: 0
            /// Maximum: 500
            /// Pattern: [0-9A-Za-z _-]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// State
            /// 		
            /// The activation state of the lifecycle policy.
            /// 	
            /// Required: Conditional
            /// Type: String
            /// Allowed values: DISABLED | ENABLED | ERROR
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> State { get; set; }

            /// <summary>
            /// PolicyDetails
            /// 		
            /// The configuration details of the lifecycle policy.
            /// 	
            /// Required: Conditional
            /// Type: PolicyDetails
            /// Update requires: No interruption
            /// </summary>
            public PolicyDetails PolicyDetails { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// The tags to apply to the lifecycle policy during creation.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DLM::LifecyclePolicy";

        public LifecyclePolicyProperties Properties { get; } = new LifecyclePolicyProperties();

    }

    public static class LifecyclePolicyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
