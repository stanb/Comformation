using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.SecurityConfiguration
{
    /// <summary>
    /// AWS::Glue::SecurityConfiguration
    /// Creates a new security configuration. A security configuration is a set of security properties that can be
    /// used by AWS Glue. You can use a security configuration to encrypt data at rest. For information about using
    /// security configurations in AWS Glue, see Encrypting Data Written by Crawlers, Jobs, and Development Endpoints.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-securityconfiguration.html
    /// </summary>
    public class SecurityConfigurationResource : ResourceBase
    {
        public class SecurityConfigurationProperties
        {
            /// <summary>
            /// EncryptionConfiguration
            /// The encryption configuration associated with this security configuration.
            /// Required: Yes
            /// Type: EncryptionConfiguration
            /// Update requires: No interruption
            /// </summary>
			public EncryptionConfiguration EncryptionConfiguration { get; set; }

            /// <summary>
            /// Name
            /// The name of the security configuration.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::Glue::SecurityConfiguration";

        public SecurityConfigurationProperties Properties { get; } = new SecurityConfigurationProperties();

    }
}
