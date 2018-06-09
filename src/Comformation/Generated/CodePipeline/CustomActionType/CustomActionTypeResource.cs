using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// AWS::CodePipeline::CustomActionType
    /// The AWS::CodePipeline::CustomActionType resource creates a custom action for activities that aren&#39;t included
    /// in the AWS CodePipeline default actions, such as running an internally developed build process or a test
    /// suite. You can use these custom actions in the stage of a pipeline. For more information, see Create and Add a
    /// Custom Action in AWS CodePipeline in the AWS CodePipeline User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html
    /// </summary>
    public class CustomActionTypeResource : ResourceBase
    {
        public class CustomActionTypeProperties
        {
            /// <summary>
            /// Category
            /// The category of the custom action, such as a source action or a build action. For valid values, see
            /// CreateCustomActionType in the AWS CodePipeline API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Category { get; set; }

            /// <summary>
            /// ConfigurationProperties
            /// The configuration properties for the custom action.
            /// Required: No
            /// Type: List of AWS CodePipeline CustomActionType ConfigurationProperties
            /// Update requires: Replacement
            /// </summary>
			public Union<List<ConfigurationProperties>, IntrinsicFunction> ConfigurationProperties { get; set; }

            /// <summary>
            /// InputArtifactDetails
            /// The input artifact details for this custom action.
            /// Required: Yes
            /// Type: AWS CodePipeline CustomActionType ArtifactDetails
            /// Update requires: Replacement
            /// </summary>
			public Union<ArtifactDetails, IntrinsicFunction> InputArtifactDetails { get; set; }

            /// <summary>
            /// OutputArtifactDetails
            /// The output artifact details for this custom action.
            /// Required: Yes
            /// Type: AWS CodePipeline CustomActionType ArtifactDetails
            /// Update requires: Replacement
            /// </summary>
			public Union<ArtifactDetails, IntrinsicFunction> OutputArtifactDetails { get; set; }

            /// <summary>
            /// Provider
            /// The name of the service provider that AWS CodePipeline uses for this custom action.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Provider { get; set; }

            /// <summary>
            /// Settings
            /// URLs that provide users information about this custom action.
            /// Required: No
            /// Type: AWS CodePipeline CustomActionType Settings
            /// Update requires: Replacement
            /// </summary>
			public Union<Settings, IntrinsicFunction> Settings { get; set; }

            /// <summary>
            /// Version
            /// The version number of this custom action.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Version { get; set; }

        }
    
        public string Type { get; } = "AWS::CodePipeline::CustomActionType";
        
        public CustomActionTypeProperties Properties { get; } = new CustomActionTypeProperties();
    }
}
