using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLSchema
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlschema.html
    /// </summary>
    public class GraphQLSchemaResource : ResourceBase
    {
        public class GraphQLSchemaProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlschema.html#cfn-appsync-graphqlschema-definition
            /// </summary>
			public Union<string, IntrinsicFunction> Definition { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlschema.html#cfn-appsync-graphqlschema-definitions3location
            /// </summary>
			public Union<string, IntrinsicFunction> DefinitionS3Location { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlschema.html#cfn-appsync-graphqlschema-apiid
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

        }
    
        public string Type { get; } = "AWS::AppSync::GraphQLSchema";
        
        public GraphQLSchemaProperties Properties { get; } = new GraphQLSchemaProperties();
    }
}
