using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Batch.ComputeEnvironment
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html
    /// </summary>
    public class ComputeEnvironmentResource : ResourceBase
    {
        public class ComputeEnvironmentProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-type
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-servicerole
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRole { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeenvironmentname
            /// </summary>
			public Union<string, IntrinsicFunction> ComputeEnvironmentName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeresources
            /// </summary>
			public Union<ComputeResources, IntrinsicFunction> ComputeResources { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-state
            /// </summary>
			public Union<string, IntrinsicFunction> State { get; set; }

        }
    
        public string Type { get; } = "AWS::Batch::ComputeEnvironment";
        
        public ComputeEnvironmentProperties Properties { get; } = new ComputeEnvironmentProperties();
    }
}
