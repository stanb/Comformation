using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.Pipeline
{
    /// <summary>
    /// AWS::CodePipeline::Pipeline ArtifactStore
    /// The Amazon S3 bucket where artifacts for the pipeline are stored.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-pipeline-artifactstore.html
    /// </summary>
    public class ArtifactStore
    {

        /// <summary>
        /// EncryptionKey
        /// The encryption key used to encrypt the data in the artifact store, such as an AWS Key Management
        /// Service (AWS KMS) key. If this is undefined, the default key for Amazon S3 is used.
        /// Required: No
        /// Type: EncryptionKey
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncryptionKey")]
        public EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// Location
        /// The Amazon S3 bucket used for storing the artifacts for a pipeline. You can specify the name of an
        /// S3 bucket but not a folder in the bucket. A folder to contain the pipeline artifacts is created for
        /// you based on the name of the pipeline. You can use any Amazon S3 bucket in the same AWS Region as
        /// the pipeline to store your pipeline artifacts.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: [a-zA-Z0-9\-\. ]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

        /// <summary>
        /// Type
        /// The type of the artifact store, such as S3.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
