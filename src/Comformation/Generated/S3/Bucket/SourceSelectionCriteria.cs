using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket SourceSelectionCriteria
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-sourceselectioncriteria.html
    /// </summary>
    public class SourceSelectionCriteria
    {

        /// <summary>
        /// ReplicaModifications
        /// A filter that you can specify for selection for modifications on replicas.
        /// Required: No
        /// Type: ReplicaModifications
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplicaModifications")]
        public ReplicaModifications ReplicaModifications { get; set; }

        /// <summary>
        /// SseKmsEncryptedObjects
        /// A container for filter information for the selection of Amazon S3 objects encrypted with AWS KMS.
        /// Required: No
        /// Type: SseKmsEncryptedObjects
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SseKmsEncryptedObjects")]
        public SseKmsEncryptedObjects SseKmsEncryptedObjects { get; set; }

    }
}
