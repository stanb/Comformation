using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.SecurityConfiguration
{
    /// <summary>
    /// AWS::EMR::SecurityConfiguration
    /// Use a SecurityConfiguration resource to configure data encryption, Kerberos authentication (available in
    /// Amazon EMR release version 5. 10. 0 and later), and Amazon S3 authorization for EMRFS (available in EMR 5. 10.
    /// 0 and later). You can re-use a security configuration for any number of clusters in your account. For more
    /// information and example security configuration JSON objects, see Create a Security Configuration in the Amazon
    /// EMR Management Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-securityconfiguration.html
    /// </summary>
    public class SecurityConfigurationResource : ResourceBase
    {
        public class SecurityConfigurationProperties
        {
            /// <summary>
            /// Name
            /// The name of the security configuration.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 10280
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// SecurityConfiguration
            /// The security configuration details in JSON format.
            /// Required: Yes
            /// Type: Json
            /// Update requires: Replacement
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> SecurityConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::EMR::SecurityConfiguration";

        public SecurityConfigurationProperties Properties { get; } = new SecurityConfigurationProperties();

    }
}
