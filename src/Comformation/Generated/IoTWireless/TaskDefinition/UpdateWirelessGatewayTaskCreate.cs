using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.TaskDefinition
{
    /// <summary>
    /// AWS::IoTWireless::TaskDefinition UpdateWirelessGatewayTaskCreate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-updatewirelessgatewaytaskcreate.html
    /// </summary>
    public class UpdateWirelessGatewayTaskCreate
    {

        /// <summary>
        /// UpdateDataSource
        /// The link to the S3 bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpdateDataSource")]
        public Union<string, IntrinsicFunction> UpdateDataSource { get; set; }

        /// <summary>
        /// UpdateDataRole
        /// The IAM role used to read data from the S3 bucket.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpdateDataRole")]
        public Union<string, IntrinsicFunction> UpdateDataRole { get; set; }

        /// <summary>
        /// LoRaWAN
        /// The properties that relate to the LoRaWAN wireless gateway.
        /// Required: No
        /// Type: LoRaWANUpdateGatewayTaskCreate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LoRaWAN")]
        public LoRaWANUpdateGatewayTaskCreate LoRaWAN { get; set; }

    }
}
