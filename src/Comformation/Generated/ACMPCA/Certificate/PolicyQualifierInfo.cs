using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate PolicyQualifierInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-policyqualifierinfo.html
    /// </summary>
    public class PolicyQualifierInfo
    {

        /// <summary>
        /// PolicyQualifierId
        /// 		
        /// Identifies the qualifier modifying a CertPolicyId.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: CPS
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("PolicyQualifierId")]
        public Union<string, IntrinsicFunction> PolicyQualifierId { get; set; }

        /// <summary>
        /// Qualifier
        /// 		
        /// Defines the qualifier type. ACM Private CA supports the use of a URI for a CPS qualifier in 			this
        /// field.
        /// 	
        /// Required: Yes
        /// Type: Qualifier
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Qualifier")]
        public Qualifier Qualifier { get; set; }

    }
}
