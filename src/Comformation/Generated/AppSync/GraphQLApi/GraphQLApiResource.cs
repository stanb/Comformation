using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLApi
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html
    /// </summary>
    public class GraphQLApiResource : ResourceBase
    {
        public class GraphQLApiProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-openidconnectconfig
            /// </summary>
			public Union<OpenIDConnectConfig, IntrinsicFunction> OpenIDConnectConfig { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-userpoolconfig
            /// </summary>
			public Union<UserPoolConfig, IntrinsicFunction> UserPoolConfig { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-authenticationtype
            /// </summary>
			public Union<string, IntrinsicFunction> AuthenticationType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-logconfig
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
