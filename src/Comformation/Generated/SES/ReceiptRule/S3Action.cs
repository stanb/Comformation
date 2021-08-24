using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule S3Action
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html
    /// </summary>
    public class S3Action
    {

        /// <summary>
        /// BucketName
        /// The name of the Amazon S3 bucket for incoming email.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// KmsKeyArn
        /// The customer master key that Amazon SES should use to encrypt your emails before saving them to the
        /// Amazon S3 bucket. You can use the default master key or a custom master key that you created in AWS
        /// KMS as follows:
        /// To use the default master key, provide an ARN in the form of
        /// arn:aws:kms:REGION:ACCOUNT-ID-WITHOUT-HYPHENS:alias/aws/ses. For example, if your AWS account ID is
        /// 123456789012 and you want to use the default master key in the US West (Oregon) Region, the ARN of
        /// the default master key would be arn:aws:kms:us-west-2:123456789012:alias/aws/ses. If you use the
        /// default master key, you don&#39;t need to perform any extra steps to give Amazon SES permission to use
        /// the key. To use a custom master key that you created in AWS KMS, provide the ARN of the master key
        /// and ensure that you add a statement to your key&#39;s policy to give Amazon SES permission to use it.
        /// For more information about giving permissions, see the Amazon SES Developer Guide.
        /// For more information about key policies, see the AWS KMS Developer Guide. If you do not specify a
        /// master key, Amazon SES does not encrypt your emails.
        /// Important Your mail is encrypted by Amazon SES using the Amazon S3 encryption client before the mail
        /// is submitted to Amazon S3 for storage. It is not encrypted using Amazon S3 server-side encryption.
        /// This means that you must use the Amazon S3 encryption client to decrypt the email after retrieving
        /// it from Amazon S3, as the service has no access to use your AWS KMS keys for decryption. This
        /// encryption client is currently available with the AWS SDK for Java and AWS SDK for Ruby only. For
        /// more information about client-side encryption using AWS KMS master keys, see the Amazon S3 Developer
        /// Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KmsKeyArn")]
        public Union<string, IntrinsicFunction> KmsKeyArn { get; set; }

        /// <summary>
        /// TopicArn
        /// The ARN of the Amazon SNS topic to notify when the message is saved to the Amazon S3 bucket. You can
        /// find the ARN of a topic by using the ListTopics operation in Amazon SNS.
        /// For more information about Amazon SNS topics, see the Amazon SNS Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TopicArn")]
        public Union<string, IntrinsicFunction> TopicArn { get; set; }

        /// <summary>
        /// ObjectKeyPrefix
        /// The key prefix of the Amazon S3 bucket. The key prefix is similar to a directory name that enables
        /// you to store similar data under the same directory in a bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectKeyPrefix")]
        public Union<string, IntrinsicFunction> ObjectKeyPrefix { get; set; }

    }
}
