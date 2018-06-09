using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Deployment
{
    /// <summary>
    /// Amazon API Gateway Deployment StageDescription
    /// StageDescription is a property of the AWS::ApiGateway::Deployment resource that configures an Amazon API
    /// Gateway (API Gateway) deployment stage.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html
    /// </summary>
    public class StageDescription
    {

        /// <summary>
        /// CacheClusterEnabled
        /// Indicates whether cache clustering is enabled for the stage.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("CacheClusterEnabled")]
        public Union<bool, IntrinsicFunction> CacheClusterEnabled { get; set; }

        /// <summary>
        /// CacheClusterSize
        /// The size of the stage&#39;s cache cluster.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CacheClusterSize")]
        public Union<string, IntrinsicFunction> CacheClusterSize { get; set; }

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
        /// ClientCertificateId
        /// The identifier of the client certificate that API Gateway uses to call your integration endpoints in
        /// the stage.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public Union<string, IntrinsicFunction> ClientCertificateId { get; set; }

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
        /// Description
        /// A description of the purpose of the stage.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// DocumentationVersion
        /// The version identifier of the API documentation snapshot.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("DocumentationVersion")]
        public Union<string, IntrinsicFunction> DocumentationVersion { get; set; }

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
        /// MethodSettings
        /// Configures settings for all of the stage&#39;s methods.
        /// Required: No
        /// Type: List of API Gateway Deployment MethodSetting
        /// </summary>
        [JsonProperty("MethodSettings")]
        public Union<List<MethodSetting>, IntrinsicFunction> MethodSettings { get; set; }

        /// <summary>
        /// MetricsEnabled
        /// Indicates whether Amazon CloudWatch metrics are enabled for methods in the stage.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("MetricsEnabled")]
        public Union<bool, IntrinsicFunction> MetricsEnabled { get; set; }

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

        /// <summary>
        /// Variables
        /// A map that defines the stage variables. Variable names must consist of alphanumeric characters, and
        /// the values must match the following regular expression: [A-Za-z0-9-. _~:/?#&amp;amp;amp;=,]+.
        /// Required: No
        /// Type: Mapping of key-value pairs
        /// </summary>
        [JsonProperty("Variables")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Variables { get; set; }

    }
}
