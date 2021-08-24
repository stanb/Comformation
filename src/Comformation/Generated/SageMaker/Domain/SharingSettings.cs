using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Domain
{
    /// <summary>
    /// AWS::SageMaker::Domain SharingSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-sharingsettings.html
    /// </summary>
    public class SharingSettings
    {

        /// <summary>
        /// NotebookOutputOption
        /// Whether to include the notebook cell output when sharing the notebook. The default is Disabled.
        /// Required: No
        /// Type: String
        /// Allowed values: Allowed | Disabled
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotebookOutputOption")]
        public Union<string, IntrinsicFunction> NotebookOutputOption { get; set; }

        /// <summary>
        /// S3KmsKeyId
        /// When NotebookOutputOption is Allowed, the AWS Key Management Service (KMS) encryption key ID used to
        /// encrypt the notebook cell output in the Amazon S3 bucket.
        /// Required: No
        /// Type: String
        /// Maximum: 2048
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3KmsKeyId")]
        public Union<string, IntrinsicFunction> S3KmsKeyId { get; set; }

        /// <summary>
        /// S3OutputPath
        /// When NotebookOutputOption is Allowed, the Amazon S3 bucket used to store the shared notebook
        /// snapshots.
        /// Required: No
        /// Type: String
        /// Maximum: 1024
        /// Pattern: ^(https|s3)://([^/]+)/?(. *)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3OutputPath")]
        public Union<string, IntrinsicFunction> S3OutputPath { get; set; }

    }
}
