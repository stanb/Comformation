using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate Extensions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extensions.html
    /// </summary>
    public class Extensions
    {

        /// <summary>
        /// CertificatePolicies
        /// 		
        /// Contains a sequence of one or more policy information terms, each of which consists of 			an object
        /// identifier (OID) and optional qualifiers. For more information, see NIST&#39;s 			definition of Object
        /// 				Identifier (OID).
        /// 		
        /// In an end-entity certificate, these terms indicate the policy under which the 			certificate was
        /// issued and the purposes for which it may be used. In a CA certificate, 			these terms limit the set
        /// of policies for certification paths that include this 			certificate.
        /// 	
        /// Required: No
        /// Type: List of PolicyInformation
        /// Maximum: 20
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CertificatePolicies")]
        public List<PolicyInformation> CertificatePolicies { get; set; }

        /// <summary>
        /// ExtendedKeyUsage
        /// 		
        /// Specifies additional purposes for which the certified public key may be used other 			than basic
        /// purposes indicated in the KeyUsage extension.
        /// 	
        /// Required: No
        /// Type: List of ExtendedKeyUsage
        /// Maximum: 20
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ExtendedKeyUsage")]
        public List<ExtendedKeyUsage> ExtendedKeyUsage { get; set; }

        /// <summary>
        /// KeyUsage
        /// Defines one or more purposes for which the key contained in the certificate can be used. Default
        /// value for each option is false.
        /// Required: No
        /// Type: KeyUsage
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KeyUsage")]
        public KeyUsage KeyUsage { get; set; }

        /// <summary>
        /// SubjectAlternativeNames
        /// 		
        /// The subject alternative name extension allows identities to be bound to the subject of 			the
        /// certificate. These identities may be included in addition to or in place of the 			identity in the
        /// subject field of the certificate.
        /// 	
        /// Required: No
        /// Type: List of GeneralName
        /// Maximum: 20
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SubjectAlternativeNames")]
        public List<GeneralName> SubjectAlternativeNames { get; set; }

    }
}
