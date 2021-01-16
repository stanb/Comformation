using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule IotEventsAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-ioteventsaction.html
    /// </summary>
    public class IotEventsAction
    {

        /// <summary>
        /// InputName
        /// The name of the AWS IoT Events input.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputName")]
        public Union<string, IntrinsicFunction> InputName { get; set; }

        /// <summary>
        /// MessageId
        /// The ID of the message. The default messageId is a new UUID value.
        /// When batchMode is true, you can&#39;t specify a messageId--a new UUID value will be assigned.
        /// Assign a value to this property to ensure that only one input (message) with a given messageId will
        /// be processed by an AWS IoT Events detector.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageId")]
        public Union<string, IntrinsicFunction> MessageId { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role that grants AWS IoT permission to send an input to an AWS IoT Events detector.
        /// (&quot;Action&quot;:&quot;iotevents:BatchPutMessage&quot;).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
