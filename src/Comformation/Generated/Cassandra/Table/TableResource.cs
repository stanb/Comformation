using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cassandra.Table
{
    /// <summary>
    /// AWS::Cassandra::Table
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-table.html
    /// </summary>
    public class TableResource : ResourceBase
    {
        public class TableProperties
        {
            /// <summary>
            /// KeyspaceName
            /// The name of the keyspace in which to create the table. The keyspace must already exist.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KeyspaceName { get; set; }

            /// <summary>
            /// TableName
            /// The name of the table to be created. If you don&#39;t specify a name, AWS CloudFormation generates a
            /// unique ID and uses that ID for the table name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Length Constraints: Minimum length of 3. Maximum length of 255.
            /// Pattern: ^[a-zA-Z0-9][a-zA-Z0-9_]{1,47}$
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TableName { get; set; }

            /// <summary>
            /// RegularColumns
            /// One or more columns that are not part of the primary key - that is, columns that are not defined as
            /// partition key columns or clustering key columns.
            /// Required: No
            /// Type: List of Column
            /// Update requires: No interruption
            /// </summary>
            public List<Column> RegularColumns { get; set; }

            /// <summary>
            /// PartitionKeyColumns
            /// One or more columns that uniquely identify every row in the table. Every table must have a partition
            /// key.
            /// Required: Yes
            /// Type: List of Column
            /// Update requires: Replacement
            /// </summary>
            public List<Column> PartitionKeyColumns { get; set; }

            /// <summary>
            /// ClusteringKeyColumns
            /// One or more columns that determine how the table data is sorted.
            /// Required: No
            /// Type: List of ClusteringKeyColumn
            /// Update requires: Replacement
            /// </summary>
            public List<ClusteringKeyColumn> ClusteringKeyColumns { get; set; }

            /// <summary>
            /// BillingMode
            /// The billing mode for the table, which determines how you&#39;ll be charged for reads and writes:
            /// On-demand mode (default) - you pay based on the actual reads and writes your application performs.
            /// Provisioned mode - lets you specify the number of reads and writes per second that you need for your
            /// application.
            /// If you don&#39;t specify a value for this property, then the table will use on-demand mode.
            /// Required: No
            /// Type: BillingMode
            /// Update requires: No interruption
            /// </summary>
            public BillingMode BillingMode { get; set; }

        }

        public string Type { get; } = "AWS::Cassandra::Table";

        public TableProperties Properties { get; } = new TableProperties();

    }
}
