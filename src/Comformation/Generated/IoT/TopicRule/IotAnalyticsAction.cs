using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule IotAnalyticsAction
    /// Sends message data to an AWS IoT Analytics channel.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-iotanalyticsaction.html
    /// </summary>
    public class IotAnalyticsAction
    {

        /// <summary>
        /// ChannelName
        /// The name of the IoT Analytics channel to which message data will be sent.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelName")]
        public Union<string, IntrinsicFunction> ChannelName { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role which has a policy that grants IoT Analytics permission to send message data via
        /// IoT Analytics (iotanalytics:BatchPutMessage).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
