using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule DynamoDBv2Action
    /// Describes an action to write to a DynamoDB table.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbv2action.html
    /// </summary>
    public class DynamoDBv2Action
    {

        /// <summary>
        /// PutItem
        /// Specifies the DynamoDB table to which the message data will be written. For example:
        /// { &quot;dynamoDBv2&quot;: { &quot;roleArn&quot;: &quot;aws:iam:12341251:my-role&quot; &quot;putItem&quot;: { &quot;tableName&quot;: &quot;my-table&quot; } } }
        /// Each attribute in the message payload will be written to a separate column in the DynamoDB database.
        /// Required: No
        /// Type: PutItemInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PutItem")]
        public PutItemInput PutItem { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the IAM role that grants access to the DynamoDB table.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
