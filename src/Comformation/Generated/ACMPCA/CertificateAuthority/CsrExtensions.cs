using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority CsrExtensions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-csrextensions.html
    /// </summary>
    public class CsrExtensions
    {

        /// <summary>
        /// KeyUsage
        /// 		
        /// Indicates the purpose of 			the certificate and of the key contained in the certificate.
        /// 	
        /// Required: No
        /// Type: KeyUsage
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KeyUsage")]
        public KeyUsage KeyUsage { get; set; }

        /// <summary>
        /// SubjectInformationAccess
        /// 		
        /// For CA 			certificates, provides a path to additional information pertaining to the CA, such as
        /// 			revocation and policy. For more information, see Subject Information 				Access in RFC 5280.
        /// 	
        /// Required: No
        /// Type: SubjectInformationAccess
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("SubjectInformationAccess")]
        public SubjectInformationAccess SubjectInformationAccess { get; set; }

    }
}
