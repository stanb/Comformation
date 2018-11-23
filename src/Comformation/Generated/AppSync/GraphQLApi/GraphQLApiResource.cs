using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS::AppSync::GraphQLApi
    /// The AWS::AppSync::GraphQLApi resource will create a new AWS AppSync GraphQL API. This is the top level
    /// construct for your application. For more information see Quickstart Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html
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
            /// Type: OpenId Connect Config
            /// Update requires: No interruption
            /// </summary>
			public OpenIDConnectConfig OpenIDConnectConfig { get; set; }

            /// <summary>
            /// UserPoolConfig
            /// Optional authorization configuration for using Amazon Cognito User Pools with your GraphQL endpoint.
            /// Required: No
            /// Type: UserPoolConfig
            /// Update requires: No interruption
            /// </summary>
			public UserPoolConfig UserPoolConfig { get; set; }

            /// <summary>
            /// Name
            /// Friendly name for your GraphQL API in AWS AppSync.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// AuthenticationType
            /// Security configuration for your GraphQL API. For allowed values (such as API_KEY, AWS_IAM, or
            /// AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT), see Security in the AWS AppSync Developer Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AuthenticationType { get; set; }

            /// <summary>
            /// LogConfig
            /// Logging configuration when writing GraphQL operations and tracing to Amazon Cloudwatch.
            /// Required: No
            /// Type: LogConfig
            /// Update requires: No interruption
            /// </summary>
			public LogConfig LogConfig { get; set; }

        }

        public string Type { get; } = "AWS::AppSync::GraphQLApi";

        public GraphQLApiProperties Properties { get; } = new GraphQLApiProperties();

    }

	public static class GraphQLApiAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> GraphQLUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("GraphQLUrl");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ApiId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ApiId");
	}
}
