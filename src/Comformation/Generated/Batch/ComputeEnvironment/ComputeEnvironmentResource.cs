using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.ComputeEnvironment
{
    /// <summary>
    /// AWS::Batch::ComputeEnvironment
    /// The AWS::Batch::ComputeEnvironment resource to define your AWS Batch compute environment. For more
    /// information, see Compute Environments in the AWS Batch User Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html
    /// </summary>
    public class ComputeEnvironmentResource : ResourceBase
    {
        public class ComputeEnvironmentProperties
        {
            /// <summary>
            /// Type
            /// The type of the compute environment.
            /// Required: yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-type
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// ServiceRole
            /// The service role associated with the compute environment that allows AWS Batch to make calls to AWS
            /// API operations on your behalf.
            /// Required: yes
            /// Type: String
            /// Update requires: No Interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-servicerole
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRole { get; set; }

            /// <summary>
            /// ComputeEnvironmentName
            /// The name of the compute environment.
            /// Required: no
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeenvironmentname
            /// </summary>
			public Union<string, IntrinsicFunction> ComputeEnvironmentName { get; set; }

            /// <summary>
            /// ComputeResources
            /// The compute resources defined for the compute environment.
            /// Required: yes
            /// Type: AWS Batch ComputeEnvironment ComputeResources
            /// Update requires: No Interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeresources
            /// </summary>
			public Union<ComputeResources, IntrinsicFunction> ComputeResources { get; set; }

            /// <summary>
            /// State
            /// The state of the compute environment. The valid values are ENABLED or DISABLED. An ENABLED state
            /// indicates that you can register instances with the compute environment and that the associated
            /// instances can accept jobs.
            /// Required: no
            /// Type: String
            /// Update requires: No Interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-state
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

        }
    
        public string Type { get; } = "AWS::Batch::ComputeEnvironment";
        
        public ComputeEnvironmentProperties Properties { get; } = new ComputeEnvironmentProperties();
    }
}
