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
            /// The customer-assigned name of the certificate. Valid characters are A-z and 0-9.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CertificateIdentifier { get; set; }

            /// <summary>
            /// CertificatePem
            /// The contents of the . pem X. 509 certificate file for the certificate.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CertificatePem { get; set; }

            /// <summary>
            /// CertificateWallet
            /// The location of the imported Oracle Wallet certificate for use with SSL.
            /// Required: No
            /// Type: Base64-encoded binary data object
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CertificateWallet { get; set; }

        }
    
        public string Type { get; } = "AWS::DMS::Certificate";
        
        public CertificateProperties Properties { get; } = new CertificateProperties();

    }
}
