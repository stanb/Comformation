using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Api
{
    /// <summary>
    /// AWS::ApiGatewayV2::Api
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-api.html
    /// </summary>
    public class ApiResource : ResourceBase
    {
        public class ApiProperties
        {
            /// <summary>
            /// RouteSelectionExpression
            /// The route selection expression for the API. For HTTP APIs, the routeSelectionExpression must be
            /// ${request. method} ${request. path}. If not provided, this will be the default for HTTP APIs. This
            /// property is required for WebSocket APIs.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RouteSelectionExpression { get; set; }

            /// <summary>
            /// BodyS3Location
            /// The S3 location of an OpenAPI definition. Supported only for HTTP APIs. To import an HTTP API, you
            /// must specify a Body or BodyS3Location. If you specify a Body or BodyS3Location, don&#39;t specify
            /// CloudFormation resources such as AWS::ApiGatewayV2::Authorizer or AWS::ApiGatewayV2::Route. API
            /// Gateway doesn&#39;t support the combination of OpenAPI and CloudFormation resources.
            /// Required: Conditional
            /// Type: BodyS3Location
            /// Update requires: No interruption
            /// </summary>
            public BodyS3Location BodyS3Location { get; set; }

            /// <summary>
            /// Description
            /// The description of the API.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// BasePath
            /// Specifies how to interpret the base path of the API during import. Valid values are ignore, prepend,
            /// and split. The default value is ignore. To learn more, see Set the OpenAPI basePath Property.
            /// Supported only for HTTP APIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> BasePath { get; set; }

            /// <summary>
            /// FailOnWarnings
            /// Specifies whether to rollback the API creation when a warning is encountered. By default, API
            /// creation continues if a warning is encountered.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> FailOnWarnings { get; set; }

            /// <summary>
            /// DisableExecuteApiEndpoint
            /// Specifies whether clients can invoke your API by using the default execute-api endpoint. By default,
            /// clients can invoke your API with the default https://{api_id}. execute-api. {region}. amazonaws. com
            /// endpoint. To require that clients use a custom domain name to invoke your API, disable the default
            /// endpoint.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DisableExecuteApiEndpoint { get; set; }

            /// <summary>
            /// DisableSchemaValidation
            /// Avoid validating models when creating a deployment. Supported only for WebSocket APIs.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> DisableSchemaValidation { get; set; }

            /// <summary>
            /// Name
            /// The name of the API. Required unless you specify an OpenAPI definition for Body or S3BodyLocation.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Target
            /// This property is part of quick create. Quick create produces an API with an integration, a default
            /// catch-all route, and a default stage which is configured to automatically deploy changes. For HTTP
            /// integrations, specify a fully qualified URL. For Lambda integrations, specify a function ARN. The
            /// type of the integration will be HTTP_PROXY or AWS_PROXY, respectively. Supported only for HTTP APIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Target { get; set; }

            /// <summary>
            /// CredentialsArn
            /// This property is part of quick create. It specifies the credentials required for the integration, if
            /// any. For a Lambda integration, three options are available. To specify an IAM Role for API Gateway
            /// to assume, use the role&#39;s Amazon Resource Name (ARN). To require that the caller&#39;s identity be
            /// passed through from the request, specify arn:aws:iam::*:user/*. To use resource-based permissions on
            /// supported AWS services, specify null. Currently, this property is not used for HTTP integrations.
            /// Supported only for HTTP APIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CredentialsArn { get; set; }

            /// <summary>
            /// CorsConfiguration
            /// A CORS configuration. Supported only for HTTP APIs. See Configuring CORS for more information.
            /// Required: No
            /// Type: Cors
            /// Update requires: No interruption
            /// </summary>
            public Cors CorsConfiguration { get; set; }

            /// <summary>
            /// Version
            /// A version identifier for the API.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Version { get; set; }

            /// <summary>
            /// ProtocolType
            /// The API protocol. Valid values are WEBSOCKET or HTTP. Required unless you specify an OpenAPI
            /// definition for Body or S3BodyLocation.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProtocolType { get; set; }

            /// <summary>
            /// RouteKey
            /// This property is part of quick create. If you don&#39;t specify a routeKey, a default route of $default
            /// is created. The $default route acts as a catch-all for any request made to your API, for a
            /// particular stage. The $default route key can&#39;t be modified. You can add routes after creating the
            /// API, and you can update the route keys of additional routes. Supported only for HTTP APIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RouteKey { get; set; }

            /// <summary>
            /// Body
            /// The OpenAPI definition. Supported only for HTTP APIs. To import an HTTP API, you must specify a Body
            /// or BodyS3Location. If you specify a Body or BodyS3Location, don&#39;t specify CloudFormation resources
            /// such as AWS::ApiGatewayV2::Authorizer or AWS::ApiGatewayV2::Route. API Gateway doesn&#39;t support the
            /// combination of OpenAPI and CloudFormation resources.
            /// Required: Conditional
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Body { get; set; }

            /// <summary>
            /// Tags
            /// The collection of tags. Each tag element is associated with a given resource.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// ApiKeySelectionExpression
            /// An API key selection expression. Supported only for WebSocket APIs. See API Key Selection
            /// Expressions.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ApiKeySelectionExpression { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::Api";

        public ApiProperties Properties { get; } = new ApiProperties();

    }

    public static class ApiAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApiEndpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApiEndpoint");
    }
}
