using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-globaltable.html
    /// </summary>
    public class GlobalTableResource : ResourceBase
    {
        public class GlobalTableProperties
        {
            /// <summary>
            /// AttributeDefinitions
            /// A list of attributes that describe the key schema for the global table and indexes.
            /// Required: Yes
            /// Type: List of AttributeDefinition
            /// Update requires: No interruption
            /// </summary>
            public List<AttributeDefinition> AttributeDefinitions { get; set; }

            /// <summary>
            /// BillingMode
            /// Specifies how you are charged for read and write throughput and how you manage capacity. Valid
            /// values are:
            /// PAY_PER_REQUEST PROVISIONED
            /// All replicas in your global table will have the same billing mode. If you use PROVISIONED billing
            /// mode, you must provide an auto scaling configuration via the WriteProvisionedThroughputSettings
            /// property. The default value of this property is PROVISIONED.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> BillingMode { get; set; }

            /// <summary>
            /// GlobalSecondaryIndexes
            /// Global secondary indexes to be created on the global table. You can create up to 20 global secondary
            /// indexes. Each replica in your global table will have the same global secondary index settings. You
            /// can only create or delete one global secondary index in a single stack operation.
            /// Since the backfilling of an index could take a long time, CloudFormation does not wait for the index
            /// to become active. If a stack operation rolls back, CloudFormation might not delete an index that has
            /// been added. In that case, you will need to delete the index manually.
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
            /// Local secondary indexes to be created on the table. You can create up to five local secondary
            /// indexes. Each index is scoped to a given hash key value. The size of each hash key can be up to 10
            /// gigabytes. Each replica in your global table will have the same local secondary index settings.
            /// Required: No
            /// Type: List of LocalSecondaryIndex
            /// Update requires: Replacement
            /// </summary>
            public List<LocalSecondaryIndex> LocalSecondaryIndexes { get; set; }

            /// <summary>
            /// WriteProvisionedThroughputSettings
            /// Specifies an auto scaling policy for write capacity. This policy will be applied to all replicas.
            /// This setting must be specified if BillingMode is set to PROVISIONED.
            /// Required: No
            /// Type: WriteProvisionedThroughputSettings
            /// Update requires: No interruption
            /// </summary>
            public WriteProvisionedThroughputSettings WriteProvisionedThroughputSettings { get; set; }

            /// <summary>
            /// Replicas
            /// Specifies the list of replicas for your global table. The list must contain at least one element,
            /// the region where the stack defining the global table is deployed. For example, if you define your
            /// table in a stack deployed to us-east-1, you must have an entry in Replicas with the region
            /// us-east-1. You cannot remove the replica in the stack region.
            /// Important Adding a replica might take a few minutes for an empty table, or up to several hours for
            /// large tables. If you want to add or remove a replica, we recommend submitting an UpdateStack
            /// operation containing only that change. If you add or delete a replica during an update, we recommend
            /// that you don&#39;t update any other resources. If your stack fails to update and is rolled back while
            /// adding a new replica, you might need to manually delete the replica.
            /// You can create a new global table with up to two replicas. You can add or remove replicas after
            /// table creation, but you can only add or remove a single replica in each update.
            /// Required: Yes
            /// Type: List of ReplicaSpecification
            /// Update requires: No interruption
            /// </summary>
            public List<ReplicaSpecification> Replicas { get; set; }

            /// <summary>
            /// SSESpecification
            /// Specifies the settings to enable server-side encryption. These settings will be applied to all
            /// replicas. If you plan to use customer-managed KMS keys, you must provide a key for each replica
            /// using the ReplicaSpecification. ReplicaSSESpecification property.
            /// Required: No
            /// Type: SSESpecification
            /// Update requires: No interruption
            /// </summary>
            public SSESpecification SSESpecification { get; set; }

            /// <summary>
            /// StreamSpecification
            /// Specifies the streams settings on your global table. You must provide a value for this property if
            /// your global table contains more than one replica. You can only change the streams settings if your
            /// global table has only one replica.
            /// Required: No
            /// Type: StreamSpecification
            /// Update requires: No interruption
            /// </summary>
            public StreamSpecification StreamSpecification { get; set; }

            /// <summary>
            /// TableName
            /// A name for the global table. If you don&#39;t specify a name, AWS CloudFormation generates a unique ID
            /// and uses that ID as the table name. For more information, see Name type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TableName { get; set; }

            /// <summary>
            /// TimeToLiveSpecification
            /// Specifies the time to live (TTL) settings for the table. This setting will be applied to all
            /// replicas.
            /// Required: No
            /// Type: TimeToLiveSpecification
            /// Update requires: No interruption
            /// </summary>
            public TimeToLiveSpecification TimeToLiveSpecification { get; set; }

        }

        public string Type { get; } = "AWS::DynamoDB::GlobalTable";

        public GlobalTableProperties Properties { get; } = new GlobalTableProperties();

    }

    public static class GlobalTableAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StreamArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("StreamArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TableId = new ResourceAttribute<Union<string, IntrinsicFunction>>("TableId");
    }
}
