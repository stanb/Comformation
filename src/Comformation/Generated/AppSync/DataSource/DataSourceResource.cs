using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS::AppSync::DataSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html
    /// </summary>
    public class DataSourceResource : ResourceBase
    {
        public class DataSourceProperties
        {
            /// <summary>
            /// Type
            /// The type of the data source.
            /// AMAZON_DYNAMODB: The data source is an Amazon DynamoDB table. AMAZON_ELASTICSEARCH: The data source
            /// is an Amazon Elasticsearch Service domain. AWS_LAMBDA: The data source is an AWS Lambda function.
            /// NONE: There is no data source. This type is used when you wish to invoke a GraphQL operation without
            /// connecting to a data source, such as performing data transformation with resolvers or triggering a
            /// subscription to be invoked from a mutation. HTTP: The data source is an HTTP endpoint.
            /// RELATIONAL_DATABASE: The data source is a relational database.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Description
            /// The description of the data source.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ServiceRoleArn
            /// The AWS Identity and Access Management service role ARN for the data source. The system assumes this
            /// role when accessing the data source.
            /// Required if Type is specified as AWS_LAMBDA, AMAZON_DYNAMODB, or AMAZON_ELASTICSEARCH.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceRoleArn { get; set; }

            /// <summary>
            /// HttpConfig
            /// Endpoints for an HTTP data source.
            /// Required: No
            /// Type: HttpConfig
            /// Update requires: No interruption
            /// </summary>
            public HttpConfig HttpConfig { get; set; }

            /// <summary>
            /// RelationalDatabaseConfig
            /// Relational Database configuration of the relational database data source.
            /// Required: No
            /// Type: RelationalDatabaseConfig
            /// Update requires: No interruption
            /// </summary>
            public RelationalDatabaseConfig RelationalDatabaseConfig { get; set; }

            /// <summary>
            /// LambdaConfig
            /// An ARN of a Lambda function in valid ARN format. This can be the ARN of a Lambda function that
            /// exists in the current account or in another account.
            /// Required: No
            /// Type: LambdaConfig
            /// Update requires: No interruption
            /// </summary>
            public LambdaConfig LambdaConfig { get; set; }

            /// <summary>
            /// ApiId
            /// Unique AWS AppSync GraphQL API identifier where this data source will be created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// Name
            /// Friendly name for you to identify your AppSync data source after creation.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// DynamoDBConfig
            /// AWS Region and TableName for an Amazon DynamoDB table in your account.
            /// Required: No
            /// Type: DynamoDBConfig
            /// Update requires: No interruption
            /// </summary>
            public DynamoDBConfig DynamoDBConfig { get; set; }

            /// <summary>
            /// ElasticsearchConfig
            /// AWS Region and Endpoints for an Amazon Elasticsearch Service domain in your account.
            /// Required: No
            /// Type: ElasticsearchConfig
            /// Update requires: No interruption
            /// </summary>
            public ElasticsearchConfig ElasticsearchConfig { get; set; }

        }

        public string Type { get; } = "AWS::AppSync::DataSource";

        public DataSourceProperties Properties { get; } = new DataSourceProperties();

    }

    public static class DataSourceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DataSourceArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("DataSourceArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
