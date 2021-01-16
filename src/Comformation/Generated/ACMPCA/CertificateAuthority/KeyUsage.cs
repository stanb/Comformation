using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority KeyUsage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-keyusage.html
    /// </summary>
    public class KeyUsage
    {

        /// <summary>
        /// DigitalSignature
        /// 		
        /// 			Key can be used for digital signing.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DigitalSignature")]
        public Union<bool, IntrinsicFunction> DigitalSignature { get; set; }

        /// <summary>
        /// NonRepudiation
        /// 		
        /// Key 			can be used for non-repudiation.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("NonRepudiation")]
        public Union<bool, IntrinsicFunction> NonRepudiation { get; set; }

        /// <summary>
        /// KeyEncipherment
        /// 		
        /// Key 			can be used to encipher data.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KeyEncipherment")]
        public Union<bool, IntrinsicFunction> KeyEncipherment { get; set; }

        /// <summary>
        /// DataEncipherment
        /// 		
        /// Key 			can be used to decipher data.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DataEncipherment")]
        public Union<bool, IntrinsicFunction> DataEncipherment { get; set; }

        /// <summary>
        /// KeyAgreement
        /// 		
        /// Key 			can be used in a key-agreement protocol.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KeyAgreement")]
        public Union<bool, IntrinsicFunction> KeyAgreement { get; set; }

        /// <summary>
        /// KeyCertSign
        /// 		
        /// Key 			can be used to sign certificates.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KeyCertSign")]
        public Union<bool, IntrinsicFunction> KeyCertSign { get; set; }

        /// <summary>
        /// CRLSign
        /// 		
        /// Key 			can be used to sign CRLs.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CRLSign")]
        public Union<bool, IntrinsicFunction> CRLSign { get; set; }

        /// <summary>
        /// EncipherOnly
        /// 		
        /// Key 			can be used only to encipher data.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EncipherOnly")]
        public Union<bool, IntrinsicFunction> EncipherOnly { get; set; }

        /// <summary>
        /// DecipherOnly
        /// 		
        /// Key 			can be used only to decipher data.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DecipherOnly")]
        public Union<bool, IntrinsicFunction> DecipherOnly { get; set; }

    }
}
