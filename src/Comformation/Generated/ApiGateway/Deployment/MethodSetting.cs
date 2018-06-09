using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Deployment
{
    /// <summary>
    /// Amazon API Gateway Deployment MethodSetting
    /// The MethodSetting property type configures settings for all methods in an Amazon API Gateway (API Gateway)
    /// stage.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription-methodsetting.html
    /// </summary>
    public class MethodSetting
    {

        /// <summary>
        /// CacheDataEncrypted
        /// Indicates whether the cached responses are encrypted.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("CacheDataEncrypted")]
        public Union<bool, IntrinsicFunction> CacheDataEncrypted { get; set; }

        /// <summary>
        /// CacheTtlInSeconds
        /// The time-to-live (TTL) period, in seconds, that specifies how long API Gateway caches responses.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("CacheTtlInSeconds")]
        public Union<int, IntrinsicFunction> CacheTtlInSeconds { get; set; }

        /// <summary>
        /// CachingEnabled
        /// Indicates whether responses are cached and returned for requests. You must enable a cache cluster on
        /// the stage to cache responses. For more information, see Enable API Gateway Caching in a Stage to
        /// Enhance API Performance in the API Gateway Developer Guide.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("CachingEnabled")]
        public Union<bool, IntrinsicFunction> CachingEnabled { get; set; }

        /// <summary>
        /// DataTraceEnabled
        /// Indicates whether data trace logging is enabled for methods in the stage. API Gateway pushes these
        /// logs to Amazon CloudWatch Logs.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("DataTraceEnabled")]
        public Union<bool, IntrinsicFunction> DataTraceEnabled { get; set; }

        /// <summary>
        /// HttpMethod
        /// The HTTP method.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("HttpMethod")]
        public Union<string, IntrinsicFunction> HttpMethod { get; set; }

        /// <summary>
        /// LoggingLevel
        /// The logging level for this method. For valid values, see the loggingLevel property of the Stage
        /// resource in the Amazon API Gateway API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("LoggingLevel")]
        public Union<string, IntrinsicFunction> LoggingLevel { get; set; }

        /// <summary>
        /// MetricsEnabled
        /// Indicates whether Amazon CloudWatch metrics are enabled for methods in the stage.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("MetricsEnabled")]
        public Union<bool, IntrinsicFunction> MetricsEnabled { get; set; }

        /// <summary>
        /// ResourcePath
        /// The resource path for this method. Forward slashes (/) are encoded as ~1 and the initial slash must
        /// include a forward slash. For example, the path value /resource/subresource must be encoded as
        /// /~1resource~1subresource. To specify the root path, use only a slash (/).
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ResourcePath")]
        public Union<string, IntrinsicFunction> ResourcePath { get; set; }

        /// <summary>
        /// ThrottlingBurstLimit
        /// The number of burst requests per second that API Gateway permits across all APIs, stages, and
        /// methods in your AWS account. For more information, see Manage API Request Throttling in the API
        /// Gateway Developer Guide.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("ThrottlingBurstLimit")]
        public Union<int, IntrinsicFunction> ThrottlingBurstLimit { get; set; }

        /// <summary>
        /// ThrottlingRateLimit
        /// The number of steady-state requests per second that API Gateway permits across all APIs, stages, and
        /// methods in your AWS account. For more information, see Manage API Request Throttling in the API
        /// Gateway Developer Guide.
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("ThrottlingRateLimit")]
        public Union<double, IntrinsicFunction> ThrottlingRateLimit { get; set; }

    }
}
