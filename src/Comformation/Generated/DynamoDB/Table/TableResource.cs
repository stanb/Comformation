using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html
    /// </summary>
    public class TableResource : ResourceBase
    {
        public class TableProperties
        {
            /// <summary>
            /// AttributeDefinitions
            /// A list of attributes that describe the key schema for the table and indexes.
            /// This property is required to create a DynamoDB table.
            /// Update requires: Some interruptions. Replacement if you edit an existing AttributeDefinition.
            /// Required: Conditional
            /// Type: List of AttributeDefinition
            /// Update requires: Some interruptions
            /// </summary>
            public List<AttributeDefinition> AttributeDefinitions { get; set; }

            /// <summary>
            /// BillingMode
            /// Specify how you are charged for read and write throughput and how you manage capacity.
            /// Valid values include:
            /// PROVISIONED - We recommend using PROVISIONED for predictable workloads. PROVISIONED sets the billing
            /// mode to Provisioned Mode. PAY_PER_REQUEST - We recommend using PAY_PER_REQUEST for unpredictable
            /// workloads. PAY_PER_REQUEST sets the billing mode to On-Demand Mode.
            /// If not specified, the default is PROVISIONED.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> BillingMode { get; set; }

            /// <summary>
            /// GlobalSecondaryIndexes
            /// Global secondary indexes to be created on the table. You can create up to 20 global secondary
            /// indexes.
            /// Important If you update a table to include a new global secondary index, AWS CloudFormation
            /// initiates the index creation and then proceeds with the stack update. AWS CloudFormation doesn&#39;t
            /// wait for the index to complete creation because the backfilling phase can take a long time,
            /// depending on the size of the table. You can&#39;t use the index or update the table until the index&#39;s
            /// status is ACTIVE. You can track its status by using the DynamoDB DescribeTable command. If you add
            /// or delete an index during an update, we recommend that you don&#39;t update any other resources. If your
            /// stack fails to update and is rolled back while adding a new index, you must manually delete the
            /// index. Updates are not supported. The following are exceptions: If you update only the provisioned
            /// throughput values of global secondary indexes, you can update the table without interruption. You
            /// can delete or add one global secondary index without interruption. If you do both in the same update
            /// (for example, by changing the index&#39;s logical ID), the update fails.
            /// Required: No
            /// Type: List of GlobalSecondaryIndex
            /// Update requires: No interruption
            /// </summary>
            public List<GlobalSecondaryIndex> GlobalSecondaryIndexes { get; set; }

            /// <summary>
            /// KeySchema
            /// Specifies the attributes that make up the primary key for the table. The attributes in the KeySchema
            /// property must also be defined in the AttributeDefinitions property.
            /// Required: Yes
            /// Type: List of KeySchema
            /// Update requires: Replacement
            /// </summary>
            public List<KeySchema> KeySchema { get; set; }

            /// <summary>
            /// LocalSecondaryIndexes
            /// Local secondary indexes to be created on the table. You can create up to 5 local secondary indexes.
            /// Each index is scoped to a given hash key value. The size of each hash key can be up to 10 gigabytes.
            /// Required: No
            /// Type: List of LocalSecondaryIndex
            /// Update requires: Replacement
            /// </summary>
            public List<LocalSecondaryIndex> LocalSecondaryIndexes { get; set; }

            /// <summary>
            /// PointInTimeRecoverySpecification
            /// The settings used to enable point in time recover.
            /// Required: No
            /// Type: PointInTimeRecoverySpecification
            /// Update requires: No interruption
            /// </summary>
            public PointInTimeRecoverySpecification PointInTimeRecoverySpecification { get; set; }

            /// <summary>
            /// ProvisionedThroughput
            /// Throughput for the specified table, which consists of values for ReadCapacityUnits and
            /// WriteCapacityUnits. For more information about the contents of a provisioned throughput structure,
            /// see Amazon DynamoDB Table ProvisionedThroughput.
            /// If you set BillingMode as PROVISIONED, you must specify this property. If you set BillingMode as
            /// PAY_PER_REQUEST, you cannot specify this property.
            /// Required: Conditional
            /// Type: ProvisionedThroughput
            /// Update requires: No interruption
            /// </summary>
            public ProvisionedThroughput ProvisionedThroughput { get; set; }

            /// <summary>
            /// SSESpecification
            /// Specifies the settings to enable server-side encryption.
            /// Required: No
            /// Type: SSESpecification
            /// Update requires: Some interruptions
            /// </summary>
            public SSESpecification SSESpecification { get; set; }

            /// <summary>
            /// StreamSpecification
            /// The settings for the DynamoDB table stream, which capture changes to items stored in the table.
            /// Required: No
            /// Type: StreamSpecification
            /// Update requires: No interruption
            /// </summary>
            public StreamSpecification StreamSpecification { get; set; }

            /// <summary>
            /// TableName
            /// A name for the table. If you don&#39;t specify a name, AWS CloudFormation generates a unique physical ID
            /// and uses that ID for the table name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Minimum: 3
            /// Maximum: 255
            /// Pattern: [a-zA-Z0-9_. -]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TableName { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TimeToLiveSpecification
            /// Specifies the Time to Live (TTL) settings for the table.
            /// Note For detailed information about the limits in DynamoDB, see Limits in Amazon DynamoDB in the
            /// Amazon DynamoDB Developer Guide.
            /// Required: No
            /// Type: TimeToLiveSpecification
            /// Update requires: No interruption
            /// </summary>
            public TimeToLiveSpecification TimeToLiveSpecification { get; set; }

        }

        public string Type { get; } = "AWS::DynamoDB::Table";

        public TableProperties Properties { get; } = new TableProperties();

    }

    public static class TableAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StreamArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("StreamArn");
    }
}
