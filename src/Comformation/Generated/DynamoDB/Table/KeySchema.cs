using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// Amazon DynamoDB Table KeySchema
    /// Describes a primary key for the AWS::DynamoDB::Table resource or a key schema for an index. Each element is
    /// composed of an AttributeName and KeyType.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-keyschema.html
    /// </summary>
    public class KeySchema
    {

        /// <summary>
        /// AttributeName
        /// The attribute name that is used as the primary key for this table. Primary key element names can be
        /// 1 – 255 characters long and have no character restrictions.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("AttributeName")]
        public Union<string, IntrinsicFunction> AttributeName { get; set; }

        /// <summary>
        /// KeyType
        /// Represents the attribute data, consisting of the data type and the attribute value itself. You can
        /// specify HASH or RANGE.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("KeyType")]
        public Union<string, IntrinsicFunction> KeyType { get; set; }

    }
}
