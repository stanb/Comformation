using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Method
{
    /// <summary>
    /// Amazon API Gateway Method Integration IntegrationResponse
    /// IntegrationResponse is a property of the Amazon API Gateway Method Integration property type that specifies
    /// the response that Amazon API Gateway (API Gateway) sends after a method&#39;s backend finishes processing a
    /// request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration-integrationresponse.html
    /// </summary>
    public class IntegrationResponse
    {

        /// <summary>
        /// ContentHandling
        /// Specifies how to handle request payload content type conversions. Valid values are:
        /// CONVERT_TO_BINARY: Converts a request payload from a base64-encoded string to a binary blob.
        /// CONVERT_TO_TEXT: Converts a request payload from a binary blob to a base64-encoded string.
        /// If this property isn&#39;t defined, the request payload is passed through from the method request to the
        /// integration request without modification.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContentHandling")]
        public Union<string, IntrinsicFunction> ContentHandling { get; set; }

        /// <summary>
        /// ResponseParameters
        /// The response parameters from the backend response that API Gateway sends to the method response.
        /// Specify response parameters as key-value pairs (string-to-string mappings).
        /// Use the destination as the key and the source as the value:
        /// The destination must be an existing response parameter in the MethodResponse property. The source
        /// must be an existing method request parameter or a static value. You must enclose static values in
        /// single quotation marks and pre-encode these values based on the destination specified in the
        /// request.
        /// For more information, see API Gateway API Request and Response Parameter-Mapping Reference in the
        /// API Gateway Developer Guide.
        /// Required: No
        /// Type: Mapping of key-value pairs
        /// </summary>
        [JsonProperty("ResponseParameters")]
        public Dictionary<string, Union<string, IntrinsicFunction>> ResponseParameters { get; set; }

        /// <summary>
        /// ResponseTemplates
        /// The templates that are used to transform the integration response body. Specify templates as
        /// key-value pairs (string-to-string mappings), with a content type as the key and a template as the
        /// value. For more information, see API Gateway API Request and Response Payload-Mapping Template
        /// Reference in the API Gateway Developer Guide.
        /// Required: No
        /// Type: Mapping of key-value pairs
        /// </summary>
        [JsonProperty("ResponseTemplates")]
        public Dictionary<string, Union<string, IntrinsicFunction>> ResponseTemplates { get; set; }

        /// <summary>
        /// SelectionPattern
        /// A regular expression that specifies which error strings or status codes from the backend map to the
        /// integration response.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("SelectionPattern")]
        public Union<string, IntrinsicFunction> SelectionPattern { get; set; }

        /// <summary>
        /// StatusCode
        /// The status code that API Gateway uses to map the integration response to a MethodResponse status
        /// code.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("StatusCode")]
        public Union<string, IntrinsicFunction> StatusCode { get; set; }

    }
}
