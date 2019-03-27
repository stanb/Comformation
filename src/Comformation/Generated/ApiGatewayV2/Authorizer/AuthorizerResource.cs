using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGatewayV2.Authorizer
{
    /// <summary>
    /// AWS::ApiGatewayV2::Authorizer
    /// The AWS::ApiGatewayV2::Authorizer resource creates an authorization layer for an Amazon API Gateway (API
    /// Gateway) API.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html
    /// </summary>
    public class AuthorizerResource : ResourceBase
    {
        public class AuthorizerProperties
        {
            /// <summary>
            /// IdentityValidationExpression
            /// A validation expression for the incoming identity. If you specify TOKEN for the authorizer&#39;s Type
            /// property, specify a regular expression. API Gateway uses the expression to attempt to match the
            /// incoming client token, and proceeds if the token matches. If the token doesn&#39;t match, API Gateway
            /// responds with a 401 (unauthorized request) error code.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IdentityValidationExpression { get; set; }

            /// <summary>
            /// AuthorizerUri
            /// The authorizer&#39;s Uniform Resource Identifier (URI). If you specify TOKEN for the authorizer&#39;s Type
            /// property, specify a Lambda function URI that has the form
            /// arn:aws:apigateway:region:lambda:path/path. The path usually has the form
            /// /2015-03-31/functions/LambdaFunctionARN/invocations.
            /// Required: Yes
            /// Specify this property for Lambda functions only.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthorizerUri { get; set; }

            /// <summary>
            /// AuthorizerCredentialsArn
            /// The credentials that are required for the authorizer. To specify an AWS Identity and Access
            /// Management (IAM) role that API Gateway assumes, specify the role&#39;s Amazon Resource Name (ARN). To
            /// use resource-based permissions on the AWS Lambda (Lambda) function, specify null.
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
            /// The time-to-live (TTL) period, in seconds, that specifies how long API Gateway caches authorizer
            /// results. If you specify a value greater than 0, API Gateway caches the authorizer responses. By
            /// default, API Gateway sets this property to 300. The maximum value is 3600, or 1 hour.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> AuthorizerResultTtlInSeconds { get; set; }

            /// <summary>
            /// IdentitySource
            /// The source of the identity in an incoming request.
            /// If you specify REQUEST for the Type property, specify a comma-separated string of one or more
            /// mapping expressions of the specified request parameter using the form method. request. parameter.
            /// name.
            /// Required: Yes
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> IdentitySource { get; set; }

            /// <summary>
            /// ApiId
            /// The ID of the Api resource that API Gateway creates the authorizer in.
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
