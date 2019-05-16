using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::SES::ConfigurationSetEventDestination KinesisFirehoseDestination
    /// Contains the delivery stream ARN and the IAM role ARN associated with an Amazon Kinesis Data Firehose event
    /// destination.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-kinesisfirehosedestination.html
    /// </summary>
    public class KinesisFirehoseDestination
    {

        /// <summary>
        /// IAMRoleARN
        /// The ARN of the IAM role that Amazon SES uses to publish email sending events to the Amazon Kinesis
        /// Data Firehose stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IAMRoleARN")]
        public Union<string, IntrinsicFunction> IAMRoleARN { get; set; }

        /// <summary>
        /// DeliveryStreamARN
        /// The ARN of the Amazon Kinesis Data Firehose stream that email sending events should be published to.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeliveryStreamARN")]
        public Union<string, IntrinsicFunction> DeliveryStreamARN { get; set; }

    }
}
