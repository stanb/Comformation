using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream HttpEndpointRequestConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointrequestconfiguration.html
    /// </summary>
    public class HttpEndpointRequestConfiguration
    {

        /// <summary>
        /// ContentEncoding
        /// Kinesis Data Firehose uses the content encoding to compress the body of a request before sending the
        /// request to the destination. For more information, see Content-Encoding in MDN Web Docs, the official
        /// Mozilla documentation.
        /// Required: No
        /// Type: String
        /// Allowed values: GZIP | NONE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContentEncoding")]
        public Union<string, IntrinsicFunction> ContentEncoding { get; set; }

        /// <summary>
        /// CommonAttributes
        /// Describes the metadata sent to the HTTP endpoint destination.
        /// Required: No
        /// Type: List of HttpEndpointCommonAttribute
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CommonAttributes")]
        public List<HttpEndpointCommonAttribute> CommonAttributes { get; set; }

    }
}
