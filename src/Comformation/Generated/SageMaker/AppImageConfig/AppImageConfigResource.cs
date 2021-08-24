using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.AppImageConfig
{
    /// <summary>
    /// AWS::SageMaker::AppImageConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-appimageconfig.html
    /// </summary>
    public class AppImageConfigResource : ResourceBase
    {
        public class AppImageConfigProperties
        {
            /// <summary>
            /// AppImageConfigName
            /// The name of the AppImageConfig. Must be unique to your account.
            /// Required: Yes
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AppImageConfigName { get; set; }

            /// <summary>
            /// KernelGatewayImageConfig
            /// The configuration for the file system and kernels in the SageMaker image.
            /// Required: No
            /// Type: KernelGatewayImageConfig
            /// Update requires: No interruption
            /// </summary>
            public KernelGatewayImageConfig KernelGatewayImageConfig { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::AppImageConfig";

        public AppImageConfigProperties Properties { get; } = new AppImageConfigProperties();

    }

    public static class AppImageConfigAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AppImageConfigArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AppImageConfigArn");
    }
}
