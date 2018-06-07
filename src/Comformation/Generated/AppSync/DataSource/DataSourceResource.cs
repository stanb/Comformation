using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppSync.DataSource
{
    /// <summary>
    /// AWS::AppSync::DataSource
    /// The AWS::AppSync::DataSource resource creates data sources for resolvers in AWS AppSync to connect to, such as
    /// Amazon DynamoDB, AWS Lambda, and Amazon Elasticserach Service. Resolvers use these data sources to fetch data
    /// when clients make GraphQL calls.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html
    /// </summary>
    public class DataSourceResource : ResourceBase
    {
        public class DataSourceProperties
        {
            /// <summary>
            /// Type
            /// Mandatory resource to return data from in customer AWS account. You can also specify NONE to use
            /// Local Resolvers. See Local Resolvers Tutorial for more information.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-type
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// Description
            /// Friendly description for this data source.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ServiceRoleArn
            /// IAM role ARN which the data source will use to connect to a resource.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-servicerolearn
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRoleArn { get; set; }

            /// <summary>
            /// LambdaConfig
            /// A valid ARN of a Lambda function in your account.
            /// Required: No
            /// Type: AWS AppSync DataSource LambdaConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-lambdaconfig
            /// </summary>
			public Union<LambdaConfig, IntrinsicFunction> LambdaConfig { get; set; }

            /// <summary>
            /// ApiId
            /// Unique AWS AppSync GraphQL API Identifier where this data source will be created.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-apiid
            /// </summary>
			public Union<string, IntrinsicFunction> ApiId { get; set; }

            /// <summary>
            /// Name
            /// Friendly name for you to identify your AppSync data source after creation.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// DynamoDBConfig
            /// AwsRegion and TableName for an Amazon DynamoDB table in your account.
            /// Required: No
            /// Type: AWS AppSync DataSource DynamoDBConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-dynamodbconfig
            /// </summary>
			public Union<DynamoDBConfig, IntrinsicFunction> DynamoDBConfig { get; set; }

            /// <summary>
            /// ElasticsearchConfig
            /// AwsRegion and Endpoints for an Amazon Elasticsearch Service domain in your account.
            /// Required: No
            /// Type: AWS AppSync DataSource ElasticsearchConfig
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-elasticsearchconfig
            /// </summary>
			public Union<ElasticsearchConfig, IntrinsicFunction> ElasticsearchConfig { get; set; }

        }
    
        public string Type { get; } = "AWS::AppSync::DataSource";
        
        public DataSourceProperties Properties { get; } = new DataSourceProperties();
    }

	public static class DataSourceAttributes
	{
        public static readonly ResourceAttribute<string> DataSourceArn = new ResourceAttribute<string>("DataSourceArn");
        public static readonly ResourceAttribute<string> Name = new ResourceAttribute<string>("Name");
	}
}
