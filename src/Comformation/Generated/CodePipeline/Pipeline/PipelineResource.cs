using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline
    /// The AWS::CodePipeline::Pipeline resource creates an CodePipeline pipeline that describes how software changes
    /// go through a release process. For more information, see What Is CodePipeline? in the AWS CodePipeline User
    /// Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-pipeline.html
    /// </summary>
    public class PipelineResource : ResourceBase
    {
        public class PipelineProperties
        {
            /// <summary>
            /// ArtifactStore
            /// The Amazon Simple Storage Service (Amazon S3) location where CodePipeline stores pipeline artifacts.
            /// You can only use either ArtifactStore or ArtifactStores, not both. For more information, see Create
            /// an Amazon S3 Bucket for Your Application in the AWS CodePipeline User Guide.
            /// Required: No
            /// Type: ArtifactStore
            /// Update requires: No interruption
            /// </summary>
			public ArtifactStore ArtifactStore { get; set; }

            /// <summary>
            /// ArtifactStores
            /// Specifies a list of ArtifactStoreMap mappings. There must be an artifact store for the pipeline
            /// region and for each cross-region action within the pipeline. You can only use either ArtifactStore
            /// or ArtifactStores, not both.
            /// Required: No
            /// Type: List of ArtifactStoreMap property types
            /// Update requires: No interruption
            /// </summary>
			public List<ArtifactStoreMap> ArtifactStores { get; set; }

            /// <summary>
            /// DisableInboundStageTransitions
            /// Prevents artifacts in a pipeline from transitioning to the stage that you specified. This enables
            /// you to manually control transitions.
            /// Required: No
            /// Type: List of DisableInboundStageTransitions property types
            /// Update requires: No interruption
            /// </summary>
			public List<StageTransition> DisableInboundStageTransitions { get; set; }

            /// <summary>
            /// Name
            /// The name of your CodePipeline pipeline.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RestartExecutionOnUpdate
            /// Indicates whether to rerun the CodePipeline pipeline after you update it.
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
            /// Defines the CodePipeline pipeline stages.
            /// Required: Yes
            /// Type: List of Stages property types
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
