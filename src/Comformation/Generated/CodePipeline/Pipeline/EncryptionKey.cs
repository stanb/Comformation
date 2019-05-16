using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline EncryptionKey
    /// Represents information about the key used to encrypt data in the artifact store, such as an AWS Key Management
    /// Service (AWS KMS) key.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstore-encryptionkey.html
    /// </summary>
    public class EncryptionKey
    {

        /// <summary>
        /// Id
        /// The ID used to identify the key. For an AWS KMS key, this is the key ID or key ARN.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Type
        /// The type of encryption key, such as an AWS Key Management Service (AWS KMS) key. When creating or
        /// updating a pipeline, the value must be set to &#39;KMS&#39;.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
