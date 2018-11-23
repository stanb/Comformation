using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Authorizer
{
    /// <summary>
    /// AWS::ApiGateway::Authorizer
    /// The AWS::ApiGateway::Authorizer resource creates an authorization layer that Amazon API Gateway (API Gateway)
    /// activates for methods that have authorization enabled. API Gateway activates the authorizer when a client
    /// calls those methods.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html
    /// </summary>
    public class AuthorizerResource : ResourceBase
    {
        public class AuthorizerProperties
        {
            /// <summary>
            /// AuthType
            /// An optional customer-defined field that&#39;s used in Swagger imports and exports without functional
            /// impact.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthType { get; set; }

            /// <summary>
            /// AuthorizerCredentials
            /// The credentials that are required for the authorizer. To specify an AWS Identity and Access
            /// Management (IAM) role that API Gateway assumes, specify the role&#39;s Amazon Resource Name (ARN). To
            /// use resource-based permissions on the AWS Lambda (Lambda) function, specify null.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthorizerCredentials { get; set; }

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
            /// AuthorizerUri
            /// The authorizer&#39;s Uniform Resource Identifier (URI). If you specify TOKEN for the authorizer&#39;s Type
            /// property, specify a Lambda function URI that has the form
            /// arn:aws:apigateway:region:lambda:path/path. The path usually has the form
            /// /2015-03-31/functions/LambdaFunctionARN/invocations.
            /// Required: Conditional. Specify this property for Lambda functions only.
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthorizerUri { get; set; }

            /// <summary>
            /// IdentitySource
            /// The source of the identity in an incoming request.
            /// If you specify TOKEN or COGNITO_USER_POOLS for the Type property, specify a header mapping
            /// expression using the form method. request. header. name, where name is the name of a custom
            /// authorization header that clients submit as part of their requests.
            /// If you specify REQUEST for the Type property, specify a comma-separated string of one or more
            /// mapping expressions of the specified request parameter using the form method. request. parameter.
            /// name. For supported parameter types, see Configure Lambda Authorizer Using the API Gateway Console
            /// in the API Gateway Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> IdentitySource { get; set; }

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
            /// Name
            /// The name of the authorizer.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ProviderARNs
            /// A list of the Amazon Cognito user pool Amazon Resource Names (ARNs) to associate with this
            /// authorizer. For more information, see Use Amazon Cognito User Pools in the API Gateway Developer
            /// Guide.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> ProviderARNs { get; set; }

            /// <summary>
            /// RestApiId
            /// The ID of the RestApi resource that API Gateway creates the authorizer in.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> RestApiId { get; set; }

            /// <summary>
            /// Type
            /// The type of authorizer. Valid values include:
            /// TOKEN: A custom authorizer that uses a Lambda function. COGNITO_USER_POOLS: An authorizer that uses
            /// Amazon Cognito user pools. REQUEST: An authorizer that uses a Lambda function using incoming request
            /// parameters.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::Authorizer";

        public AuthorizerProperties Properties { get; } = new AuthorizerProperties();

    }
}
