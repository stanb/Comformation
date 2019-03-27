using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Stage
{
    /// <summary>
    /// AccessLogSettings
    /// The AccessLogSettings property type specifies access log settings for an API Gateway stage.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-accesslogsettings.html
    /// </summary>
    public class AccessLogSettings
    {

        /// <summary>
        /// Format
        /// A single line format of the access logs of data, as specified by selected $context variables. The
        /// format must include at least $context. requestId.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Format")]
        public Union<string, IntrinsicFunction> Format { get; set; }

        /// <summary>
        /// DestinationArn
        /// The ARN of the CloudWatch Logs log group to receive access logs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationArn")]
        public Union<string, IntrinsicFunction> DestinationArn { get; set; }

    }
}
