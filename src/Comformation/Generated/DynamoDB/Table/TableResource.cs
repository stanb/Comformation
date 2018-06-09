using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table
    /// The AWS::DynamoDB::Table resource creates a DynamoDB table. For more information, see CreateTable in the
    /// Amazon DynamoDB API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class TableResource : ResourceBase
    {
        public class TableProperties
        {
            /// <summary>
            /// AttributeDefinitions
            /// A list of attributes that describe the key schema for the table and indexes. Duplicates are allowed.
            /// Required: Yes
            /// Type: List of DynamoDB Table AttributeDefinition
            /// Update requires: Some interruptions. Replacement if you edit an existing AttributeDefinition.
            /// </summary>
			public Union<List<AttributeDefinition>, IntrinsicFunction> AttributeDefinitions { get; set; }

            /// <summary>
            /// GlobalSecondaryIndexes
            /// Global secondary indexes to be created on the table. You can create up to 5 global secondary
            /// indexes.
            /// Important If you update a table to include a new global secondary index, AWS CloudFormation
            /// initiates the index creation and then proceeds with the stack update. AWS CloudFormation doesn&#39;t
            /// wait for the index to complete creation because the backfilling phase can take a long time,
            /// depending on the size of the table. You can&#39;t use the index or update the table until the index&#39;s
            /// status is ACTIVE. You can track its status by using the DynamoDB DescribeTable command. If you add
            /// or delete an index during an update, we recommend that you don&#39;t update any other resources. If your
            /// stack fails to update and is rolled back while adding a new index, you must manually delete the
            /// index.
            /// Required: No
            /// Type: List of DynamoDB Table GlobalSecondaryIndex
            /// Update requires: Updates are not supported. The following are exceptions:
            /// If you update only the provisioned throughput values of global secondary indexes, you can update the
            /// table without interruption. You can delete or add one global secondary index without interruption.
            /// If you do both in the same update (for example, by changing the index&#39;s logical ID), the update
            /// fails.
            /// </summary>
			public Union<List<GlobalSecondaryIndex>, IntrinsicFunction> GlobalSecondaryIndexes { get; set; }

            /// <summary>
            /// KeySchema
            /// Specifies the attributes that make up the primary key for the table. The attributes in the KeySchema
            /// property must also be defined in the AttributeDefinitions property.
            /// Required: Yes
            /// Type: List of DynamoDB Table KeySchema
            /// Update requires: Replacement
            /// </summary>
			public Union<List<KeySchema>, IntrinsicFunction> KeySchema { get; set; }

            /// <summary>
            /// LocalSecondaryIndexes
            /// Local secondary indexes to be created on the table. You can create up to 5 local secondary indexes.
            /// Each index is scoped to a given hash key value. The size of each hash key can be up to 10 gigabytes.
            /// Required: No
            /// Type: List of DynamoDB Table LocalSecondaryIndex
            /// Update requires: Replacement
            /// </summary>
			public Union<List<LocalSecondaryIndex>, IntrinsicFunction> LocalSecondaryIndexes { get; set; }

            /// <summary>
            /// PointInTimeRecoverySpecification
            /// The settings used to enable point in time recovery.
            /// Required: No
            /// Type: DynamoDB Table PointInTimeRecoverySpecification
            /// Update requires: No interruption
            /// </summary>
			public Union<PointInTimeRecoverySpecification, IntrinsicFunction> PointInTimeRecoverySpecification { get; set; }

            /// <summary>
            /// ProvisionedThroughput
            /// Throughput for the specified table, which consists of values for ReadCapacityUnits and
            /// WriteCapacityUnits. For more information about the contents of a provisioned throughput structure,
            /// see Amazon DynamoDB Table ProvisionedThroughput.
            /// Required: Yes
            /// Type: DynamoDB Table ProvisionedThroughput
            /// Update requires: No interruption
            /// </summary>
			public Union<ProvisionedThroughput, IntrinsicFunction> ProvisionedThroughput { get; set; }

            /// <summary>
            /// SSESpecification
            /// Specifies the settings to enable server-side encryption.
            /// Required: No
            /// Type: DynamoDB SSESpecification
            /// Update requires: Some interruptions
            /// </summary>
			public Union<SSESpecification, IntrinsicFunction> SSESpecification { get; set; }

            /// <summary>
            /// StreamSpecification
            /// The settings for the DynamoDB table stream, which capture changes to items stored in the table.
            /// Required: No
            /// Type: DynamoDB Table StreamSpecification
            /// Update requires: No interruption to the table. However, the stream is replaced.
            /// </summary>
			public Union<StreamSpecification, IntrinsicFunction> StreamSpecification { get; set; }

            /// <summary>
            /// TableName
            /// A name for the table. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID
            /// and uses that ID for the table name. For more information, see Name Type.
            /// 			
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> TableName { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this table. Use tags to
            /// manage your resources.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: No interruption
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// TimeToLiveSpecification
            /// Specifies the Time to Live (TTL) settings for the table.
            /// Required: No
            /// Type: DynamoDB Table TimeToLiveSpecification
            /// Update requires: No interruption
            /// </summary>
			public Union<TimeToLiveSpecification, IntrinsicFunction> TimeToLiveSpecification { get; set; }

        }
    
        public string Type { get; } = "AWS::DynamoDB::Table";
        
        public TableProperties Properties { get; } = new TableProperties();
    }

	public static class TableAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
        public static readonly ResourceAttribute<string> StreamArn = new ResourceAttribute<string>("StreamArn");
	}
}
