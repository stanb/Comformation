using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ImageVersion
{
    /// <summary>
    /// AWS::SageMaker::ImageVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-imageversion.html
    /// </summary>
    public class ImageVersionResource : ResourceBase
    {
        public class ImageVersionProperties
        {
            /// <summary>
            /// ImageName
            /// The name of the parent image.
            /// Length Constraints: Minimum length of 1. Maximum length of 63.
            /// Pattern: ^[a-zA-Z0-9]([-. ]?[a-zA-Z0-9]){0,62}$
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ImageName { get; set; }

            /// <summary>
            /// BaseImage
            /// The container image that the SageMaker image version is based on.
            /// Length Constraints: Minimum length of 1. Maximum length of 255.
            /// Pattern: . *
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BaseImage { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::ImageVersion";

        public ImageVersionProperties Properties { get; } = new ImageVersionProperties();

    }

    public static class ImageVersionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ImageArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ImageArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ImageVersionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ImageVersionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ContainerImage = new ResourceAttribute<Union<string, IntrinsicFunction>>("ContainerImage");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> Version = new ResourceAttribute<Union<int, IntrinsicFunction>>("Version");
    }
}
