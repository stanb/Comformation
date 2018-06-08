using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS IoT TopicRule PutItemInput
    /// The PutItemInput property type specifies the database table for an AWS IoT topic rule.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putiteminput.html
    /// </summary>
    public class PutItemInput
    {

        /// <summary>
        /// TableName
        /// The name of the DynamoDB table.
        /// Note The MQTT message payload must contain a root-level key that matches the table's primary
        /// partition key and a root-level key that matches the table's primary sort key, if one is defined.
        /// 				 For more information, see DynamoDBv2 Action in the AWS IoT Developer Guide. .
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

    }
}
