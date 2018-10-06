using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Deployment
{
    /// <summary>
    /// Amazon API Gateway Deployment AccessLogSetting
    /// The AccessLogSetting property type specifies settings for logging access in this stage.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-accesslogsetting.html
    /// </summary>
    public class AccessLogSetting
    {

        /// <summary>
        /// DestinationArn
        /// The Amazon Resource Name (ARN) of the CloudWatch Logs log group to receive access logs
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationArn")]
        public Union<string, IntrinsicFunction> DestinationArn { get; set; }

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

    }
}
