using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.CertificateAuthority
{
    /// <summary>
    /// AWS::ACMPCA::CertificateAuthority AccessMethod
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificateauthority-accessmethod.html
    /// </summary>
    public class AccessMethod
    {

        /// <summary>
        /// CustomObjectIdentifier
        /// 		 		
        /// An object identifier (OID) specifying the AccessMethod. The OID must 			satisfy the regular
        /// expression shown below. For more information, see NIST&#39;s definition 			of Object Identifier
        /// 				(OID).
        /// 		 	
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 64
        /// Pattern: ^([0-2])\. ([0-9]|([0-3][0-9]))((\. ([0-9]+)){0,126})$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CustomObjectIdentifier")]
        public Union<string, IntrinsicFunction> CustomObjectIdentifier { get; set; }

        /// <summary>
        /// AccessMethodType
        /// 		
        /// Specifies 			the AccessMethod.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: CA_REPOSITORY | RESOURCE_PKI_MANIFEST | RESOURCE_PKI_NOTIFY
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AccessMethodType")]
        public Union<string, IntrinsicFunction> AccessMethodType { get; set; }

    }
}
