using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS::AppSync::GraphQLApi
    /// The AWS::AppSync::GraphQLApi resource will create a new AWS AppSync GraphQL API. This is the top level
    /// construct for your application. For more information see Quickstart Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html
    /// </summary>
    public class GraphQLApiResource : ResourceBase
    {
        public class GraphQLApiProperties
        {
            /// <summary>
            /// OpenIDConnectConfig
            /// Optional authorization configuration for using an OpenId Connect compliant service with your GraphQL
            /// endpoint.
            /// Required: No
            /// Type: AWS AppSync GraphQLApi OpenId Connect Config
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-openidconnectconfig
            /// </summary>
			public Union<OpenIDConnectConfig, IntrinsicFunction> OpenIDConnectConfig { get; set; }

            /// <summary>
            /// UserPoolConfig
            /// Optional authorization configuration for using Amazon Cognito User Pools with your GraphQL endpoint.
            /// Required: No
            /// Type: AWS AppSync GraphQLApi UserPoolConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-userpoolconfig
            /// </summary>
			public Union<UserPoolConfig, IntrinsicFunction> UserPoolConfig { get; set; }

            /// <summary>
            /// Name
            /// Friendly name for your GraphQL API in AWS AppSync.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// AuthenticationType
            /// Security configuration for your GraphQL API. For allowed values (such as API_KEY, AWS_IAM, or
            /// AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT), see Security in the AWS AppSync Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-authenticationtype
            /// </summary>
			public Union<string, IntrinsicFunction> AuthenticationType { get; set; }

            /// <summary>
            /// LogConfig
            /// Logging configuration when writing GraphQL operations and tracing to Amazon Cloudwatch.
            /// Required: No
            /// Type: AWS AppSync GraphQLApi LogConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-logconfig
            /// </summary>
			public Union<LogConfig, IntrinsicFunction> LogConfig { get; set; }

        }
    
        public string Type { get; } = "AWS::AppSync::GraphQLApi";
        
        public GraphQLApiProperties Properties { get; } = new GraphQLApiProperties();
    }

	public static class GraphQLApiAttributes
	{
        public static readonly ResourceAttribute<string> GraphQLUrl = new ResourceAttribute<string>("GraphQLUrl");
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> ApiId = new ResourceAttribute<string>("ApiId");
	}
}
