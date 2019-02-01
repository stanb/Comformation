using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.LayerVersion
{
    /// <summary>
    /// AWS::Lambda::LayerVersion
    /// The AWS::Lambda::LayerVersion resource creates a layer version in AWS Lambda. For more information, see AWS
    /// Lambda Layers in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-layerversion.html
    /// </summary>
    public class LayerVersionResource : ResourceBase
    {
        public class LayerVersionProperties
        {
            /// <summary>
            /// CompatibleRuntimes
            /// A list of compatible function runtimes.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> CompatibleRuntimes { get; set; }

            /// <summary>
            /// LicenseInfo
            /// The layer&#39;s software license. It can be either of the following:
            /// An SPDX license identifier. For example, MIT. The URL of a license hosted on the internet. For
            /// example, https://opensource. org/licenses/MIT.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LicenseInfo { get; set; }

            /// <summary>
            /// Description
            /// The description of the version.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// LayerName
            /// The name of the layer.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LayerName { get; set; }

            /// <summary>
            /// Content
            /// The function layer archive.
            /// Required: Yes
            /// Type: Content
            /// Update requires: Replacement
            /// </summary>
			public Content Content { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::LayerVersion";

        public LayerVersionProperties Properties { get; } = new LayerVersionProperties();

    }
}
