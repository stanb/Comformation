using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule DynamoDBAction
    /// Describes an action to write to a DynamoDB table.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html
    /// </summary>
    public class DynamoDBAction
    {

        /// <summary>
        /// HashKeyField
        /// The hash key name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HashKeyField")]
        public Union<string, IntrinsicFunction> HashKeyField { get; set; }

        /// <summary>
        /// HashKeyType
        /// The hash key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HashKeyType")]
        public Union<string, IntrinsicFunction> HashKeyType { get; set; }

        /// <summary>
        /// HashKeyValue
        /// The hash key value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HashKeyValue")]
        public Union<string, IntrinsicFunction> HashKeyValue { get; set; }

        /// <summary>
        /// PayloadField
        /// The action payload. This name can be customized.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PayloadField")]
        public Union<string, IntrinsicFunction> PayloadField { get; set; }

        /// <summary>
        /// RangeKeyField
        /// The range key name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RangeKeyField")]
        public Union<string, IntrinsicFunction> RangeKeyField { get; set; }

        /// <summary>
        /// RangeKeyType
        /// The range key type. Valid values are &quot;STRING&quot; or &quot;NUMBER&quot;
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RangeKeyType")]
        public Union<string, IntrinsicFunction> RangeKeyType { get; set; }

        /// <summary>
        /// RangeKeyValue
        /// The range key value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RangeKeyValue")]
        public Union<string, IntrinsicFunction> RangeKeyValue { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to the DynamoDB table.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// TableName
        /// The name of the DynamoDB table.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

    }
}
