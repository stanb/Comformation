using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.GlobalTable
{
    /// <summary>
    /// AWS::DynamoDB::GlobalTable KeySchema
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-globaltable-keyschema.html
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
        /// Update requires: Replacement
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
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KeyType")]
        public Union<string, IntrinsicFunction> KeyType { get; set; }

    }
}
