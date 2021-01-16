using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ImagePipeline
{
    /// <summary>
    /// AWS::ImageBuilder::ImagePipeline
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-imagepipeline.html
    /// </summary>
    public class ImagePipelineResource : ResourceBase
    {
        public class ImagePipelineProperties
        {
            /// <summary>
            /// Name
            /// The name of the image pipeline.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[-_A-Za-z-0-9][-_A-Za-z0-9 ]{1,126}[-_A-Za-z-0-9]$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of this image pipeline.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ImageTestsConfiguration
            /// The configuration of the image tests used when creating this image.
            /// Required: No
            /// Type: ImageTestsConfiguration
            /// Update requires: No interruption
            /// </summary>
            public ImageTestsConfiguration ImageTestsConfiguration { get; set; }

            /// <summary>
            /// Status
            /// The status of the image pipeline.
            /// Required: No
            /// Type: String
            /// Allowed values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// Schedule
            /// The schedule of the image pipeline. A schedule configures how often and when a pipeline will
            /// automatically create a new image.
            /// Required: No
            /// Type: Schedule
            /// Update requires: No interruption
            /// </summary>
            public Schedule Schedule { get; set; }

            /// <summary>
            /// ImageRecipeArn
            /// The Amazon Resource Name (ARN) of the image recipe associated with this image pipeline.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ImageRecipeArn { get; set; }

            /// <summary>
            /// DistributionConfigurationArn
            /// The Amazon Resource Name (ARN) of the distribution configuration associated with this image
            /// pipeline.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DistributionConfigurationArn { get; set; }

            /// <summary>
            /// InfrastructureConfigurationArn
            /// The Amazon Resource Name (ARN) of the infrastructure configuration associated with this image
            /// pipeline.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InfrastructureConfigurationArn { get; set; }

            /// <summary>
            /// EnhancedImageMetadataEnabled
            /// Collects additional information about the image being created, including the operating system (OS)
            /// version and package list. This information is used to enhance the overall experience of using EC2
            /// Image Builder. Enabled by default.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnhancedImageMetadataEnabled { get; set; }

            /// <summary>
            /// Tags
            /// The tags of this image pipeline.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ImageBuilder::ImagePipeline";

        public ImagePipelineProperties Properties { get; } = new ImagePipelineProperties();

    }

    public static class ImagePipelineAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
