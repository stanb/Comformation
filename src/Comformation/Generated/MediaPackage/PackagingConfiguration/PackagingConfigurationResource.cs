using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingConfiguration
{
    /// <summary>
    /// AWS::MediaPackage::PackagingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediapackage-packagingconfiguration.html
    /// </summary>
    public class PackagingConfigurationResource : ResourceBase
    {
        public class PackagingConfigurationProperties
        {
            /// <summary>
            /// Id
            /// Unique identifier that you assign to the packaging configuration.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Id { get; set; }

            /// <summary>
            /// PackagingGroupId
            /// The ID of the packaging group associated with this packaging configuration.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PackagingGroupId { get; set; }

            /// <summary>
            /// CmafPackage
            /// Parameters for CMAF packaging.
            /// Required: No
            /// Type: CmafPackage
            /// Update requires: No interruption
            /// </summary>
            public CmafPackage CmafPackage { get; set; }

            /// <summary>
            /// DashPackage
            /// Parameters for DASH-ISO packaging.
            /// Required: No
            /// Type: DashPackage
            /// Update requires: No interruption
            /// </summary>
            public DashPackage DashPackage { get; set; }

            /// <summary>
            /// HlsPackage
            /// Parameters for Apple HLS packaging.
            /// Required: No
            /// Type: HlsPackage
            /// Update requires: No interruption
            /// </summary>
            public HlsPackage HlsPackage { get; set; }

            /// <summary>
            /// MssPackage
            /// Parameters for Microsoft Smooth Streaming packaging.
            /// Required: No
            /// Type: MssPackage
            /// Update requires: No interruption
            /// </summary>
            public MssPackage MssPackage { get; set; }

            /// <summary>
            /// Tags
            /// The tags to assign to the packaging configuration.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::MediaPackage::PackagingConfiguration";

        public PackagingConfigurationProperties Properties { get; } = new PackagingConfigurationProperties();

    }

    public static class PackagingConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
