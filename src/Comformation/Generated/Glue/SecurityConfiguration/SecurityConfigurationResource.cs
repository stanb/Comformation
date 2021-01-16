using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.SecurityConfiguration
{
    /// <summary>
    /// AWS::Glue::SecurityConfiguration
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
