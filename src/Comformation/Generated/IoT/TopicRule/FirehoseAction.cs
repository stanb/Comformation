using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule FirehoseAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-firehoseaction.html
    /// </summary>
    public class FirehoseAction
    {

        /// <summary>
        /// DeliveryStreamName
        /// The delivery stream name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeliveryStreamName")]
        public Union<string, IntrinsicFunction> DeliveryStreamName { get; set; }

        /// <summary>
        /// RoleArn
        /// The IAM role that grants access to the Amazon Kinesis Firehose stream.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Separator
        /// A character separator that will be used to separate records written to the Firehose stream. Valid
        /// values are: &#39;\n&#39; (newline), &#39;\t&#39; (tab), &#39;\r\n&#39; (Windows newline), &#39;,&#39; (comma).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Separator")]
        public Union<string, IntrinsicFunction> Separator { get; set; }

    }
}
