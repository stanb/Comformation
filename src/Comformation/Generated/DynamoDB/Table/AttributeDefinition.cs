using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DynamoDB.Table
{
    /// <summary>
    /// Amazon DynamoDB Table AttributeDefinition
    /// The AttributeDefinition property type represents an attribute for describing the key schema for a DynamoDB
    /// table and indexes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-attributedef.html
    /// </summary>
    public class AttributeDefinition
    {

        /// <summary>
        /// AttributeName
        /// The name of an attribute. Attribute names can be 1 – 255 characters long and have no character
        /// restrictions.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("AttributeName")]
        public Union<string, IntrinsicFunction> AttributeName { get; set; }

        /// <summary>
        /// AttributeType
        /// The data type for the attribute. You can specify S for string data, N for numeric data, or B for
        /// binary data.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("AttributeType")]
        public Union<string, IntrinsicFunction> AttributeType { get; set; }

    }
}
