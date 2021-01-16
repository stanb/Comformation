using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Cluster
{
    /// <summary>
    /// AWS::EKS::Cluster EncryptionConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-encryptionconfig.html
    /// </summary>
    public class EncryptionConfig
    {

        /// <summary>
        /// Resources
        /// Specifies the resources to be encrypted. The only supported value is &quot;secrets&quot;.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Resources")]
        public List<Union<string, IntrinsicFunction>> Resources { get; set; }

        /// <summary>
        /// Provider
        /// The encryption provider for the cluster.
        /// Required: No
        /// Type: Provider
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Provider")]
        public Provider Provider { get; set; }

    }
}
