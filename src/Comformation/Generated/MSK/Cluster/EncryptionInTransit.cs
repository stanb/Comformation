using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster EncryptionInTransit
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptionintransit.html
    /// </summary>
    public class EncryptionInTransit
    {

        /// <summary>
        /// ClientBroker
        /// Indicates the encryption setting for data in transit between clients and brokers. The following are
        /// the possible values.
        /// TLS means that client-broker communication is enabled with TLS only. TLS_PLAINTEXT means that
        /// client-broker communication is enabled for both TLS-encrypted, as well as plaintext data. PLAINTEXT
        /// means that client-broker communication is enabled in plaintext only.
        /// The default value is TLS.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ClientBroker")]
        public Union<string, IntrinsicFunction> ClientBroker { get; set; }

        /// <summary>
        /// InCluster
        /// When set to true, it indicates that data communication among the broker nodes of the cluster is
        /// encrypted. When set to false, the communication happens in plaintext. The default value is true.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InCluster")]
        public Union<bool, IntrinsicFunction> InCluster { get; set; }

    }
}
