using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Stage
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html
    /// </summary>
    public class MethodSetting
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-cachedataencrypted
        /// </summary>
        [JsonProperty("CacheDataEncrypted")]
        public Union<bool?, IntrinsicFunction> CacheDataEncrypted { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-cachettlinseconds
        /// </summary>
        [JsonProperty("CacheTtlInSeconds")]
        public Union<int?, IntrinsicFunction> CacheTtlInSeconds { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-cachingenabled
        /// </summary>
        [JsonProperty("CachingEnabled")]
        public Union<bool?, IntrinsicFunction> CachingEnabled { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-datatraceenabled
        /// </summary>
        [JsonProperty("DataTraceEnabled")]
        public Union<bool?, IntrinsicFunction> DataTraceEnabled { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-httpmethod
        /// </summary>
        [JsonProperty("HttpMethod")]
        public Union<string, IntrinsicFunction> HttpMethod { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-logginglevel
        /// </summary>
        [JsonProperty("LoggingLevel")]
        public Union<string, IntrinsicFunction> LoggingLevel { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-metricsenabled
        /// </summary>
        [JsonProperty("MetricsEnabled")]
        public Union<bool?, IntrinsicFunction> MetricsEnabled { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-resourcepath
        /// </summary>
        [JsonProperty("ResourcePath")]
        public Union<string, IntrinsicFunction> ResourcePath { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-throttlingburstlimit
        /// </summary>
        [JsonProperty("ThrottlingBurstLimit")]
        public Union<int?, IntrinsicFunction> ThrottlingBurstLimit { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-throttlingratelimit
        /// </summary>
        [JsonProperty("ThrottlingRateLimit")]
        public Union<double?, IntrinsicFunction> ThrottlingRateLimit { get; set; }

    }
}
