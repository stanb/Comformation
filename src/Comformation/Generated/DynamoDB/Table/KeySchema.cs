using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table KeySchema
    /// Represents a single element of a key schema. A key schema specifies the attributes that make up the primary
    /// key of a table, or the key attributes of an index.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-keyschema.html
    /// </summary>
    public class KeySchema
    {

        /// <summary>
        /// AttributeName
        /// The name of a key attribute.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeName")]
        public Union<string, IntrinsicFunction> AttributeName { get; set; }

        /// <summary>
        /// KeyType
        /// The role that this key attribute will assume:
        /// HASH - partition key RANGE - sort key
        /// Note The partition key of an item is also known as its hash attribute. The term &quot;hash attribute&quot;
        /// derives from DynamoDB&#39;s usage of an internal hash function to evenly distribute data items across
        /// partitions, based on their partition key values. The sort key of an item is also known as its range
        /// attribute. The term &quot;range attribute&quot; derives from the way DynamoDB stores items with the same
        /// partition key physically close together, in sorted order by the sort key value.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: HASH | RANGE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("KeyType")]
        public Union<string, IntrinsicFunction> KeyType { get; set; }

    }
}
