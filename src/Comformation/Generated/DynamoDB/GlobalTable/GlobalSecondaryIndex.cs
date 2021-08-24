using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable GlobalSecondaryIndex
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-globalsecondaryindex.html
    /// </summary>
    public class GlobalSecondaryIndex
    {

        /// <summary>
        /// IndexName
        /// The name of the global secondary index. The name must be unique among all other indexes on this
        /// table.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("IndexName")]
        public Union<string, IntrinsicFunction> IndexName { get; set; }

        /// <summary>
        /// KeySchema
        /// The complete key schema for a global secondary index, which consists of one or more pairs of
        /// attribute names and key types:
        /// HASH - partition key RANGE - sort key
        /// Note The partition key of an item is also known as its hash attribute. The term &quot;hash attribute&quot;
        /// derives from DynamoDB&#39;s usage of an internal hash function to evenly distribute data items across
        /// partitions, based on their partition key values. The sort key of an item is also known as its range
        /// attribute. The term &quot;range attribute&quot; derives from the way DynamoDB stores items with the same
        /// partition key physically close together, in sorted order by the sort key value.
        /// Required: Yes
        /// Type: List of KeySchema
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KeySchema")]
        public List<KeySchema> KeySchema { get; set; }

        /// <summary>
        /// Projection
        /// Represents attributes that are copied (projected) from the table into the global secondary index.
        /// These are in addition to the primary key attributes and index key attributes, which are
        /// automatically projected.
        /// Required: Yes
        /// Type: Projection
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Projection")]
        public Projection Projection { get; set; }

        /// <summary>
        /// WriteProvisionedThroughputSettings
        /// Defines write capacity settings for the global secondary index. You must specify a value for this
        /// property if the table&#39;s BillingMode is PROVISIONED. All replicas will have the same write capacity
        /// settings for this global secondary index.
        /// Required: No
        /// Type: WriteProvisionedThroughputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WriteProvisionedThroughputSettings")]
        public WriteProvisionedThroughputSettings WriteProvisionedThroughputSettings { get; set; }

    }
}
