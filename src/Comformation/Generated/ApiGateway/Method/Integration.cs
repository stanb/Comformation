using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Method
{
    /// <summary>
    /// Amazon API Gateway Method Integration
    /// Integration is a property of the AWS::ApiGateway::Method resource that specifies information about the target
    /// backend that an Amazon API Gateway (API Gateway) method calls.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-method-integration.html
    /// </summary>
    public class Integration
    {

        /// <summary>
        /// CacheKeyParameters
        /// A list of request parameters whose values API Gateway caches. These parameters must also be
        /// specified in RequestParameters to be supported in CacheKeyParameters.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("CacheKeyParameters")]
        public List<Union<string, IntrinsicFunction>> CacheKeyParameters { get; set; }

        /// <summary>
        /// CacheNamespace
        /// An API-specific tag group of related cached parameters.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("CacheNamespace")]
        public Union<string, IntrinsicFunction> CacheNamespace { get; set; }

        /// <summary>
        /// ConnectionId
        /// The ID of the VpcLink used for the integration when connectionType=VPC_LINK and undefined,
        /// otherwise.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionId")]
        public Union<string, IntrinsicFunction> ConnectionId { get; set; }

        /// <summary>
        /// ConnectionType
        /// The type of the network connection to the integration endpoint. The valid value is INTERNET for
        /// connections through the public routable internet or VPC_LINK for private connections between API
        /// Gateway and a network load balancer in a VPC. The default value is INTERNET.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConnectionType")]
        public Union<string, IntrinsicFunction> ConnectionType { get; set; }

        /// <summary>
        /// ContentHandling
        /// Specifies how to handle request payload content type conversions. Valid values are:
        /// CONVERT_TO_BINARY: Converts a request payload from a base64-encoded string to a binary blob.
        /// CONVERT_TO_TEXT: Converts a request payload from a binary blob to a base64-encoded string.
        /// If this property isn&#39;t defined, the request payload is passed through from the method request to the
        /// integration request without modification, provided that the PassthroughBehaviors property is
        /// configured to support payload pass-through.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContentHandling")]
        public Union<string, IntrinsicFunction> ContentHandling { get; set; }

        /// <summary>
        /// Credentials
        /// The credentials that are required for the integration. To specify an AWS Identity and Access
        /// Management (IAM) role that API Gateway assumes, specify the role&#39;s Amazon Resource Name (ARN). To
        /// require that the caller&#39;s identity be passed through from the request, specify
        /// arn:aws:iam::*:user/*.
        /// To use resource-based permissions on the AWS Lambda (Lambda) function, don&#39;t specify this property.
        /// Use the AWS::Lambda::Permission resource to permit API Gateway to call the function. For more
        /// information, see Allow Amazon API Gateway to Invoke a Lambda Function in the AWS Lambda Developer
        /// Guide.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Credentials")]
        public Union<string, IntrinsicFunction> Credentials { get; set; }

        /// <summary>
        /// IntegrationHttpMethod
        /// The integration&#39;s HTTP method type.
        /// Required: Conditional. For the Type property, if you specify MOCK, this property is optional. For
        /// all other types, you must specify this property.
        /// Type: String
        /// </summary>
        [JsonProperty("IntegrationHttpMethod")]
        public Union<string, IntrinsicFunction> IntegrationHttpMethod { get; set; }

        /// <summary>
        /// IntegrationResponses
        /// The response that API Gateway provides after a method&#39;s backend completes processing a request. API
        /// Gateway intercepts the response from the backend so that you can control how API Gateway surfaces
        /// backend responses. For example, you can map the backend status codes to codes that you define.
        /// Required: No
        /// Type: List of Amazon API Gateway Method Integration IntegrationResponse property types
        /// </summary>
        [JsonProperty("IntegrationResponses")]
        public List<IntegrationResponse> IntegrationResponses { get; set; }

        /// <summary>
        /// PassthroughBehavior
        /// Indicates when API Gateway passes requests to the targeted backend. This behavior depends on the
        /// request&#39;s Content-Type header and whether you defined a mapping template for it.
        /// For more information and valid values, see the passthroughBehavior field in the API Gateway API
        /// Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("PassthroughBehavior")]
        public Union<string, IntrinsicFunction> PassthroughBehavior { get; set; }

        /// <summary>
        /// RequestParameters
        /// The request parameters that API Gateway sends with the backend request. Specify request parameters
        /// as key-value pairs (string-to-string mappings), with a destination as the key and a source as the
        /// value.
        /// Specify the destination by using the following pattern integration. request. location. name, where
        /// location is querystring, path, or header, and name is a valid, unique parameter name.
        /// The source must be an existing method request parameter or a static value. You must enclose static
        /// values in single quotation marks and pre-encode these values based on their destination in the
        /// request.
        /// Required: No
        /// Type: Mapping of key-value pairs
        /// </summary>
        [JsonProperty("RequestParameters")]
        public Dictionary<string, Union<string, IntrinsicFunction>> RequestParameters { get; set; }

        /// <summary>
        /// RequestTemplates
        /// A map of Apache Velocity templates that are applied on the request payload. The template that API
        /// Gateway uses is based on the value of the Content-Type header that&#39;s sent by the client. The content
        /// type value is the key, and the template is the value (specified as a string), such as the following
        /// snippet:
        /// &quot;application/json&quot;: &quot;{\n \&quot;statusCode\&quot;: \&quot;200\&quot;\n}&quot;
        /// For more information about templates, see API Gateway API Request and Response Payload-Mapping
        /// Template Reference in the API Gateway Developer Guide.
        /// Required: No
        /// Type: Mapping of key-value pairs
        /// </summary>
        [JsonProperty("RequestTemplates")]
        public Dictionary<string, Union<string, IntrinsicFunction>> RequestTemplates { get; set; }

        /// <summary>
        /// TimeoutInMillis
        /// Custom timeout between 50 and 29,000 milliseconds. The default value is 29,000 milliseconds or 29
        /// seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeoutInMillis")]
        public Union<int, IntrinsicFunction> TimeoutInMillis { get; set; }

        /// <summary>
        /// Type
        /// The type of backend that your method is running, such as HTTP or MOCK. For all of the valid values,
        /// see the type property for the Integration resource in the Amazon API Gateway REST API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Uri
        /// The Uniform Resource Identifier (URI) for the integration.
        /// If you specify HTTP for the Type property, specify the API endpoint URL.
        /// If you specify MOCK for the Type property, don&#39;t specify this property.
        /// If you specify AWS for the Type property, specify an AWS service that follows this form:
        /// arn:aws:apigateway:region:subdomain. service|service:path|action/service_api. For example, a Lambda
        /// function URI follows this form: arn:aws:apigateway:region:lambda:path/path. The path is usually in
        /// the form /2015-03-31/functions/LambdaFunctionARN/invocations. For more information, see the uri
        /// property of the Integration resource in the Amazon API Gateway REST API Reference.
        /// Required: Conditional. If you specified HTTP or AWS for the Type property, you must specify this
        /// property.
        /// Type: String
        /// </summary>
        [JsonProperty("Uri")]
        public Union<string, IntrinsicFunction> Uri { get; set; }

    }
}
