using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule RepublishAction
    /// Republish is a property of the Actions property that describes an action that publishes data to an MQ
    /// Telemetry Transport (MQTT) topic different from the one currently specified.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-republishaction.html
    /// </summary>
    public class RepublishAction
    {

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants publishing access.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Topic
        /// The name of the MQTT topic topic different from the one currently specified.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Topic")]
        public Union<string, IntrinsicFunction> Topic { get; set; }

    }
}
