using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream KinesisStreamSourceConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html
    /// </summary>
    public class KinesisStreamSourceConfiguration
    {

        /// <summary>
        /// KinesisStreamARN
        /// The ARN of the source Kinesis data stream.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: arn:. *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KinesisStreamARN")]
        public Union<string, IntrinsicFunction> KinesisStreamARN { get; set; }

        /// <summary>
        /// RoleARN
        /// The ARN of the role that provides access to the source Kinesis data stream.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 512
        /// Pattern: arn:. *
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("RoleARN")]
        public Union<string, IntrinsicFunction> RoleARN { get; set; }

    }
}
