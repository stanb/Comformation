using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Deployment
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html
    /// </summary>
    public class StageDescription
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cacheclusterenabled
        /// </summary>
        [JsonProperty("CacheClusterEnabled")]
        public Union<bool?, IntrinsicFunction> CacheClusterEnabled { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cacheclustersize
        /// </summary>
        [JsonProperty("CacheClusterSize")]
        public Union<string, IntrinsicFunction> CacheClusterSize { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cachedataencrypted
        /// </summary>
        [JsonProperty("CacheDataEncrypted")]
        public Union<bool?, IntrinsicFunction> CacheDataEncrypted { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cachettlinseconds
        /// </summary>
        [JsonProperty("CacheTtlInSeconds")]
        public Union<int?, IntrinsicFunction> CacheTtlInSeconds { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-cachingenabled
        /// </summary>
        [JsonProperty("CachingEnabled")]
        public Union<bool?, IntrinsicFunction> CachingEnabled { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-clientcertificateid
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public Union<string, IntrinsicFunction> ClientCertificateId { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-datatraceenabled
        /// </summary>
        [JsonProperty("DataTraceEnabled")]
        public Union<bool?, IntrinsicFunction> DataTraceEnabled { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-description
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-documentationversion
        /// </summary>
        [JsonProperty("DocumentationVersion")]
        public Union<string, IntrinsicFunction> DocumentationVersion { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-logginglevel
        /// </summary>
        [JsonProperty("LoggingLevel")]
        public Union<string, IntrinsicFunction> LoggingLevel { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-methodsettings
        /// </summary>
        [JsonProperty("MethodSettings")]
        public Union<List<MethodSetting>, IntrinsicFunction> MethodSettings { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-metricsenabled
        /// </summary>
        [JsonProperty("MetricsEnabled")]
        public Union<bool?, IntrinsicFunction> MetricsEnabled { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-throttlingburstlimit
        /// </summary>
        [JsonProperty("ThrottlingBurstLimit")]
        public Union<int?, IntrinsicFunction> ThrottlingBurstLimit { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-throttlingratelimit
        /// </summary>
        [JsonProperty("ThrottlingRateLimit")]
        public Union<double?, IntrinsicFunction> ThrottlingRateLimit { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-stagedescription.html#cfn-apigateway-deployment-stagedescription-variables
        /// </summary>
        [JsonProperty("Variables")]
        public Union<Dictionary<string, string>, IntrinsicFunction> Variables { get; set; }

    }
}
