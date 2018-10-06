using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline
    /// The AWS::CodePipeline::Pipeline resource creates an AWS CodePipeline pipeline that describes how software
    /// changes go through a release process. For more information, see What Is AWS CodePipeline? in the AWS
    /// CodePipeline User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html
    /// </summary>
    public class PipelineResource : ResourceBase
    {
        public class PipelineProperties
        {
            /// <summary>
            /// ArtifactStore
            /// The Amazon Simple Storage Service (Amazon S3) location where AWS CodePipeline stores pipeline
            /// artifacts. For more information, see Create an Amazon S3 Bucket for Your Application in the AWS
            /// CodePipeline User Guide.
            /// Required: Yes
            /// Type: AWS CodePipeline Pipeline ArtifactStore
            /// Update requires: No interruption
            /// </summary>
			public ArtifactStore ArtifactStore { get; set; }

            /// <summary>
            /// DisableInboundStageTransitions
            /// Prevents artifacts in a pipeline from transitioning to the stage that you specified. This enables
            /// you to manually control transitions.
            /// Required: No
            /// Type: List of AWS CodePipeline Pipeline DisableInboundStageTransitions
            /// Update requires: No interruption
            /// </summary>
			public List<StageTransition> DisableInboundStageTransitions { get; set; }

            /// <summary>
            /// Name
            /// The name of your AWS CodePipeline pipeline.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RestartExecutionOnUpdate
            /// Indicates whether to rerun the AWS CodePipeline pipeline after you update it.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> RestartExecutionOnUpdate { get; set; }

            /// <summary>
            /// RoleArn
            /// A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to
            /// AWS services on your behalf. For more information, see AWS CodePipeline Access Permissions Reference
            /// in the AWS CodePipeline User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Stages
            /// Defines the AWS CodePipeline pipeline stages.
            /// Required: Yes
            /// Type: AWS CodePipeline Pipeline Stages
            /// Update requires: No interruption
            /// </summary>
			public List<StageDeclaration> Stages { get; set; }

        }
    
        public string Type { get; } = "AWS::CodePipeline::Pipeline";
        
        public PipelineProperties Properties { get; } = new PipelineProperties();

    }

	public static class PipelineAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Version = new ResourceAttribute<Union<string, IntrinsicFunction>>("Version");
	}
}
