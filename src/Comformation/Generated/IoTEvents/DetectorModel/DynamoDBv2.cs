using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel DynamoDBv2
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodbv2.html
    /// </summary>
    public class DynamoDBv2
    {

        /// <summary>
        /// TableName
        /// The name of the DynamoDB table.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// Payload
        /// Information needed to configure the payload.
        /// By default, AWS IoT Events generates a standard payload in JSON for any action. This action payload
        /// contains all attribute-value pairs that have the information about the detector model instance and
        /// the event triggered the action. To configure the action payload, you can use contentExpression.
        /// Required: No
        /// Type: Payload
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Payload")]
        public Payload Payload { get; set; }

    }
}
