using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate ExtendedKeyUsage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-extendedkeyusage.html
    /// </summary>
    public class ExtendedKeyUsage
    {

        /// <summary>
        /// ExtendedKeyUsageType
        /// 		
        /// Specifies a standard ExtendedKeyUsage as defined as in RFC 5280.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: CERTIFICATE_TRANSPARENCY | CLIENT_AUTH | CODE_SIGNING | DOCUMENT_SIGNING |
        /// EMAIL_PROTECTION | OCSP_SIGNING | SERVER_AUTH | SMART_CARD_LOGIN | TIME_STAMPING
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ExtendedKeyUsageType")]
        public Union<string, IntrinsicFunction> ExtendedKeyUsageType { get; set; }

        /// <summary>
        /// ExtendedKeyUsageObjectIdentifier
        /// 		
        /// Specifies a custom ExtendedKeyUsage with an object identifier 			(OID).
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 64
        /// Pattern: ^([0-2])\. ([0-9]|([0-3][0-9]))((\. ([0-9]+)){0,126})$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ExtendedKeyUsageObjectIdentifier")]
        public Union<string, IntrinsicFunction> ExtendedKeyUsageObjectIdentifier { get; set; }

    }
}
