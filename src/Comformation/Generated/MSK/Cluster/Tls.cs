using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster Tls
    /// Details for client authentication using TLS.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-tls.html
    /// </summary>
    public class Tls
    {

        /// <summary>
        /// CertificateAuthorityArnList
        /// List of ACM Certificate Authority ARNs.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CertificateAuthorityArnList")]
        public List<Union<string, IntrinsicFunction>> CertificateAuthorityArnList { get; set; }

    }
}
