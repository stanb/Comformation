using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream DeliveryStreamEncryptionConfigurationInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-deliverystreamencryptionconfigurationinput.html
    /// </summary>
    public class DeliveryStreamEncryptionConfigurationInput
    {

        /// <summary>
        /// KeyARN
        /// If you set KeyType to CUSTOMER_MANAGED_CMK, you must specify the Amazon Resource Name (ARN) of the
        /// CMK. If you set KeyType to AWS_OWNED_CMK, Kinesis Data Firehose uses a service-account CMK.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: arn:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyARN")]
        public Union<string, IntrinsicFunction> KeyARN { get; set; }

        /// <summary>
        /// KeyType
        /// Indicates the type of customer master key (CMK) to use for encryption. The default setting is
        /// AWS_OWNED_CMK. For more information about CMKs, see Customer Master Keys (CMKs).
        /// You can use a CMK of type CUSTOMER_MANAGED_CMK to encrypt up to 500 delivery streams.
        /// Important To encrypt your delivery stream, use symmetric CMKs. Kinesis Data Firehose doesn&#39;t support
        /// asymmetric CMKs. For information about symmetric and asymmetric CMKs, see About Symmetric and
        /// Asymmetric CMKs in the AWS Key Management Service developer guide.
        /// Required: Yes
        /// Type: String
        /// Allowed values: AWS_OWNED_CMK | CUSTOMER_MANAGED_CMK
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyType")]
        public Union<string, IntrinsicFunction> KeyType { get; set; }

    }
}
