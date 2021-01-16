using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream HttpEndpointConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointconfiguration.html
    /// </summary>
    public class HttpEndpointConfiguration
    {

        /// <summary>
        /// Url
        /// The URL of the HTTP endpoint selected as the destination.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1000
        /// Pattern: https://. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

        /// <summary>
        /// AccessKey
        /// The access key required for Kinesis Firehose to authenticate with the HTTP endpoint selected as the
        /// destination.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 4096
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessKey")]
        public Union<string, IntrinsicFunction> AccessKey { get; set; }

        /// <summary>
        /// Name
        /// The name of the HTTP endpoint selected as the destination.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: ^(?!\s*$). +
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
