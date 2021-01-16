using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.EndpointConfig
{
    /// <summary>
    /// AWS::SageMaker::EndpointConfig DataCaptureConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-datacaptureconfig.html
    /// </summary>
    public class DataCaptureConfig
    {

        /// <summary>
        /// CaptureOptions
        /// Specifies whether the endpoint captures input data to your model, output data from your model, or
        /// both.
        /// Required: Yes
        /// Type: List of CaptureOption
        /// Maximum: 2
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CaptureOptions")]
        public List<CaptureOption> CaptureOptions { get; set; }

        /// <summary>
        /// KmsKeyId
        /// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt the captured data
        /// at rest using Amazon S3 server-side encryption. The KmsKeyId can be any of the following formats:
        /// Key ID: 1234abcd-12ab-34cd-56ef-1234567890ab Key ARN:
        /// arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab Alias name:
        /// alias/ExampleAlias Alias name ARN: arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias If you
        /// don&#39;t provide a KMS key ID, Amazon SageMaker uses the default KMS key for Amazon S3 for your role&#39;s
        /// account. For more information, see KMS-Managed Encryption Keys (https://docs. aws. amazon.
        /// com/AmazonS3/latest/dev/UsingKMSEncryption. html) in the Amazon Simple Storage Service Developer
        /// Guide. The KMS key policy must grant permission to the IAM role that you specify in your CreateModel
        /// (https://docs. aws. amazon. com/sagemaker/latest/APIReference/API_CreateModel. html) request. For
        /// more information, see Using Key Policies in AWS KMS (http://docs. aws. amazon.
        /// com/kms/latest/developerguide/key-policies. html) in the AWS Key Management Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Maximum: 2048
        /// Pattern: . *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public Union<string, IntrinsicFunction> KmsKeyId { get; set; }

        /// <summary>
        /// DestinationS3Uri
        /// The S3 bucket where model monitor stores captured data.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: ^(https|s3)://([^/])/?(. *)$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DestinationS3Uri")]
        public Union<string, IntrinsicFunction> DestinationS3Uri { get; set; }

        /// <summary>
        /// InitialSamplingPercentage
        /// The percentage of data to capture.
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 100
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InitialSamplingPercentage")]
        public Union<int, IntrinsicFunction> InitialSamplingPercentage { get; set; }

        /// <summary>
        /// CaptureContentTypeHeader
        /// A list of the JSON and CSV content type that the endpoint captures.
        /// Required: No
        /// Type: CaptureContentTypeHeader
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CaptureContentTypeHeader")]
        public CaptureContentTypeHeader CaptureContentTypeHeader { get; set; }

        /// <summary>
        /// EnableCapture
        /// Set to True to enable data capture.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EnableCapture")]
        public Union<bool, IntrinsicFunction> EnableCapture { get; set; }

    }
}
