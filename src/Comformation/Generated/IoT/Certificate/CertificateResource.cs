using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Certificate
{
    /// <summary>
    /// AWS::IoT::Certificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html
    /// </summary>
    public class CertificateResource : ResourceBase
    {
        public class CertificateProperties
        {
            /// <summary>
            /// CACertificatePem
            /// The CA certificate used to sign the device certificate being registered, not available when
            /// CertificateMode is SNI_ONLY.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CACertificatePem { get; set; }

            /// <summary>
            /// CertificatePem
            /// The certificate data in PEM format. Requires SNI_ONLY for the certificate mode or the accompanying
            /// CACertificatePem for registration.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificatePem { get; set; }

            /// <summary>
            /// CertificateSigningRequest
            /// The certificate signing request (CSR).
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateSigningRequest { get; set; }

            /// <summary>
            /// CertificateMode
            /// Specifies which mode of certificate registration to use with this resource. Valid options are
            /// DEFAULT with CaCertificatePem and CertificatePem, SNI_ONLY with CertificatePem, and Default with
            /// CertificateSigningRequest.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateMode { get; set; }

            /// <summary>
            /// Status
            /// The status of the certificate.
            /// Valid values are ACTIVE, INACTIVE, REVOKED, PENDING_TRANSFER, and PENDING_ACTIVATION.
            /// The status value REGISTER_INACTIVE is deprecated and should not be used.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

        }

        public string Type { get; } = "AWS::IoT::Certificate";

        public CertificateProperties Properties { get; } = new CertificateProperties();

    }

    public static class CertificateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
