using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Integration
{
    /// <summary>
    /// AWS::ApiGatewayV2::Integration
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
            /// The template selection expression for the integration. Supported only for WebSocket APIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateSelectionExpression { get; set; }

            /// <summary>
            /// ConnectionType
            /// The type of the network connection to the integration endpoint. Specify INTERNET for connections
            /// through the public routable internet or VPC_LINK for private connections between API Gateway and
            /// resources in a VPC. The default value is INTERNET.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectionType { get; set; }

            /// <summary>
            /// ResponseParameters
            /// Supported only for HTTP APIs. You use response parameters to transform the HTTP response from a
            /// backend integration before returning the response to clients. Specify a key-value map from a
            /// selection key to response parameters. The selection key must be a valid HTTP status code within the
            /// range of 200-599. The value is of type ResponseParameterList. To learn more, see Transforming API
            /// requests and responses.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ResponseParameters { get; set; }

            /// <summary>
            /// IntegrationMethod
            /// Specifies the integration&#39;s HTTP method type.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IntegrationMethod { get; set; }

            /// <summary>
            /// PassthroughBehavior
            /// Specifies the pass-through behavior for incoming requests based on the Content-Type header in the
            /// request, and the available mapping templates specified as the requestTemplates property on the
            /// Integration resource. There are three valid values: WHEN_NO_MATCH, WHEN_NO_TEMPLATES, and NEVER.
            /// Supported only for WebSocket APIs.
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
            /// For WebSocket APIs, a key-value map specifying request parameters that are passed from the method
            /// request to the backend. The key is an integration request parameter name and the associated value is
            /// a method request parameter value or static value that must be enclosed within single quotes and
            /// pre-encoded as required by the backend. The method request parameter value must match the pattern of
            /// method. request. {location}. {name} , where {location} is querystring, path, or header; and {name}
            /// must be a valid and unique method request parameter name.
            /// For HTTP API integrations with a specified integrationSubtype, request parameters are a key-value
            /// map specifying parameters that are passed to AWS_PROXY integrations. You can provide static values,
            /// or map request data, stage variables, or context variables that are evaluated at runtime. To learn
            /// more, see Working with AWS service integrations for HTTP APIs.
            /// For HTTP API integrations without a specified integrationSubtype request parameters are a key-value
            /// map specifying how to transform HTTP requests before sending them to the backend. The key should
            /// follow the pattern &amp;lt;action&amp;gt;:&amp;lt;header|querystring|path&amp;gt;. &amp;lt;location&amp;gt; where action can
            /// be append, overwrite or remove. For values, you can provide static values, or map request data,
            /// stage variables, or context variables that are evaluated at runtime. To learn more, see Transforming
            /// API requests and responses.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RequestParameters { get; set; }

            /// <summary>
            /// ConnectionId
            /// The ID of the VPC link for a private integration. Supported only for HTTP APIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ConnectionId { get; set; }

            /// <summary>
            /// IntegrationUri
            /// For a Lambda integration, specify the URI of a Lambda function.
            /// For an HTTP integration, specify a fully-qualified URL.
            /// For an HTTP API private integration, specify the ARN of an Application Load Balancer listener,
            /// Network Load Balancer listener, or AWS Cloud Map service. If you specify the ARN of an AWS Cloud Map
            /// service, API Gateway uses DiscoverInstances to identify resources. You can use query parameters to
            /// target specific resources. To learn more, see DiscoverInstances. For private integrations, all
            /// resources must be owned by the same AWS account.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IntegrationUri { get; set; }

            /// <summary>
            /// PayloadFormatVersion
            /// Specifies the format of the payload sent to an integration. Required for HTTP APIs. For HTTP APIs,
            /// supported values for Lambda proxy integrations are 1. 0 and 2. 0. For all other integrations, 1. 0
            /// is the only supported value. To learn more, see Working with AWS Lambda proxy integrations for HTTP
            /// APIs.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PayloadFormatVersion { get; set; }

            /// <summary>
            /// CredentialsArn
            /// Specifies the credentials required for the integration, if any. For AWS integrations, three options
            /// are available. To specify an IAM Role for API Gateway to assume, use the role&#39;s Amazon Resource Name
            /// (ARN). To require that the caller&#39;s identity be passed through from the request, specify the string
            /// arn:aws:iam::*:user/*. To use resource-based permissions on supported AWS services, don&#39;t specify
            /// this parameter.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CredentialsArn { get; set; }

            /// <summary>
            /// RequestTemplates
            /// Represents a map of Velocity templates that are applied on the request payload based on the value of
            /// the Content-Type header sent by the client. The content type value is the key in this map, and the
            /// template (as a String) is the value. Supported only for WebSocket APIs.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> RequestTemplates { get; set; }

            /// <summary>
            /// TimeoutInMillis
            /// Custom timeout between 50 and 29,000 milliseconds for WebSocket APIs and between 50 and 30,000
            /// milliseconds for HTTP APIs. The default timeout is 29 seconds for WebSocket APIs and 30 seconds for
            /// HTTP APIs.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> TimeoutInMillis { get; set; }

            /// <summary>
            /// TlsConfig
            /// The TLS configuration for a private integration. If you specify a TLS configuration, private
            /// integration traffic uses the HTTPS protocol. Supported only for HTTP APIs.
            /// Required: No
            /// Type: TlsConfig
            /// Update requires: No interruption
            /// </summary>
            public TlsConfig TlsConfig { get; set; }

            /// <summary>
            /// ContentHandlingStrategy
            /// Supported only for WebSocket APIs. Specifies how to handle response payload content type
            /// conversions. Supported values are CONVERT_TO_BINARY and CONVERT_TO_TEXT, with the following
            /// behaviors:
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
            /// IntegrationSubtype
            /// Supported only for HTTP API AWS_PROXY integrations. Specifies the AWS service action to invoke. To
            /// learn more, see Integration subtype reference.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IntegrationSubtype { get; set; }

            /// <summary>
            /// ApiId
            /// The API identifier.
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
            /// Supported only for WebSocket APIs.
            /// AWS_PROXY: for integrating the route or method request with a Lambda function or other AWS service
            /// action. This integration is also referred to as a Lambda proxy integration.
            /// HTTP: for integrating the route or method request with an HTTP endpoint. This integration is also
            /// referred to as the HTTP custom integration. Supported only for WebSocket APIs.
            /// HTTP_PROXY: for integrating the route or method request with an HTTP endpoint, with the client
            /// request passed through as-is. This is also referred to as HTTP proxy integration. For HTTP API
            /// private integrations, use an HTTP_PROXY integration.
            /// MOCK: for integrating the route or method request with API Gateway as a &quot;loopback&quot; endpoint without
            /// invoking any backend. Supported only for WebSocket APIs.
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
