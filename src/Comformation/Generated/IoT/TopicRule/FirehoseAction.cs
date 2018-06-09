using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule FirehoseAction
    /// Firehose is a property of the Actions property that describes an action that writes data to a Kinesis Data
    /// Firehose stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-firehoseaction.html
    /// </summary>
    public class FirehoseAction
    {

        /// <summary>
        /// DeliveryStreamName
        /// The delivery stream name.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DeliveryStreamName")]
        public Union<string, IntrinsicFunction> DeliveryStreamName { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the IAM role that grants access to the Kinesis Data Firehose
        /// stream.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Separator
        /// A character separator that&#39;s used to separate records written to the Kinesis Data Firehose stream.
        /// For valid values, see Firehose Action in the AWS IoT Developer Guide.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Separator")]
        public Union<string, IntrinsicFunction> Separator { get; set; }

    }
}
