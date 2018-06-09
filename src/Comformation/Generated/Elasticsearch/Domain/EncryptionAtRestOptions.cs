using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Elasticsearch.Domain
{
    /// <summary>
    /// Amazon Elasticsearch Service Domain EncryptionAtRestOptions
    /// The EncryptionAtRestOptions property type specifies whether the domain should encrypt data at rest, and if so,
    /// the AWS Key Management Service (KMS) key to use. Can only be used to create a new domain, not update an
    /// existing one.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-encryptionatrestoptions.html
    /// </summary>
    public class EncryptionAtRestOptions
    {

        /// <summary>
        /// Enabled
        /// Specify true to enable encryption at rest.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// KmsKeyId
        /// The KMS key ID. Takes the form 1a2a3a4-1a2a-3a4a-5a6a-1a2a3a4a5a6a.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

    }
}
