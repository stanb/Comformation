using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// Amazon DynamoDB Table LocalSecondaryIndex
    /// Describes local secondary indexes for the AWS::DynamoDB::Table resource. Each index is scoped to a given hash
    /// key value. Tables with one or more local secondary indexes are subject to an item collection size limit, where
    /// the amount of data within a given item collection cannot exceed 10 GB.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-lsi.html
    /// </summary>
    public class LocalSecondaryIndex
    {

        /// <summary>
        /// IndexName
        /// The name of the local secondary index. The index name can be 3 – 255 characters long and have no
        /// character restrictions.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("IndexName")]
        public Union<string, IntrinsicFunction> IndexName { get; set; }

        /// <summary>
        /// KeySchema
        /// The complete index key schema for the local secondary index, which consists of one or more pairs of
        /// attribute names and key types. For local secondary indexes, the hash key must be the same as that of
        /// the source table.
        /// Required: Yes
        /// Type: List of DynamoDB Table KeySchema
        /// </summary>
        [JsonProperty("KeySchema")]
        public List<KeySchema> KeySchema { get; set; }

        /// <summary>
        /// Projection
        /// Attributes that are copied (projected) from the source table into the index. These attributes are
        /// additions to the primary key attributes and index key attributes, which are automatically projected.
        /// Required: Yes
        /// Type: DynamoDB Table Projection
        /// </summary>
        [JsonProperty("Projection")]
        public Projection Projection { get; set; }

    }
}
