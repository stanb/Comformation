using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS CodePipeline Pipeline ArtifactStore
    /// ArtifactStore is a property of the AWS::CodePipeline::Pipeline resource that defines the S3 location where AWS
    /// CodePipeline stores pipeline artifacts.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstore.html
    /// </summary>
    public class ArtifactStore
    {

        /// <summary>
        /// EncryptionKey
        /// The encryption key AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS
        /// Key Management Service (AWS KMS) key. If you don&#39;t specify a key, AWS CodePipeline uses the default
        /// key for Amazon Simple Storage Service (Amazon S3).
        /// Required: No
        /// Type: AWS CodePipeline Pipeline ArtifactStore EncryptionKey
        /// </summary>
        [JsonProperty("EncryptionKey")]
        public Union<EncryptionKey, IntrinsicFunction> EncryptionKey { get; set; }

        /// <summary>
        /// Location
        /// The location where AWS CodePipeline stores artifacts for a pipeline, such as an S3 bucket.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

        /// <summary>
        /// Type
        /// The type of the artifact store, such as Amazon S3. For valid values, see ArtifactStore in the AWS
        /// CodePipeline API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
