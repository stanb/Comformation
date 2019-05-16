using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline
    /// The AWS::CodePipeline::Pipeline resource creates a CodePipeline pipeline that describes how software changes
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
            /// The Amazon S3 bucket where artifacts are stored for the pipeline.
            /// Required: No
            /// Type: ArtifactStore
            /// Update requires: No interruption
            /// </summary>
			public ArtifactStore ArtifactStore { get; set; }

            /// <summary>
            /// ArtifactStores
            /// A mapping of artifactStore objects and their corresponding regions. There must be an artifact store
            /// for the pipeline region and for each cross-region action within the pipeline. You can only use
            /// either artifactStore or artifactStores, not both.
            /// If you create a cross-region action in your pipeline, you must use artifactStores.
            /// Required: No
            /// Type: List of ArtifactStoreMap
            /// Update requires: No interruption
            /// </summary>
			public List<ArtifactStoreMap> ArtifactStores { get; set; }

            /// <summary>
            /// DisableInboundStageTransitions
            /// Represents the input of a DisableStageTransition action.
            /// Required: No
            /// Type: List of StageTransition
            /// Update requires: No interruption
            /// </summary>
			public List<StageTransition> DisableInboundStageTransitions { get; set; }

            /// <summary>
            /// Name
            /// The name of the pipeline.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: [A-Za-z0-9. @\-_]+
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
            /// The Amazon Resource Name (ARN) for AWS CodePipeline to use to either perform actions with no
            /// actionRoleArn, or to use to assume roles for actions with an actionRoleArn.
            /// Required: Yes
            /// Type: String
            /// Maximum: 1024
            /// Pattern: arn:aws(-[\w]+)*:iam::[0-9]{12}:role/. *
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Stages
            /// Represents information about a stage and its definition.
            /// Required: Yes
            /// Type: List of StageDeclaration
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
