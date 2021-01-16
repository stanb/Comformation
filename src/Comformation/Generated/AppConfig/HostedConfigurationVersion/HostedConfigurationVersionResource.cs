using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppConfig.HostedConfigurationVersion
{
    /// <summary>
    /// AWS::AppConfig::HostedConfigurationVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-hostedconfigurationversion.html
    /// </summary>
    public class HostedConfigurationVersionResource : ResourceBase
    {
        public class HostedConfigurationVersionProperties
        {
            /// <summary>
            /// ConfigurationProfileId
            /// The configuration profile ID.
            /// Required: Yes
            /// Type: String
            /// Pattern: [a-z0-9]{4,7}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConfigurationProfileId { get; set; }

            /// <summary>
            /// Description
            /// A description of the configuration.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ContentType
            /// A standard MIME type describing the format of the configuration content. For more information, see
            /// Content-Type.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ContentType { get; set; }

            /// <summary>
            /// LatestVersionNumber
            /// An optional locking token used to prevent race conditions from overwriting configuration updates
            /// when creating a new version. To ensure your data is not overwritten when creating multiple hosted
            /// configuration versions in rapid succession, specify the version number of the latest hosted
            /// configuration version.
            /// Required: No
            /// Type: Double
            /// Update requires: Replacement
            /// </summary>
            public Union<double, IntrinsicFunction> LatestVersionNumber { get; set; }

            /// <summary>
            /// Content
            /// The content of the configuration or the configuration data.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Content { get; set; }

            /// <summary>
            /// ApplicationId
            /// The application ID.
            /// Required: Yes
            /// Type: String
            /// Pattern: [a-z0-9]{4,7}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationId { get; set; }

        }

        public string Type { get; } = "AWS::AppConfig::HostedConfigurationVersion";

        public HostedConfigurationVersionProperties Properties { get; } = new HostedConfigurationVersionProperties();

    }
}
