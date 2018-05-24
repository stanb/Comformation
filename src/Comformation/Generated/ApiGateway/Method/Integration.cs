using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Method
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html
    /// </summary>
    public class Integration
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-cachekeyparameters
        /// </summary>
        [JsonProperty("CacheKeyParameters")]
        public Union<List<string>, IntrinsicFunction> CacheKeyParameters { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-cachenamespace
        /// </summary>
        [JsonProperty("CacheNamespace")]
        public Union<string, IntrinsicFunction> CacheNamespace { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-contenthandling
        /// </summary>
        [JsonProperty("ContentHandling")]
        public Union<string, IntrinsicFunction> ContentHandling { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-credentials
        /// </summary>
        [JsonProperty("Credentials")]
        public Union<string, IntrinsicFunction> Credentials { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-integrationhttpmethod
        /// </summary>
        [JsonProperty("IntegrationHttpMethod")]
        public Union<string, IntrinsicFunction> IntegrationHttpMethod { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-integrationresponses
        /// </summary>
        [JsonProperty("IntegrationResponses")]
        public Union<List<IntegrationResponse>, IntrinsicFunction> IntegrationResponses { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-passthroughbehavior
        /// </summary>
        [JsonProperty("PassthroughBehavior")]
        public Union<string, IntrinsicFunction> PassthroughBehavior { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-requestparameters
        /// </summary>
        [JsonProperty("RequestParameters")]
        public Union<Dictionary<string, string>, IntrinsicFunction> RequestParameters { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-requesttemplates
        /// </summary>
        [JsonProperty("RequestTemplates")]
        public Union<Dictionary<string, string>, IntrinsicFunction> RequestTemplates { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-type
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html#cfn-apigateway-method-integration-uri
        /// </summary>
        [JsonProperty("Uri")]
        public Union<string, IntrinsicFunction> Uri { get; set; }

    }
}
