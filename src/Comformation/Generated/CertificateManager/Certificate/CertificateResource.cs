using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CertificateManager.Certificate
{
    /// <summary>
    /// AWS::CertificateManager::Certificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html
    /// </summary>
    public class CertificateResource : ResourceBase
    {
        public class CertificateProperties
        {
            /// <summary>
            /// CertificateAuthorityArn
            /// The Amazon Resource Name (ARN) of the private certificate authority (CA) that will be used to issue
            /// the certificate. If you do not provide an ARN and you are trying to request a private certificate,
            /// ACM will attempt to issue a public certificate. For more information about private CAs, see the AWS
            /// Certificate Manager Private Certificate Authority (PCA) user guide. The ARN must have the following
            /// form:
            /// arn:aws:acm-pca:region:account:certificate-authority/12345678-1234-1234-1234-123456789012
            /// Required: No
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:[\w+=/,. @-]*:[0-9]+:[\w+=,. @-]+(/[\w+=,. @-]+)*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateAuthorityArn { get; set; }

            /// <summary>
            /// CertificateTransparencyLoggingPreference
            /// You can opt out of certificate transparency logging by specifying the DISABLED option. Opt in by
            /// specifying ENABLED.
            /// If you do not specify a certificate transparency logging preference on a new CloudFormation
            /// template, or if you remove the logging preference from an existing template, this is the same as
            /// explicitly enabling the preference.
            /// Changing the certificate transparency logging preference will update the existing resource by
            /// calling UpdateCertificateOptions on the certificate. This action will not create a new resource.
            /// Required: No
            /// Type: String
            /// Allowed values: DISABLED | ENABLED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateTransparencyLoggingPreference { get; set; }

            /// <summary>
            /// DomainName
            /// The fully qualified domain name (FQDN), such as www. example. com, with which you want to secure an
            /// ACM certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in
            /// the same domain. For example, *. example. com protects www. example. com, site. example. com, and
            /// images. example. com.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 253
            /// Pattern: ^(\*\. )?(((?!-)[A-Za-z0-9-]{0,62}[A-Za-z0-9])\. )+((?!-)[A-Za-z0-9-]{1,62}[A-Za-z0-9])$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// DomainValidationOptions
            /// Domain information that domain name registrars use to verify your identity.
            /// Required: No
            /// Type: List of DomainValidationOption
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
            public List<DomainValidationOption> DomainValidationOptions { get; set; }

            /// <summary>
            /// SubjectAlternativeNames
            /// Additional FQDNs to be included in the Subject Alternative Name extension of the ACM certificate.
            /// For example, you can add www. example. net to a certificate for which the DomainName field is www.
            /// example. com if users can reach your site by using either name.
            /// Required: No
            /// Type: List of String
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubjectAlternativeNames { get; set; }

            /// <summary>
            /// Tags
            /// Key-value pairs that can identify the certificate.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ValidationMethod
            /// The method you want to use to validate that you own or control the domain associated with a public
            /// certificate. You can validate with DNS or validate with email. We recommend that you use DNS
            /// validation.
            /// Required: No
            /// Type: String
            /// Allowed values: DNS | EMAIL
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ValidationMethod { get; set; }

        }

        public string Type { get; } = "AWS::CertificateManager::Certificate";

        public CertificateProperties Properties { get; } = new CertificateProperties();

    }
}
