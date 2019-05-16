using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket EncryptionConfiguration
    /// Specifies encryption-related information for an Amazon S3 bucket that is a destination for replicated objects.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-encryptionconfiguration.html
    /// </summary>
    public class EncryptionConfiguration
    {

        /// <summary>
        /// ReplicaKmsKeyID
        /// Specifies the AWS KMS Key ID (Key ARN or Alias ARN) for the destination bucket. Amazon S3 uses this
        /// key to encrypt replica objects.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplicaKmsKeyID")]
        public Union<string, IntrinsicFunction> ReplicaKmsKeyID { get; set; }

    }
}
