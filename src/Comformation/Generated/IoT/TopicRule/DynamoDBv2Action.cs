using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule DynamoDBv2Action
    /// The DynamoDBv2Action property type is a property of the Actions property that describes an AWS IoT action that
    /// writes data to a DynamoDB table.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbv2action.html
    /// </summary>
    public class DynamoDBv2Action
    {

        /// <summary>
        /// PutItem
        /// Specifies the database table to which to write the item for an AWS IoT topic rule.
        /// Required: No
        /// Type: AWS IoT TopicRule PutItemInput
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PutItem")]
        public PutItemInput PutItem { get; set; }

        /// <summary>
        /// RoleArn
        /// The IAM role that allows access to the DynamoDB table. At a minimum, the role must allow the
        /// dynamoDB:PutItem IAM action.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
