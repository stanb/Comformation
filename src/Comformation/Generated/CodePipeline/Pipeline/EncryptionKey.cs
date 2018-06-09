using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS CodePipeline Pipeline ArtifactStore EncryptionKey
    /// EncryptionKey is a property of the AWS CodePipeline Pipeline ArtifactStore property that specifies which key
    /// AWS CodePipeline uses to encrypt data in the artifact store, such as an AWS Key Management Service (AWS KMS)
    /// key.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstore-encryptionkey.html
    /// </summary>
    public class EncryptionKey
    {

        /// <summary>
        /// Id
        /// The ID of the key. For an AWS KMS key, specify the key ID or key Amazon Resource Number (ARN).
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Type
        /// The type of encryption key, such as KMS. For valid values, see EncryptionKey in the AWS CodePipeline
        /// API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
