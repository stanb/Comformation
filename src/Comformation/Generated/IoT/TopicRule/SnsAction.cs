using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule SnsAction
    /// Sns is a property of the Actions property that describes an action that publishes data to an SNS topic.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-snsaction.html
    /// </summary>
    public class SnsAction
    {

        /// <summary>
        /// MessageFormat
        /// The format of the published message. Amazon SNS uses this setting to determine whether it should
        /// parse the payload and extract the platform-specific bits from the payload.
        /// For more information, see Appendix: Message and JSON Formats in the Amazon Simple Notification
        /// Service Developer Guide.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("MessageFormat")]
        public Union<string, IntrinsicFunction> MessageFormat { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to Amazon SNS.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// TargetArn
        /// The ARN of the Amazon SNS topic.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TargetArn")]
        public Union<string, IntrinsicFunction> TargetArn { get; set; }

    }
}
