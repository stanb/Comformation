using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthorityActivation
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthorityActivation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthorityactivation.html
    /// </summary>
    public class CertificateAuthorityActivationResource : ResourceBase
    {
        public class CertificateAuthorityActivationProperties
        {
            /// <summary>
            /// CertificateAuthorityArn
            /// The Amazon Resource Name (ARN) of your private CA.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateAuthorityArn { get; set; }

            /// <summary>
            /// Certificate
            /// The Base64 PEM-encoded certificate authority certificate.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Certificate { get; set; }

            /// <summary>
            /// CertificateChain
            /// The Base64 PEM-encoded certificate chain that chains up to the root CA certificate that you used to
            /// sign your private CA certificate.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateChain { get; set; }

            /// <summary>
            /// Status
            /// Status of your private CA.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

        }

        public string Type { get; } = "AWS::ACMPCA::CertificateAuthorityActivation";

        public CertificateAuthorityActivationProperties Properties { get; } = new CertificateAuthorityActivationProperties();

    }

    public static class CertificateAuthorityActivationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CompleteCertificateChain = new ResourceAttribute<Union<string, IntrinsicFunction>>("CompleteCertificateChain");
    }
}
