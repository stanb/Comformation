using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule DynamoDBAction
    /// DynamoDB is a property of the Actions property that describes an AWS IoT action that writes data to a DynamoDB
    /// table.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html
    /// </summary>
    public class DynamoDBAction
    {

        /// <summary>
        /// HashKeyField
        /// The name of the hash key.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("HashKeyField")]
        public Union<string, IntrinsicFunction> HashKeyField { get; set; }

        /// <summary>
        /// HashKeyType
        /// The data type of the hash key (also called the partition key). Valid values are: &quot;STRING&quot; or
        /// &quot;NUMBER&quot;.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("HashKeyType")]
        public Union<string, IntrinsicFunction> HashKeyType { get; set; }

        /// <summary>
        /// HashKeyValue
        /// The value of the hash key.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("HashKeyValue")]
        public Union<string, IntrinsicFunction> HashKeyValue { get; set; }

        /// <summary>
        /// PayloadField
        /// The name of the column in the DynamoDB table that contains the result of the query. You can
        /// customize this name.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("PayloadField")]
        public Union<string, IntrinsicFunction> PayloadField { get; set; }

        /// <summary>
        /// RangeKeyField
        /// The name of the range key.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("RangeKeyField")]
        public Union<string, IntrinsicFunction> RangeKeyField { get; set; }

        /// <summary>
        /// RangeKeyType
        /// The data type of the range key (also called the sort key). Valid values are: &quot;STRING&quot; or &quot;NUMBER&quot;.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("RangeKeyType")]
        public Union<string, IntrinsicFunction> RangeKeyType { get; set; }

        /// <summary>
        /// RangeKeyValue
        /// The value of the range key.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("RangeKeyValue")]
        public Union<string, IntrinsicFunction> RangeKeyValue { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to the DynamoDB table.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// TableName
        /// The name of the DynamoDB table.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

    }
}
