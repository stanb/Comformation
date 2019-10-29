using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSetEventDestination KinesisFirehoseDestination
    /// An object that defines an Amazon Kinesis Data Firehose destination for email events. You can use Amazon
    /// Kinesis Data Firehose to stream data to other services, such as Amazon S3 and Amazon Redshift.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-kinesisfirehosedestination.html
    /// </summary>
    public class KinesisFirehoseDestination
    {

        /// <summary>
        /// DeliveryStreamArn
        /// The Amazon Resource Name (ARN) of the Amazon Kinesis Data Firehose stream that Amazon Pinpoint sends
        /// email events to.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeliveryStreamArn")]
        public Union<string, IntrinsicFunction> DeliveryStreamArn { get; set; }

        /// <summary>
        /// IamRoleArn
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon Pinpoint uses when sending email events
        /// to the Amazon Kinesis Data Firehose stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamRoleArn")]
        public Union<string, IntrinsicFunction> IamRoleArn { get; set; }

    }
}
