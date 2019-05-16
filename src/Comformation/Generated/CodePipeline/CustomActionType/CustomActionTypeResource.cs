using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// AWS::CodePipeline::CustomActionType
    /// The AWS::CodePipeline::CustomActionType resource creates a custom action for activities that aren&#39;t included
    /// in the CodePipeline default actions, such as running an internally developed build process or a test suite.
    /// You can use these custom actions in the stage of a pipeline. For more information, see Create and Add a Custom
    /// Action in AWS CodePipeline in the AWS CodePipeline User Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html
    /// </summary>
    public class CustomActionTypeResource : ResourceBase
    {
        public class CustomActionTypeProperties
        {
            /// <summary>
            /// Category
            /// The category of the custom action, such as a build action or a test action.
            /// Note Although Source and Approval are listed as valid values, they are not currently functional.
            /// These values are reserved for future use.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: Approval | Build | Deploy | Invoke | Source | Test
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Category { get; set; }

            /// <summary>
            /// ConfigurationProperties
            /// The configuration properties for the custom action.
            /// Note You can refer to a name in the configuration properties of the custom action within the URL
            /// templates by following the format of {Config:name}, as long as the configuration property is both
            /// required and not secret. For more information, see Create a Custom Action for a Pipeline.
            /// Required: No
            /// Type: List of ConfigurationProperties
            /// Maximum: 10
            /// Update requires: Replacement
            /// </summary>
			public List<ConfigurationProperties> ConfigurationProperties { get; set; }

            /// <summary>
            /// InputArtifactDetails
            /// The details of the input artifact for the action, such as its commit ID.
            /// Required: Yes
            /// Type: ArtifactDetails
            /// Update requires: Replacement
            /// </summary>
			public ArtifactDetails InputArtifactDetails { get; set; }

            /// <summary>
            /// OutputArtifactDetails
            /// The details of the output artifact of the action, such as its commit ID.
            /// Required: Yes
            /// Type: ArtifactDetails
            /// Update requires: Replacement
            /// </summary>
			public ArtifactDetails OutputArtifactDetails { get; set; }

            /// <summary>
            /// Provider
            /// The provider of the service used in the custom action, such as AWS CodeDeploy.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 25
            /// Pattern: [0-9A-Za-z_-]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Provider { get; set; }

            /// <summary>
            /// Settings
            /// URLs that provide users information about this custom action.
            /// Required: No
            /// Type: Settings
            /// Update requires: Replacement
            /// </summary>
			public Settings Settings { get; set; }

            /// <summary>
            /// Version
            /// The version identifier of the custom action.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 9
            /// Pattern: [0-9A-Za-z_-]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Version { get; set; }

        }

        public string Type { get; } = "AWS::CodePipeline::CustomActionType";

        public CustomActionTypeProperties Properties { get; } = new CustomActionTypeProperties();

    }
}
