using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.DomainConfiguration
{
    /// <summary>
    /// AWS::IoT::DomainConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html
    /// </summary>
    public class DomainConfigurationResource : ResourceBase
    {
        public class DomainConfigurationProperties
        {
            /// <summary>
            /// DomainConfigurationName
            /// The name of the domain configuration. This value must be unique to a region.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainConfigurationName { get; set; }

            /// <summary>
            /// AuthorizerConfig
            /// An object that specifies the authorization service for a domain.
            /// Required: No
            /// Type: AuthorizerConfig
            /// Update requires: No interruption
            /// </summary>
            public AuthorizerConfig AuthorizerConfig { get; set; }

            /// <summary>
            /// DomainName
            /// The name of the domain.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// ServerCertificateArns
            /// The ARNs of the certificates that AWS IoT passes to the device during the TLS handshake. Currently
            /// you can specify only one certificate ARN. This value is not required for AWS-managed domains.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ServerCertificateArns { get; set; }

            /// <summary>
            /// ServiceType
            /// The type of service delivered by the endpoint.
            /// Note AWS IoT Core currently supports only the DATA service type.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceType { get; set; }

            /// <summary>
            /// ValidationCertificateArn
            /// The certificate used to validate the server certificate and prove domain name ownership. This
            /// certificate must be signed by a public certificate authority. This value is not required for
            /// AWS-managed domains.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ValidationCertificateArn { get; set; }

            /// <summary>
            /// DomainConfigurationStatus
            /// The status to which the domain configuration should be updated.
            /// Valid values: ENABLED | DISABLED
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DomainConfigurationStatus { get; set; }

            /// <summary>
            /// Tags
            /// Metadata which can be used to manage the domain configuration.
            /// Note For URI Request parameters use format: . . . key1=value1&amp;amp;key2=value2. . . For the CLI
            /// command-line parameter use format: &amp;amp;&amp;amp;tags &quot;key1=value1&amp;amp;key2=value2. . . &quot; For the
            /// cli-input-json file use format: &quot;tags&quot;: &quot;key1=value1&amp;amp;key2=value2. . . &quot;
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IoT::DomainConfiguration";

        public DomainConfigurationProperties Properties { get; } = new DomainConfigurationProperties();

    }

    public static class DomainConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DomainType = new ResourceAttribute<Union<string, IntrinsicFunction>>("DomainType");
        public static readonly ResourceAttribute<List<ServerCertificateSummary>> ServerCertificates = new ResourceAttribute<List<ServerCertificateSummary>>("ServerCertificates");
    }
}
