using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    /// AWS::AppSync::GraphQLApi
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html
    /// </summary>
    public class GraphQLApiResource : ResourceBase
    {
        public class GraphQLApiProperties
        {
            /// <summary>
            /// OpenIDConnectConfig
            /// The OpenID Connect configuration.
            /// Required: No
            /// Type: OpenIDConnectConfig
            /// Update requires: No interruption
            /// </summary>
            public OpenIDConnectConfig OpenIDConnectConfig { get; set; }

            /// <summary>
            /// LambdaAuthorizerConfig
            /// A LambdaAuthorizerConfig holds configuration on how to authorize AWS AppSync API access when using
            /// the AWS_LAMBDA authorizer mode. Be aware that an AWS AppSync API may have only one Lambda authorizer
            /// configured at a time.
            /// Required: No
            /// Type: LambdaAuthorizerConfig
            /// Update requires: No interruption
            /// </summary>
            public LambdaAuthorizerConfig LambdaAuthorizerConfig { get; set; }

            /// <summary>
            /// XrayEnabled
            /// A flag representing whether X-Ray tracing is enabled for this GraphqlApi.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> XrayEnabled { get; set; }

            /// <summary>
            /// UserPoolConfig
            /// Optional authorization configuration for using Amazon Cognito user pools with your GraphQL endpoint.
            /// Required: No
            /// Type: UserPoolConfig
            /// Update requires: No interruption
            /// </summary>
            public UserPoolConfig UserPoolConfig { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key-value pairs) for this GraphQL API.
            /// Required: No
            /// Type: Tags
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The API name.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// AuthenticationType
            /// Security configuration for your GraphQL API. For allowed values (such as API_KEY, AWS_IAM,
            /// AMAZON_COGNITO_USER_POOLS, OPENID_CONNECT, or AWS_LAMBDA), see Security in the AWS AppSync Developer
            /// Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AuthenticationType { get; set; }

            /// <summary>
            /// LogConfig
            /// The Amazon CloudWatch Logs configuration.
            /// Required: No
            /// Type: LogConfig
            /// Update requires: No interruption
            /// </summary>
            public LogConfig LogConfig { get; set; }

            /// <summary>
            /// AdditionalAuthenticationProviders
            /// A list of additional authentication providers for the GraphqlApi API.
            /// Required: No
            /// Type: AdditionalAuthenticationProviders
            /// Update requires: No interruption
            /// </summary>
            public List<AdditionalAuthenticationProvider> AdditionalAuthenticationProviders { get; set; }

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
