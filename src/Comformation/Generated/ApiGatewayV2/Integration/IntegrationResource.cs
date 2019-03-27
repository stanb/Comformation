using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Integration
{
    /// <summary>
    /// AWS::ApiGatewayV2::Integration
    /// The AWS::ApiGatewayV2::Integration resource defines an API integration. For more information, see
    /// CreateIntegration in the Amazon API Gateway V2 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html
    /// </summary>
    public class IntegrationResource : ResourceBase
    {
        public class IntegrationProperties
        {
            /// <summary>
            /// Description
            /// The description of the integration.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// TemplateSelectionExpression
            /// The template selection expression for the integration.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TemplateSelectionExpression { get; set; }

            /// <summary>
            /// ConnectionType
            /// The type of the network connection to the integration endpoint. Currently the only valid value is
            /// INTERNET, for connections through the public routable internet.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ConnectionType { get; set; }

            /// <summary>
            /// IntegrationMethod
            /// Specifies the integration&#39;s HTTP method type.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IntegrationMethod { get; set; }

            /// <summary>
            /// PassthroughBehavior
            /// Specifies the pass-through behavior for incoming requests based on the Content-Type header in the
            /// request, and the available mapping templates specified as the requestTemplates property on the
            /// Integration resource. There are three valid values: WHEN_NO_MATCH, WHEN_NO_TEMPLATES, and NEVER.
            /// WHEN_NO_MATCH passes the request body for unmapped content types through to the integration backend
            /// without transformation.
            /// NEVER rejects unmapped content types with an HTTP 415 Unsupported Media Type response.
            /// WHEN_NO_TEMPLATES allows pass-through when the integration has no content types mapped to templates.
            /// However, if there is at least one content type defined, unmapped content types will be rejected with
            /// the same HTTP 415 Unsupported Media Type response.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PassthroughBehavior { get; set; }

            /// <summary>
            /// RequestParameters
            /// A key-value map specifying request parameters that are passed from the method request to the
            /// backend. The key is an integration request parameter name and the associated value is a method
            /// request parameter value or static value that must be enclosed within single quotes and pre-encoded
            /// as required by the backend. The method request parameter value must match the pattern of method.
            /// request. {location}. {name} , where {location} is querystring, path, or header; and {name} must be a
            /// valid and unique method request parameter name.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RequestParameters { get; set; }

            /// <summary>
            /// IntegrationUri
            /// For a Lambda proxy integration, this is the URI of the Lambda function.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IntegrationUri { get; set; }

            /// <summary>
            /// CredentialsArn
            /// Specifies the credentials required for the integration, if any. For AWS integrations, three options
            /// are available. To specify an IAM Role for API Gateway to assume, use the role&#39;s Amazon Resource Name
            /// (ARN). To require that the caller&#39;s identity be passed through from the request, specify the string
            /// arn:aws:iam::*:user/*. To use resource-based permissions on supported AWS services, specify null.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> CredentialsArn { get; set; }

            /// <summary>
            /// RequestTemplates
            /// Represents a map of Velocity templates that are applied on the request payload based on the value of
            /// the Content-Type header sent by the client. The content type value is the key in this map, and the
            /// template (as a string) is the value.
            /// Required: No
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RequestTemplates { get; set; }

            /// <summary>
            /// TimeoutInMillis
            /// Custom timeout between 50 and 29,000 milliseconds. The default value is 29,000 milliseconds or 29
            /// seconds.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> TimeoutInMillis { get; set; }

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
            /// ApiId
            /// The API ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// IntegrationType
            /// The integration type of an integration. One of the following:
            /// AWS: for integrating the route or method request with an AWS service action, including the Lambda
            /// function-invoking action. With the Lambda function-invoking action, this is referred to as the
            /// Lambda custom integration. With any other AWS service action, this is known as AWS integration.
            /// AWS_PROXY: for integrating the route or method request with the Lambda function-invoking action with
            /// the client request passed through as-is. This integration is also referred to as Lambda proxy
            /// integration.
            /// HTTP: for integrating the route or method request with an HTTP endpoint. This integration is also
            /// referred to as HTTP custom integration.
            /// HTTP_PROXY: for integrating route or method request with an HTTP endpoint, with the client request
            /// passed through as-is. This is also referred to as HTTP proxy integration.
            /// MOCK: for integrating the route or method request with API Gateway as a &quot;loopback&quot; endpoint without
            /// invoking any backend.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IntegrationType { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::Integration";

        public IntegrationProperties Properties { get; } = new IntegrationProperties();

    }
}
