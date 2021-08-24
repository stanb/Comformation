using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate PolicyInformation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyinformation.html
    /// </summary>
    public class PolicyInformation
    {

        /// <summary>
        /// CertPolicyId
        /// 		
        /// Specifies the object identifier (OID) of the certificate policy under which the 			certificate was
        /// issued. For more information, see NIST&#39;s definition of Object Identifier 				(OID).
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 64
        /// Pattern: ^([0-2])\. ([0-9]|([0-3][0-9]))((\. ([0-9]+)){0,126})$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CertPolicyId")]
        public Union<string, IntrinsicFunction> CertPolicyId { get; set; }

        /// <summary>
        /// PolicyQualifiers
        /// 		
        /// Modifies the given CertPolicyId with a qualifier. ACM Private CA supports the 			certification
        /// practice statement (CPS) qualifier.
        /// 	
        /// Required: No
        /// Type: List of PolicyQualifierInfo
        /// Maximum: 20
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PolicyQualifiers")]
        public List<PolicyQualifierInfo> PolicyQualifiers { get; set; }

    }
}
