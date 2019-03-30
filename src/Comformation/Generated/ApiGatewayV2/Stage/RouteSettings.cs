using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Stage
{
    /// <summary>
    /// RouteSettings
    /// The RouteSettings property type is a mapping of RouteId to RouteSettings that specifies route settings for an
    /// API Gateway stage.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-stage-routesettings.html
    /// </summary>
    public class RouteSettings
    {

        /// <summary>
        /// LoggingLevel
        /// Specifies the logging level for this route: DEBUG, INFO, or WARN. This property affects the log
        /// entries pushed to Amazon CloudWatch Logs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoggingLevel")]
        public Union<string, IntrinsicFunction> LoggingLevel { get; set; }

        /// <summary>
        /// DataTraceEnabled
        /// Specifies whether (true) or not (false) data trace logging is enabled for this route. This property
        /// affects the log entries pushed to Amazon CloudWatch Logs.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataTraceEnabled")]
        public Union<bool, IntrinsicFunction> DataTraceEnabled { get; set; }

        /// <summary>
        /// ThrottlingBurstLimit
        /// Specifies the throttling burst limit.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThrottlingBurstLimit")]
        public Union<int, IntrinsicFunction> ThrottlingBurstLimit { get; set; }

        /// <summary>
        /// DetailedMetricsEnabled
        /// Specifies whether detailed metrics are enabled.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DetailedMetricsEnabled")]
        public Union<bool, IntrinsicFunction> DetailedMetricsEnabled { get; set; }

        /// <summary>
        /// ThrottlingRateLimit
        /// Specifies the throttling rate limit.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThrottlingRateLimit")]
        public Union<double, IntrinsicFunction> ThrottlingRateLimit { get; set; }

    }
}
