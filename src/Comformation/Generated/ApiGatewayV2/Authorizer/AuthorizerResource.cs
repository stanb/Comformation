using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Authorizer
{
    /// <summary>
    /// AWS::ApiGatewayV2::Authorizer
    /// The AWS::ApiGatewayV2::Authorizer resource updates a Lambda authorizer function. For more information about
    /// Lambda authorizer functions for WebSocket APIs, see Create a Lambda REQUEST Authorizer Function in the API
    /// Gateway Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html
    /// </summary>
    public class AuthorizerResource : ResourceBase
    {
        public class AuthorizerProperties
        {
            /// <summary>
            /// IdentityValidationExpression
            /// The validation expression does not apply to the REQUEST authorizer.
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
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthorizerUri { get; set; }

            /// <summary>
            /// AuthorizerCredentialsArn
            /// Specifies the required credentials as an IAM role for API Gateway to invoke the authorizer. To
            /// specify an IAM role for API Gateway to assume, use the role&#39;s Amazon Resource Name (ARN). To use
            /// resource-based permissions on the Lambda function, specify null.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthorizerCredentialsArn { get; set; }

            /// <summary>
            /// AuthorizerType
            /// The authorizer type. Currently the only valid value is REQUEST, for a Lambda function using incoming
            /// request parameters.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthorizerType { get; set; }

            /// <summary>
            /// AuthorizerResultTtlInSeconds
            /// The time to live (TTL), in seconds, of cached authorizer results. If it is zero, authorization
            /// caching is disabled. If it is greater than zero, API Gateway will cache authorizer responses. If
            /// this field is not set, the default value is 300. The maximum value is 3600, or 1 hour.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> AuthorizerResultTtlInSeconds { get; set; }

            /// <summary>
            /// IdentitySource
            /// The identity source for which authorization is requested.
            /// For the REQUEST authorizer, this is required when authorization caching is enabled. The value is a
            /// comma-separated string of one or more mapping expressions of the specified request parameters. For
            /// example, if an Auth header, a Name query string parameter are defined as identity sources, this
            /// value is $method. request. header. Auth, $method. request. querystring. Name. These parameters will
            /// be used to derive the authorization caching key and to perform runtime validation of the REQUEST
            /// authorizer by verifying all of the identity-related request parameters are present, not null and
            /// non-empty. Only when this is true does the authorizer invoke the authorizer Lambda function,
            /// otherwise, it returns a 401 Unauthorized response without calling the Lambda function. The valid
            /// value is a string of comma-separated mapping expressions of the specified request parameters. When
            /// the authorization caching is not enabled, this property is optional.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> IdentitySource { get; set; }

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
