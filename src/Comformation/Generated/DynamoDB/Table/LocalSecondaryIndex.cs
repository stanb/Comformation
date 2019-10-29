using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table LocalSecondaryIndex
    /// Represents the properties of a local secondary index.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-lsi.html
    /// </summary>
    public class LocalSecondaryIndex
    {

        /// <summary>
        /// IndexName
        /// The name of the local secondary index. The name must be unique among all other indexes on this
        /// table.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IndexName")]
        public Union<string, IntrinsicFunction> IndexName { get; set; }

        /// <summary>
        /// KeySchema
        /// The complete key schema for the local secondary index, consisting of one or more pairs of attribute
        /// names and key types:
        /// HASH - partition key RANGE - sort key
        /// Note The partition key of an item is also known as its hash attribute. The term &quot;hash attribute&quot;
        /// derives from DynamoDB&#39;s usage of an internal hash function to evenly distribute data items across
        /// partitions, based on their partition key values. The sort key of an item is also known as its range
        /// attribute. The term &quot;range attribute&quot; derives from the way DynamoDB stores items with the same
        /// partition key physically close together, in sorted order by the sort key value.
        /// Required: Yes
        /// Type: List of KeySchema
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeySchema")]
        public List<KeySchema> KeySchema { get; set; }

        /// <summary>
        /// Projection
        /// Represents attributes that are copied (projected) from the table into the local secondary index.
        /// These are in addition to the primary key attributes and index key attributes, which are
        /// automatically projected.
        /// Required: Yes
        /// Type: Projection
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Projection")]
        public Projection Projection { get; set; }

    }
}
