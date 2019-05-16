using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule RepublishAction
    /// Describes an action to republish to another topic.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-republishaction.html
    /// </summary>
    public class RepublishAction
    {

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Topic
        /// The name of the MQTT topic.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Topic")]
        public Union<string, IntrinsicFunction> Topic { get; set; }

    }
}
