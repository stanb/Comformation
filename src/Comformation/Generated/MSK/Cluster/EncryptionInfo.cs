using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster EncryptionInfo
    /// Includes encryption-related information, such as the AWS KMS key used for encrypting data at rest and whether
    /// you want MSK to encrypt your data in transit.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptioninfo.html
    /// </summary>
    public class EncryptionInfo
    {

        /// <summary>
        /// EncryptionAtRest
        /// The data-volume encryption details.
        /// Required: No
        /// Type: EncryptionAtRest
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EncryptionAtRest")]
        public EncryptionAtRest EncryptionAtRest { get; set; }

        /// <summary>
        /// EncryptionInTransit
        /// The details for encryption in transit.
        /// Required: No
        /// Type: EncryptionInTransit
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EncryptionInTransit")]
        public EncryptionInTransit EncryptionInTransit { get; set; }

    }
}
