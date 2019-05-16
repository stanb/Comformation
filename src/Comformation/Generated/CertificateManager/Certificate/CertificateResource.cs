using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CertificateManager.Certificate
{
    /// <summary>
    /// AWS::CertificateManager::Certificate
    /// The AWS::CertificateManager::Certificate resource requests an AWS Certificate Manager (ACM) certificate that
    /// you can use to enable secure connections. For example, you can deploy an ACM certificate to an Elastic Load
    /// Balancer to enable HTTPS support. For more information, see RequestCertificate in the AWS Certificate Manager
    /// API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html
    /// </summary>
    public class CertificateResource : ResourceBase
    {
        public class CertificateProperties
        {
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
            /// Key-value pairs that can identity the certificate.
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
            /// Allowed Values: DNS | EMAIL
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ValidationMethod { get; set; }

        }

        public string Type { get; } = "AWS::CertificateManager::Certificate";

        public CertificateProperties Properties { get; } = new CertificateProperties();

    }
}
