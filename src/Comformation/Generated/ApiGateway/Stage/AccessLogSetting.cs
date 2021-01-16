using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Stage
{
    /// <summary>
    /// AWS::ApiGateway::Stage AccessLogSetting
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-stage-accesslogsetting.html
    /// </summary>
    public class AccessLogSetting
    {

        /// <summary>
        /// DestinationArn
        /// The Amazon Resource Name (ARN) of the CloudWatch Logs log group or Kinesis Data Firehose delivery
        /// stream to receive access logs. If you specify a Kinesis Data Firehose delivery stream, the stream
        /// name must begin with amazon-apigateway-. This parameter is required to enable access logging.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationArn")]
        public Union<string, IntrinsicFunction> DestinationArn { get; set; }

        /// <summary>
        /// Format
        /// A single line format of the access logs of data, as specified by selected $context variables. The
        /// format must include at least $context. requestId. This parameter is required to enable access
        /// logging.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Format")]
        public Union<string, IntrinsicFunction> Format { get; set; }

    }
}
