using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Stage
{
    /// <summary>
    /// Amazon API Gateway Method MethodResponse
    /// MethodResponse is a property of the AWS::ApiGateway::Method resource that defines the responses that can be
    /// sent to the client who calls an Amazon API Gateway (API Gateway) method.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-methodresponse.html
    /// </summary>
    public class MethodSetting
    {

        /// <summary>
        /// CacheDataEncrypted
        /// </summary>
        [JsonProperty("CacheDataEncrypted")]
        public Union<bool, IntrinsicFunction> CacheDataEncrypted { get; set; }

        /// <summary>
        /// CacheTtlInSeconds
        /// </summary>
        [JsonProperty("CacheTtlInSeconds")]
        public Union<int, IntrinsicFunction> CacheTtlInSeconds { get; set; }

        /// <summary>
        /// CachingEnabled
        /// </summary>
        [JsonProperty("CachingEnabled")]
        public Union<bool, IntrinsicFunction> CachingEnabled { get; set; }

        /// <summary>
        /// DataTraceEnabled
        /// </summary>
        [JsonProperty("DataTraceEnabled")]
        public Union<bool, IntrinsicFunction> DataTraceEnabled { get; set; }

        /// <summary>
        /// HttpMethod
        /// </summary>
        [JsonProperty("HttpMethod")]
        public Union<string, IntrinsicFunction> HttpMethod { get; set; }

        /// <summary>
        /// LoggingLevel
        /// </summary>
        [JsonProperty("LoggingLevel")]
        public Union<string, IntrinsicFunction> LoggingLevel { get; set; }

        /// <summary>
        /// MetricsEnabled
        /// </summary>
        [JsonProperty("MetricsEnabled")]
        public Union<bool, IntrinsicFunction> MetricsEnabled { get; set; }

        /// <summary>
        /// ResourcePath
        /// </summary>
        [JsonProperty("ResourcePath")]
        public Union<string, IntrinsicFunction> ResourcePath { get; set; }

        /// <summary>
        /// ThrottlingBurstLimit
        /// </summary>
        [JsonProperty("ThrottlingBurstLimit")]
        public Union<int, IntrinsicFunction> ThrottlingBurstLimit { get; set; }

        /// <summary>
        /// ThrottlingRateLimit
        /// </summary>
        [JsonProperty("ThrottlingRateLimit")]
        public Union<double, IntrinsicFunction> ThrottlingRateLimit { get; set; }

    }
}
