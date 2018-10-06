using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLSchema
{
    /// <summary>
    /// AWS::AppSync::GraphQLSchema
    /// The AWS::AppSync::GraphQLSchema resource is used for your AWS AppSync GraphQL schema which controls the data
    /// model for your API. Schema files are text written in Schema Definition Language (SDL) format. You can find
    /// information on schema authoring at Designing a GraphQL API.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlschema.html
    /// </summary>
    public class GraphQLSchemaResource : ResourceBase
    {
        public class GraphQLSchemaProperties
        {
            /// <summary>
            /// Definition
            /// The text representation of a GraphQL schema in SDL format.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Definition { get; set; }

            /// <summary>
            /// DefinitionS3Location
            /// A location of a GraphQL schema file on an S3 bucket if you wish to provision with the schema living
            /// in S3 rather than embedded in your CloudFormation template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DefinitionS3Location { get; set; }

            /// <summary>
            /// ApiId
            /// The AWS AppSync GraphQL API identifier to which you will apply this schema.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

        }
    
        public string Type { get; } = "AWS::AppSync::GraphQLSchema";
        
        public GraphQLSchemaProperties Properties { get; } = new GraphQLSchemaProperties();

    }
}
