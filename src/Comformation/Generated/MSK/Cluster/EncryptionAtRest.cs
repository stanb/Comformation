using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster EncryptionAtRest
    /// The data volume encryption details.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-encryptionatrest.html
    /// </summary>
    public class EncryptionAtRest
    {

        /// <summary>
        /// DataVolumeKMSKeyId
        /// The ARN of the AWS KMS key for encrypting data at rest. If you don&#39;t specify a KMS key, MSK creates
        /// one for you and uses it on your behalf.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DataVolumeKMSKeyId")]
        public Union<string, IntrinsicFunction> DataVolumeKMSKeyId { get; set; }

    }
}