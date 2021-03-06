using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Method
{
    /// <summary>
    /// AWS::ApiGateway::Method MethodResponse
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-methodresponse.html
    /// </summary>
    public class MethodResponse
    {

        /// <summary>
        /// ResponseModels
        /// The resources used for the response&#39;s content type. Specify response models as key-value pairs
        /// (string-to-string maps), with a content type as the key and a Model resource name as the value.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResponseModels")]
        public Dictionary<string, Union<string, IntrinsicFunction>> ResponseModels { get; set; }

        /// <summary>
        /// ResponseParameters
        /// Response parameters that API Gateway sends to the client that called a method. Specify response
        /// parameters as key-value pairs (string-to-Boolean maps), with a destination as the key and a Boolean
        /// as the value. Specify the destination using the following pattern: method. response. header. name,
        /// where name is a valid, unique header name. The Boolean specifies whether a parameter is required.
        /// Required: No
        /// Type: Map of Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResponseParameters")]
        public Dictionary<string, Union<bool, IntrinsicFunction>> ResponseParameters { get; set; }

        /// <summary>
        /// StatusCode
        /// The method response&#39;s status code, which you map to an IntegrationResponse.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StatusCode")]
        public Union<string, IntrinsicFunction> StatusCode { get; set; }

    }
}
