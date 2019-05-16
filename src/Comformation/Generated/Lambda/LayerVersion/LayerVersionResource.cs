using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.LayerVersion
{
    /// <summary>
    /// AWS::Lambda::LayerVersion
    /// The AWS::Lambda::LayerVersion resource creates an AWS Lambda layer from a ZIP archive.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-layerversion.html
    /// </summary>
    public class LayerVersionResource : ResourceBase
    {
        public class LayerVersionProperties
        {
            /// <summary>
            /// CompatibleRuntimes
            /// A list of compatible function runtimes. Used for filtering with ListLayers and ListLayerVersions.
            /// Required: No
            /// Type: List of String
            /// Maximum: 5
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> CompatibleRuntimes { get; set; }

            /// <summary>
            /// LicenseInfo
            /// The layer&#39;s software license. It can be any of the following:
            /// An SPDX license identifier. For example, MIT. The URL of a license hosted on the internet. For
            /// example, https://opensource. org/licenses/MIT. The full text of the license.
            /// Required: No
            /// Type: String
            /// Maximum: 512
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LicenseInfo { get; set; }

            /// <summary>
            /// Description
            /// The description of the version.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// LayerName
            /// The name or Amazon Resource Name (ARN) of the layer.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Pattern: (arn:[a-zA-Z0-9-]+:lambda:[a-zA-Z0-9-]+:\d{12}:layer:[a-zA-Z0-9-_]+)|[a-zA-Z0-9-_]+
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
