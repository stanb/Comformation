using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ImageRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ImageRecipe
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagerecipe.html
    /// </summary>
    public class ImageRecipeResource : ResourceBase
    {
        public class ImageRecipeProperties
        {
            /// <summary>
            /// Name
            /// The name of the image recipe.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[-_A-Za-z-0-9][-_A-Za-z0-9 ]{1,126}[-_A-Za-z-0-9]$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the image recipe.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Version
            /// The semantic version of the image recipe.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[0-9]+\. [0-9]+\. [0-9]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Version { get; set; }

            /// <summary>
            /// Components
            /// The components of the image recipe. Components are orchestration documents that define a sequence of
            /// steps for downloading, installing, configuring, and testing software packages. They also define
            /// validation and security hardening steps. A component is defined using a YAML document format.
            /// Required: Yes
            /// Type: List of ComponentConfiguration
            /// Update requires: Replacement
            /// </summary>
            public List<ComponentConfiguration> Components { get; set; }

            /// <summary>
            /// BlockDeviceMappings
            /// The block device mappings to apply when creating images from this recipe.
            /// Required: No
            /// Type: List of InstanceBlockDeviceMapping
            /// Update requires: Replacement
            /// </summary>
            public List<InstanceBlockDeviceMapping> BlockDeviceMappings { get; set; }

            /// <summary>
            /// ParentImage
            /// The parent image of the image recipe. The string must be either an Image ARN (SemVers is ok) or an
            /// AMI ID.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ParentImage { get; set; }

            /// <summary>
            /// WorkingDirectory
            /// The working directory to be used during build and test workflows.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> WorkingDirectory { get; set; }

            /// <summary>
            /// Tags
            /// The tags of the image recipe.
            /// Required: No
            /// Type: Map of String
            /// Update requires: Replacement
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ImageBuilder::ImageRecipe";

        public ImageRecipeProperties Properties { get; } = new ImageRecipeProperties();

    }

    public static class ImageRecipeAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
