using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificate.html
    /// </summary>
    public class CertificateResource : ResourceBase
    {
        public class CertificateProperties
        {
            /// <summary>
            /// CertificateAuthorityArn
            /// The Amazon Resource Name (ARN) for the private CA used to issue the certificate.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateAuthorityArn { get; set; }

            /// <summary>
            /// CertificateSigningRequest
            /// The certificate signing request (CSR) for the certificate.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateSigningRequest { get; set; }

            /// <summary>
            /// SigningAlgorithm
            /// 		
            /// The name of the algorithm that will be used to sign the certificate to be issued.
            /// 		
            /// This parameter should not be confused with the SigningAlgorithm parameter 			used to sign a CSR.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed values: SHA256WITHECDSA | SHA256WITHRSA | SHA384WITHECDSA | SHA384WITHRSA | SHA512WITHECDSA
            /// | SHA512WITHRSA
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SigningAlgorithm { get; set; }

            /// <summary>
            /// TemplateArn
            /// Specifies a custom configuration template to use when issuing a certificate. If this parameter is
            /// not provided, ACM Private CA defaults to the EndEntityCertificate/V1 template. For more information
            /// about ACM Private CA templates, see Using Templates.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateArn { get; set; }

            /// <summary>
            /// Validity
            /// The period of time during which the certificate will be valid.
            /// Required: Yes
            /// Type: Validity
            /// Update requires: Replacement
            /// </summary>
            public Validity Validity { get; set; }

        }

        public string Type { get; } = "AWS::ACMPCA::Certificate";

        public CertificateProperties Properties { get; } = new CertificateProperties();

    }

    public static class CertificateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Certificate = new ResourceAttribute<Union<string, IntrinsicFunction>>("Certificate");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
