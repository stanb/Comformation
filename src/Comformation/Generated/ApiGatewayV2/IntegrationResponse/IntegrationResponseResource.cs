using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.IntegrationResponse
{
    /// <summary>
    /// AWS::ApiGatewayV2::IntegrationResponse
    /// The AWS::ApiGatewayV2::IntegrationResponse resource defines an API integration response. For more information,
    /// see CreateIntegrationResponse in the Amazon API Gateway V2 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integrationresponse.html
    /// </summary>
    public class IntegrationResponseResource : ResourceBase
    {
        public class IntegrationResponseProperties
        {
            /// <summary>
            /// ResponseTemplates
            /// The collection of response templates for the integration response as a string-to-string map of
            /// key-value pairs. Response templates are represented as a key/value map, with a content-type as the
            /// key and a template as the value.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ResponseTemplates { get; set; }

            /// <summary>
            /// TemplateSelectionExpression
            /// The template selection expression for the integration response.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TemplateSelectionExpression { get; set; }

            /// <summary>
            /// ResponseParameters
            /// A key-value map specifying response parameters that are passed to the method response from the
            /// backend. The key is a method response header parameter name and the mapped value is an integration
            /// response header value, a static value enclosed within a pair of single quotes, or a JSON expression
            /// from the integration response body. The mapping key must match the pattern of method. response.
            /// header. {name} , where name is a valid and unique header name. The mapped non-static value must
            /// match the pattern of integration. response. header. {name} or integration. response. body.
            /// {JSON-expression} , where {name} is a valid and unique response header name and {JSON-expression} is
            /// a valid JSON expression without the $ prefix.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ResponseParameters { get; set; }

            /// <summary>
            /// ContentHandlingStrategy
            /// Specifies how to handle response payload content type conversions. Supported values are
            /// CONVERT_TO_BINARY and CONVERT_TO_TEXT, with the following behaviors:
            /// CONVERT_TO_BINARY: Converts a response payload from a Base64-encoded string to the corresponding
            /// binary blob.
            /// CONVERT_TO_TEXT: Converts a response payload from a binary blob to a Base64-encoded string.
            /// If this property is not defined, the response payload will be passed through from the integration
            /// response to the route response or method response without modification.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ContentHandlingStrategy { get; set; }

            /// <summary>
            /// IntegrationId
            /// The integration ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IntegrationId { get; set; }

            /// <summary>
            /// IntegrationResponseKey
            /// The integration response key.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IntegrationResponseKey { get; set; }

            /// <summary>
            /// ApiId
            /// The API ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::IntegrationResponse";

        public IntegrationResponseProperties Properties { get; } = new IntegrationResponseProperties();

    }
}
