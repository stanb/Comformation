using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Certificate
{
    /// <summary>
    /// AWS::DMS::Certificate
    /// The AWS::DMS::Certificate resource creates an SSL certificate that encrypts connections between AWS DMS
    /// endpoints and the replication instance.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-certificate.html
    /// </summary>
    public class CertificateResource : ResourceBase
    {
        public class CertificateProperties
        {
            /// <summary>
            /// CertificateIdentifier
            /// A customer-assigned name for the certificate. Identifiers must begin with a letter; must contain
            /// only ASCII letters, digits, and hyphens; and must not end with a hyphen or contain two consecutive
            /// hyphens.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CertificateIdentifier { get; set; }

            /// <summary>
            /// CertificatePem
            /// The contents of a . pem file, which contains an X. 509 certificate.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CertificatePem { get; set; }

            /// <summary>
            /// CertificateWallet
            /// The location of an imported Oracle Wallet certificate for use with SSL.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CertificateWallet { get; set; }

        }

        public string Type { get; } = "AWS::DMS::Certificate";

        public CertificateProperties Properties { get; } = new CertificateProperties();

    }
}
