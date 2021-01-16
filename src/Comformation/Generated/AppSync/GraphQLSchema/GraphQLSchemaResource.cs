using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.GraphQLSchema
{
    /// <summary>
    /// AWS::AppSync::GraphQLSchema
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlschema.html
    /// </summary>
    public class GraphQLSchemaResource : ResourceBase
    {
        public class GraphQLSchemaProperties
        {
            /// <summary>
            /// Definition
            /// The text representation of a GraphQL schema in SDL format.
            /// For more information about using the Ref function, see Ref.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Definition { get; set; }

            /// <summary>
            /// DefinitionS3Location
            /// The location of a GraphQL schema file in an Amazon S3 bucket. Use this if you want to provision with
            /// the schema living in Amazon S3 rather than embedding it in your CloudFormation template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefinitionS3Location { get; set; }

            /// <summary>
            /// ApiId
            /// The AWS AppSync GraphQL API identifier to which you want to apply this schema.
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
