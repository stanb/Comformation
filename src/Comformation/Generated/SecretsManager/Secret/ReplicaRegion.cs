using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.Secret
{
    /// <summary>
    /// AWS::SecretsManager::Secret ReplicaRegion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-secret-replicaregion.html
    /// </summary>
    public class ReplicaRegion
    {

        /// <summary>
        /// KmsKeyId
        /// Can be an ARN, Key ID, or Alias.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

        /// <summary>
        /// Region
        /// (Optional) Custom type consisting of a Region (required) and the KmsKeyId which can be an ARN, Key
        /// ID, or Alias.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Region")]
        public Union<string, IntrinsicFunction> Region { get; set; }

    }
}
