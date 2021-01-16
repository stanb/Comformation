using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.SubscriptionDefinitionVersion
{
    /// <summary>
    /// AWS::Greengrass::SubscriptionDefinitionVersion Subscription
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinitionversion-subscription.html
    /// </summary>
    public class Subscription
    {

        /// <summary>
        /// Target
        /// The destination of the message. The value can be a thing ARN, the ARN of a Lambda function alias
        /// (recommended) or version, a connector ARN, cloud (which represents the AWS IoT cloud), or
        /// GGShadowService.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Target")]
        public Union<string, IntrinsicFunction> Target { get; set; }

        /// <summary>
        /// Id
        /// A descriptive or arbitrary ID for the subscription. This value must be unique within the
        /// subscription definition version. Maximum length is 128 characters with pattern [a-zA-Z0-9:_-]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// Source
        /// The originator of the message. The value can be a thing ARN, the ARN of a Lambda function alias
        /// (recommended) or version, a connector ARN, cloud (which represents the AWS IoT cloud), or
        /// GGShadowService.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Source")]
        public Union<string, IntrinsicFunction> Source { get; set; }

        /// <summary>
        /// Subject
        /// The MQTT topic used to route the message.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Subject")]
        public Union<string, IntrinsicFunction> Subject { get; set; }

    }
}
