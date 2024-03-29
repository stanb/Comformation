using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.Image
{
    /// <summary>
    /// AWS::ImageBuilder::Image
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html
    /// </summary>
    public class ImageResource : ResourceBase
    {
        public class ImageProperties
        {
            /// <summary>
            /// ImageTestsConfiguration
            /// 		
            /// The configuration settings for your image test components, which includes 			a toggle that allows
            /// you to turn off tests, and a timeout setting.
            /// 		
            /// Required: No
            /// Type: ImageTestsConfiguration
            /// Update requires: Replacement
            /// </summary>
            public ImageTestsConfiguration ImageTestsConfiguration { get; set; }

            /// <summary>
            /// ImageRecipeArn
            /// 		
            /// The Amazon Resource Name (ARN) of the image recipe.
            /// 	
            /// Required: No
            /// Type: String
            /// Pattern:
            /// ^arn:aws[^:]*:imagebuilder:[^:]+:(?:[0-9]{12}|aws):(?:image-recipe|container-recipe|infrastructure-configuration|distribution-configuration|component|image|image-pipeline)/[a-z0-9-_]+(?:/(?:(?:x|[0-9]+)\.
            /// (?:x|[0-9]+)\. (?:x|[0-9]+))(?:/[0-9]+)?)?$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ImageRecipeArn { get; set; }

            /// <summary>
            /// ContainerRecipeArn
            /// 		
            /// The Amazon Resource Name (ARN) of the container recipe that is used for this pipeline.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ContainerRecipeArn { get; set; }

            /// <summary>
            /// DistributionConfigurationArn
            /// 		
            /// The Amazon Resource Name (ARN) of the distribution configuration.
            /// 		
            /// Required: No
            /// Type: String
            /// Pattern:
            /// ^arn:aws[^:]*:imagebuilder:[^:]+:(?:[0-9]{12}|aws):(?:image-recipe|container-recipe|infrastructure-configuration|distribution-configuration|component|image|image-pipeline)/[a-z0-9-_]+(?:/(?:(?:x|[0-9]+)\.
            /// (?:x|[0-9]+)\. (?:x|[0-9]+))(?:/[0-9]+)?)?$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DistributionConfigurationArn { get; set; }

            /// <summary>
            /// InfrastructureConfigurationArn
            /// 		
            /// The Amazon Resource Name (ARN) of the infrastructure configuration associated with this 			image
            /// pipeline.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InfrastructureConfigurationArn { get; set; }

            /// <summary>
            /// EnhancedImageMetadataEnabled
            /// 		
            /// Collects additional information about the image being created, including the operating 			system
            /// (OS) version and package list. This information is used to enhance the overall 			experience of
            /// using EC2 Image Builder. Enabled by default.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> EnhancedImageMetadataEnabled { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// The tags of the image.
            /// 	
            /// Required: No
            /// Type: Map of String
            /// Update requires: Replacement
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ImageBuilder::Image";

        public ImageProperties Properties { get; } = new ImageProperties();

    }

    public static class ImageAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ImageId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ImageId");
    }
}
