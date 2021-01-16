using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Authorizer
{
    /// <summary>
    /// AWS::ApiGatewayV2::Authorizer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html
    /// </summary>
    public class AuthorizerResource : ResourceBase
    {
        public class AuthorizerProperties
        {
            /// <summary>
            /// IdentityValidationExpression
            /// This parameter is not used.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IdentityValidationExpression { get; set; }

            /// <summary>
            /// AuthorizerUri
            /// The authorizer&#39;s Uniform Resource Identifier (URI). For REQUEST authorizers, this must be a
            /// well-formed Lambda function URI, for example,
            /// arn:aws:apigateway:us-west-2:lambda:path/2015-03-31/functions/arn:aws:lambda:us-west-2:{account_id}:function:{lambda_function_name}/invocations.
            /// In general, the URI has this form: arn:aws:apigateway:{region}:lambda:path/{service_api} , where
            /// {region} is the same as the region hosting the Lambda function, path indicates that the remaining
            /// substring in the URI should be treated as the path to the resource, including the initial /. For
            /// Lambda functions, this is usually of the form /2015-03-31/functions/[FunctionARN]/invocations.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AuthorizerUri { get; set; }

            /// <summary>
            /// AuthorizerCredentialsArn
            /// Specifies the required credentials as an IAM role for API Gateway to invoke the authorizer. To
            /// specify an IAM role for API Gateway to assume, use the role&#39;s Amazon Resource Name (ARN). To use
            /// resource-based permissions on the Lambda function, specify null. Supported only for REQUEST
            /// authorizers.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AuthorizerCredentialsArn { get; set; }

            /// <summary>
            /// AuthorizerType
            /// The authorizer type. Specify REQUEST for a Lambda function using incoming request parameters.
            /// Specify JWT to use JSON Web Tokens (supported only for HTTP APIs).
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AuthorizerType { get; set; }

            /// <summary>
            /// JwtConfiguration
            /// The JWTConfiguration property specifies the configuration of a JWT authorizer. Required for the JWT
            /// authorizer type. Supported only for HTTP APIs.
            /// Required: No
            /// Type: JWTConfiguration
            /// Update requires: No interruption
            /// </summary>
            public JWTConfiguration JwtConfiguration { get; set; }

            /// <summary>
            /// AuthorizerResultTtlInSeconds
            /// The time to live (TTL) for cached authorizer results, in seconds. If it equals 0, authorization
            /// caching is disabled. If it is greater than 0, API Gateway caches authorizer responses. The maximum
            /// value is 3600, or 1 hour. Supported only for HTTP API Lambda authorizers.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> AuthorizerResultTtlInSeconds { get; set; }

            /// <summary>
            /// IdentitySource
            /// The identity source for which authorization is requested.
            /// For a REQUEST authorizer, this is optional. The value is a set of one or more mapping expressions of
            /// the specified request parameters. The identity source can be headers, query string parameters, stage
            /// variables, and context parameters. For example, if an Auth header and a Name query string parameter
            /// are defined as identity sources, this value is route. request. header. Auth, route. request.
            /// querystring. Name for WebSocket APIs. For HTTP APIs, use selection expressions prefixed with $, for
            /// example, $request. header. Auth, $request. querystring. Name. These parameters are used to perform
            /// runtime validation for Lambda-based authorizers by verifying all of the identity-related request
            /// parameters are present in the request, not null, and non-empty. Only when this is true does the
            /// authorizer invoke the authorizer Lambda function. Otherwise, it returns a 401 Unauthorized response
            /// without calling the Lambda function. For HTTP APIs, identity sources are also used as the cache key
            /// when caching is enabled. To learn more, see Working with AWS Lambda authorizers for HTTP APIs.
            /// For JWT, a single entry that specifies where to extract the JSON Web Token (JWT) from inbound
            /// requests. Currently only header-based and query parameter-based selections are supported, for
            /// example $request. header. Authorization.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> IdentitySource { get; set; }

            /// <summary>
            /// AuthorizerPayloadFormatVersion
            /// Specifies the format of the payload sent to an HTTP API Lambda authorizer. Required for HTTP API
            /// Lambda authorizers. Supported values are 1. 0 and 2. 0. To learn more, see Working with AWS Lambda
            /// authorizers for HTTP APIs.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AuthorizerPayloadFormatVersion { get; set; }

            /// <summary>
            /// EnableSimpleResponses
            /// Specifies whether a Lambda authorizer returns a response in a simple format. By default, a Lambda
            /// authorizer must return an IAM policy. If enabled, the Lambda authorizer can return a boolean value
            /// instead of an IAM policy. Supported only for HTTP APIs. To learn more, see Working with AWS Lambda
            /// authorizers for HTTP APIs.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableSimpleResponses { get; set; }

            /// <summary>
            /// ApiId
            /// The API identifier.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// Name
            /// The name of the authorizer.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::ApiGatewayV2::Authorizer";

        public AuthorizerProperties Properties { get; } = new AuthorizerProperties();

    }
}
