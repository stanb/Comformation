using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ACMPCA.Certificate
{
    /// <summary>
    /// AWS::ACMPCA::Certificate ApiPassthrough
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-acmpca-certificate-apipassthrough.html
    /// </summary>
    public class ApiPassthrough
    {

        /// <summary>
        /// Extensions
        /// 		
        /// Specifies X. 509 extension information for a certificate.
        /// 	
        /// Required: No
        /// Type: Extensions
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Extensions")]
        public Extensions Extensions { get; set; }

        /// <summary>
        /// Subject
        /// Contains information about the certificate subject. The Subject field in the certificate identifies
        /// the entity that owns or controls the public key in the certificate. The entity can be a user,
        /// computer, device, or service. The Subject must contain an X. 500 distinguished name (DN). A DN is a
        /// sequence of relative distinguished names (RDNs). The RDNs are separated by commas in the
        /// certificate.
        /// Required: No
        /// Type: Subject
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subject")]
        public Subject Subject { get; set; }

    }
}
