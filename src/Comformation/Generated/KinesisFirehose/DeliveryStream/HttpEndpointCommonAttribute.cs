using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream HttpEndpointCommonAttribute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointcommonattribute.html
    /// </summary>
    public class HttpEndpointCommonAttribute
    {

        /// <summary>
        /// AttributeName
        /// The name of the HTTP endpoint common attribute.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: ^(?!\s*$). +
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeName")]
        public Union<string, IntrinsicFunction> AttributeName { get; set; }

        /// <summary>
        /// AttributeValue
        /// The value of the HTTP endpoint common attribute.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1024
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeValue")]
        public Union<string, IntrinsicFunction> AttributeValue { get; set; }

    }
}
