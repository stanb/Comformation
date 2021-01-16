using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket EncryptionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-encryptionconfiguration.html
    /// </summary>
    public class EncryptionConfiguration
    {

        /// <summary>
        /// ReplicaKmsKeyID
        /// Specifies the ID (Key ARN or Alias ARN) of the customer managed customer master key (CMK) stored in
        /// AWS Key Management Service (KMS) for the destination bucket. Amazon S3 uses this key to encrypt
        /// replica objects. Amazon S3 only supports symmetric customer managed CMKs. For more information, see
        /// Using Symmetric and Asymmetric Keys in the AWS Key Management Service Developer Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ReplicaKmsKeyID")]
        public Union<string, IntrinsicFunction> ReplicaKmsKeyID { get; set; }

    }
}
