using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline EncryptionKey
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstore-encryptionkey.html
    /// </summary>
    public class EncryptionKey
    {

        /// <summary>
        /// Id
        /// The ID used to identify the key. For an AWS KMS key, you can use the key ID, the key ARN, or the
        /// alias ARN.
        /// Note Aliases are recognized only in the account that created the customer master key (CMK). For
        /// cross-account actions, you can only use the key ID or key ARN to identify the key.
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
