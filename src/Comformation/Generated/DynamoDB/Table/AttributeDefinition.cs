using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// AWS::DynamoDB::Table AttributeDefinition
    /// Represents an attribute for describing the key schema for the table and indexes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-attributedef.html
    /// </summary>
    public class AttributeDefinition
    {

        /// <summary>
        /// AttributeName
        /// A name for the attribute.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeName")]
        public Union<string, IntrinsicFunction> AttributeName { get; set; }

        /// <summary>
        /// AttributeType
        /// The data type for the attribute, where:
        /// S - the attribute is of type String N - the attribute is of type Number B - the attribute is of type
        /// Binary
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeType")]
        public Union<string, IntrinsicFunction> AttributeType { get; set; }

    }
}
