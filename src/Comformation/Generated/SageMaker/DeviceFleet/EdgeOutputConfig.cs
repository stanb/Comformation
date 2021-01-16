using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.DeviceFleet
{
    /// <summary>
    /// AWS::SageMaker::DeviceFleet EdgeOutputConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-devicefleet-edgeoutputconfig.html
    /// </summary>
    public class EdgeOutputConfig
    {

        /// <summary>
        /// S3OutputLocation
        /// The Amazon Simple Storage (S3) bucker URI.
        /// Required: Yes
        /// Type: String
        /// Maximum: 1024
        /// Pattern: ^(https|s3)://([^/]+)/?(. *)$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3OutputLocation")]
        public Union<string, IntrinsicFunction> S3OutputLocation { get; set; }

        /// <summary>
        /// KmsKeyId
        /// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt data on the
        /// storage volume after compilation job. If you don&#39;t provide a KMS key ID, Amazon SageMaker uses the
        /// default KMS key for Amazon S3 for your role&#39;s account.
        /// Required: No
        /// Type: String
        /// Maximum: 2048
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

    }
}
