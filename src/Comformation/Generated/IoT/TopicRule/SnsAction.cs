using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule SnsAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-snsaction.html
    /// </summary>
    public class SnsAction
    {

        /// <summary>
        /// TargetArn
        /// The ARN of the SNS topic.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetArn")]
        public Union<string, IntrinsicFunction> TargetArn { get; set; }

        /// <summary>
        /// MessageFormat
        /// (Optional) The message format of the message to publish. Accepted values are &quot;JSON&quot; and &quot;RAW&quot;. The
        /// default value of the attribute is &quot;RAW&quot;. SNS uses this setting to determine if the payload should be
        /// parsed and relevant platform-specific bits of the payload should be extracted. For more information,
        /// see Amazon SNS Message and JSON Formats in the Amazon Simple Notification Service Developer Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MessageFormat")]
        public Union<string, IntrinsicFunction> MessageFormat { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
