using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.ComputeEnvironment
{
    /// <summary>
    /// AWS::Batch::ComputeEnvironment
    /// The AWS::Batch::ComputeEnvironment resource defines your AWS Batch compute environment. For more information,
    /// see Compute Environments in the AWS Batch User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html
    /// </summary>
    public class ComputeEnvironmentResource : ResourceBase
    {
        public class ComputeEnvironmentProperties
        {
            /// <summary>
            /// Type
            /// The type of the compute environment. For more information, see Compute Environments in the AWS Batch
            /// User Guide.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: MANAGED | UNMANAGED
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// ServiceRole
            /// The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make calls to other AWS
            /// services on your behalf.
            /// If your specified role has a path other than /, then you must either specify the full role ARN (this
            /// is recommended) or prefix the role name with the path.
            /// Note Depending on how you created your AWS Batch service role, its ARN may contain the service-role
            /// path prefix. When you only specify the name of the service role, AWS Batch assumes that your ARN
            /// does not use the service-role path prefix. Because of this, we recommend that you specify the full
            /// ARN of your service role when you create compute environments.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRole { get; set; }

            /// <summary>
            /// ComputeEnvironmentName
            /// The name for your compute environment. Up to 128 letters (uppercase and lowercase), numbers,
            /// hyphens, and underscores are allowed.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ComputeEnvironmentName { get; set; }

            /// <summary>
            /// ComputeResources
            /// The ComputeResources property type specifies details of the compute resources managed by the compute
            /// environment. This parameter is required for managed compute environments. For more information, see
            /// Compute Environments in the AWS Batch User Guide.
            /// Required: No
            /// Type: ComputeResources
            /// Update requires: No interruption
            /// </summary>
			public ComputeResources ComputeResources { get; set; }

            /// <summary>
            /// State
            /// The state of the compute environment. If the state is ENABLED, then the compute environment accepts
            /// jobs from a queue and can scale out automatically based on queues.
            /// Required: No
            /// Type: String
            /// Allowed Values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

        }

        public string Type { get; } = "AWS::Batch::ComputeEnvironment";

        public ComputeEnvironmentProperties Properties { get; } = new ComputeEnvironmentProperties();

    }
}
