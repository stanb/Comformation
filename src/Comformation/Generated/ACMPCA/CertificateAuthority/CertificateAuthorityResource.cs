using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-acmpca-certificateauthority.html
    /// </summary>
    public class CertificateAuthorityResource : ResourceBase
    {
        public class CertificateAuthorityProperties
        {
            /// <summary>
            /// Type
            /// 		
            /// Type of your private CA.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed values: ROOT | SUBORDINATE
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// KeyAlgorithm
            /// 		
            /// Type of the public key algorithm and size, in bits, of the key pair that your CA 			creates when it
            /// issues a certificate. When you create a subordinate CA, you must use a 			key algorithm supported by
            /// the parent CA.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed values: EC_prime256v1 | EC_secp384r1 | RSA_2048 | RSA_4096
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KeyAlgorithm { get; set; }

            /// <summary>
            /// SigningAlgorithm
            /// 		
            /// Name of the algorithm your private CA uses to sign certificate requests.
            /// 		
            /// This parameter should not be confused with the SigningAlgorithm parameter 			used to sign
            /// certificates when they are issued.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed values: SHA256WITHECDSA | SHA256WITHRSA | SHA384WITHECDSA | SHA384WITHRSA | SHA512WITHECDSA
            /// | SHA512WITHRSA
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SigningAlgorithm { get; set; }

            /// <summary>
            /// Subject
            /// 		
            /// Structure that contains X. 500 distinguished name information for your private 			CA.
            /// 	
            /// Required: Yes
            /// Type: Subject
            /// Update requires: Replacement
            /// </summary>
            public Subject Subject { get; set; }

            /// <summary>
            /// RevocationConfiguration
            /// Information about the certificate revocation list (CRL) created and maintained by your private CA.
            /// Certificate revocation information used by the CreateCertificateAuthority and
            /// UpdateCertificateAuthority actions. Your certificate authority can create and maintain a certificate
            /// revocation list (CRL). A CRL contains information about certificates that have been revoked.
            /// Required: No
            /// Type: RevocationConfiguration
            /// Update requires: No interruption
            /// </summary>
            public RevocationConfiguration RevocationConfiguration { get; set; }

            /// <summary>
            /// Tags
            /// Key-value pairs that will be attached to the new private CA. You can associate up to 50 tags with a
            /// private CA. For information using tags with IAM to manage permissions, see Controlling Access Using
            /// IAM Tags.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// CsrExtensions
            /// 		
            /// Specifies information to be added to the extension section of the certificate signing 			request
            /// (CSR).
            /// 	
            /// Required: No
            /// Type: CsrExtensions
            /// Update requires: Replacement
            /// </summary>
            public CsrExtensions CsrExtensions { get; set; }

            /// <summary>
            /// KeyStorageSecurityStandard
            /// 		
            /// Specifies a 			cryptographic key management compliance standard used for handling CA keys.
            /// 		
            /// Default: FIPS_140_2_LEVEL_3_OR_HIGHER
            /// 		
            /// Note: FIPS_140_2_LEVEL_3_OR_HIGHER is not supported in Region 			ap-northeast-3. When creating a CA
            /// in the ap-northeast-3, you must provide 				FIPS_140_2_LEVEL_2_OR_HIGHER as the argument for
            /// 				KeyStorageSecurityStandard. Failure to do this results in an 				InvalidArgsException with the
            /// message, &quot;A certificate authority cannot 			be created in this region with the specified security
            /// standard. &quot;
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: FIPS_140_2_LEVEL_2_OR_HIGHER | FIPS_140_2_LEVEL_3_OR_HIGHER
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KeyStorageSecurityStandard { get; set; }

        }

        public string Type { get; } = "AWS::ACMPCA::CertificateAuthority";

        public CertificateAuthorityProperties Properties { get; } = new CertificateAuthorityProperties();

    }

    public static class CertificateAuthorityAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CertificateSigningRequest = new ResourceAttribute<Union<string, IntrinsicFunction>>("CertificateSigningRequest");
    }
}
