using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CertificateManager.Certificate
{
    /// <summary>
    /// AWS::CertificateManager::Certificate
    /// The AWS::CertificateManager::Certificate resource requests an AWS Certificate Manager (ACM) certificate that
    /// you can use with AWS services to enable secure connections. For example, you can deploy an ACM certificate to
    /// an Elastic Load Balancing load balancer to enable HTTPS support. For more information, see the
    /// RequestCertificate action in the AWS Certificate Manager API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-certificate.html
    /// </summary>
    public class CertificateResource : ResourceBase
    {
        public class CertificateProperties
        {
            /// <summary>
            /// DomainName
            /// Fully qualified domain name (FQDN), such as www. example. com, of the site that you want to secure
            /// with the ACM certificate. To protect several sites in the same domain, use an asterisk (*) to
            /// specify a wildcard. For example, *. example. com protects www. example. com, site. example. com, and
            /// images. example. com.
            /// For constraints, see the DomainName parameter for the RequestCertificate action in the AWS
            /// Certificate Manager API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// DomainValidationOptions
            /// Domain information that domain name registrars use to verify your identity. For more information and
            /// the default values, see Configure Email for Your Domain and Validate Domain Ownership in the AWS
            /// Certificate Manager User Guide.
            /// Required: No
            /// Type: List of AWS Certificate Manager Certificate DomainValidationOption
            /// Update requires: Replacement
            /// </summary>
			public List<DomainValidationOption> DomainValidationOptions { get; set; }

            /// <summary>
            /// SubjectAlternativeNames
            /// FQDNs to be included in the Subject Alternative Name extension of the ACM certificate. For example,
            /// you can add www. example. net to a certificate for the www. example. com domain name so that users
            /// can reach your site by using either name.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SubjectAlternativeNames { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this ACM certificate.
            /// Required: No
            /// Type: Resource Tag
            /// Update requires: No interruption.
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// ValidationMethod
            /// The method you want to use if you are requesting a public certificate to validate that you own or
            /// control a domain. Valid values include EMAIL or DNS. We recommend that you use DNS validation. The
            /// default is EMAIL.
            /// ACM uses CNAME (Canonical Name) records to validate that you own or control a domain. When you
            /// choose DNS validation, ACM provides you one or more CNAME records to insert into your DNS database.
            /// During stack creation, CloudFormation emits a CREATE_IN_PROGRESS event which lists these CNAME
            /// records. They are displayed in the Status reason column on the Events page for the stack. In order
            /// for CloudFormation to complete stack creation, you must add the CNAME records to your DNS database.
            /// For more information, see Use DNS to Validate Domain Ownership in the AWS Certificate Manager User
            /// Guide.
            /// For more information on email validation, see Use Email to Validate Domain Ownership in the AWS
            /// Certificate Manager User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ValidationMethod { get; set; }

        }
    
        public string Type { get; } = "AWS::CertificateManager::Certificate";
        
        public CertificateProperties Properties { get; } = new CertificateProperties();

    }
}
