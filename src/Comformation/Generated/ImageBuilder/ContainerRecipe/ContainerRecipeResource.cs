using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ContainerRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ContainerRecipe
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html
    /// </summary>
    public class ContainerRecipeResource : ResourceBase
    {
        public class ContainerRecipeProperties
        {
            /// <summary>
            /// Name
            /// 		
            /// The name of the container recipe.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[-_A-Za-z-0-9][-_A-Za-z0-9 ]{1,126}[-_A-Za-z-0-9]$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// 		
            /// The description of the container recipe.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Version
            /// 		
            /// The semantic version of the container recipe.
            /// 		
            /// Note The semantic version has four nodes: &amp;lt;major&amp;gt;. &amp;lt;minor&amp;gt;. &amp;lt;patch&amp;gt;/&amp;lt;build&amp;gt;.
            /// 	You can assign values for the first three, and can filter on all of them. Assignment: For the first
            /// three nodes you can assign any positive integer value, including 	zero, with an upper limit of
            /// 2^30-1, or 1073741823 for each node. Image Builder automatically assigns the 	build number, and that
            /// is not open for updates. Patterns: You can use any numeric pattern that adheres to the assignment
            /// requirements for 	the nodes that you can assign. For example, you might choose a software version
            /// pattern, such as 1. 0. 0, or 	a date, such as 2021. 01. 01. Filtering: When you retrieve or
            /// reference a resource with a semantic version, you can use 	wildcards (x) to filter your results.
            /// When you use a wildcard in any node, all nodes to the right of the 	first wildcard must also be
            /// wildcards. For example, specifying &quot;1. 2. x&quot;, or &quot;1. x. x&quot; works to filter list 	results, but
            /// neither &quot;1. x. 2&quot;, nor &quot;x. 2. x&quot; will work. You do not have to specify the build - Image Builder
            /// 	automatically uses a wildcard for that, if applicable.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[0-9]+\. [0-9]+\. [0-9]+$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Version { get; set; }

            /// <summary>
            /// Components
            /// 		
            /// Components for build and test that are included in the container recipe.
            /// 	
            /// Required: Yes
            /// Type: List of ComponentConfiguration
            /// Update requires: Replacement
            /// </summary>
            public List<ComponentConfiguration> Components { get; set; }

            /// <summary>
            /// InstanceConfiguration
            /// 		
            /// A group of options that can be used to configure an instance for building and testing container
            /// images.
            /// 	
            /// Required: No
            /// Type: InstanceConfiguration
            /// Update requires: Replacement
            /// </summary>
            public InstanceConfiguration InstanceConfiguration { get; set; }

            /// <summary>
            /// DockerfileTemplateData
            /// 		
            /// Dockerfiles are text documents that are used to build Docker containers, and ensure that they
            /// contain all of the elements required by the application running inside. The template data consists
            /// of contextual variables where Image Builder places build information or scripts, based on your
            /// container image recipe.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DockerfileTemplateData { get; set; }

            /// <summary>
            /// DockerfileTemplateUri
            /// 		
            /// The S3 URI for the Dockerfile that will be used to build your container image.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DockerfileTemplateUri { get; set; }

            /// <summary>
            /// PlatformOverride
            /// 		
            /// Specifies the operating system platform when you use a custom source image.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PlatformOverride { get; set; }

            /// <summary>
            /// ContainerType
            /// 		
            /// Specifies the type of container, such as Docker.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed values: DOCKER
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ContainerType { get; set; }

            /// <summary>
            /// ImageOsVersionOverride
            /// 		
            /// Specifies the operating system version for the source image.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ImageOsVersionOverride { get; set; }

            /// <summary>
            /// TargetRepository
            /// 		
            /// The destination repository for the container image.
            /// 	
            /// Required: Yes
            /// Type: TargetContainerRepository
            /// Update requires: Replacement
            /// </summary>
            public TargetContainerRepository TargetRepository { get; set; }

            /// <summary>
            /// KmsKeyId
            /// 		
            /// Identifies which KMS key is used to encrypt the container image for distribution to the target
            /// Region.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

            /// <summary>
            /// ParentImage
            /// 		
            /// The source image for the container recipe.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ParentImage { get; set; }

            /// <summary>
            /// WorkingDirectory
            /// 		
            /// The working directory for use during build and test workflows.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> WorkingDirectory { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// Tags that are attached to the container recipe.
            /// 	
            /// Required: No
            /// Type: Map of String
            /// Update requires: Replacement
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ImageBuilder::ContainerRecipe";

        public ContainerRecipeProperties Properties { get; } = new ContainerRecipeProperties();

    }

    public static class ContainerRecipeAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
