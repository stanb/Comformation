using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.TaskDefinition
{
    /// <summary>
    /// AWS::IoTWireless::TaskDefinition LoRaWANUpdateGatewayTaskCreate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskcreate.html
    /// </summary>
    public class LoRaWANUpdateGatewayTaskCreate
    {

        /// <summary>
        /// UpdateSignature
        /// The signature used to verify the update firmware.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpdateSignature")]
        public Union<string, IntrinsicFunction> UpdateSignature { get; set; }

        /// <summary>
        /// SigKeyCrc
        /// The CRC of the signature private key to check.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SigKeyCrc")]
        public Union<int, IntrinsicFunction> SigKeyCrc { get; set; }

        /// <summary>
        /// CurrentVersion
        /// The version of the gateways that should receive the update.
        /// Required: No
        /// Type: LoRaWANGatewayVersion
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CurrentVersion")]
        public LoRaWANGatewayVersion CurrentVersion { get; set; }

        /// <summary>
        /// UpdateVersion
        /// The firmware version to update the gateway to.
        /// Required: No
        /// Type: LoRaWANGatewayVersion
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UpdateVersion")]
        public LoRaWANGatewayVersion UpdateVersion { get; set; }

    }
}
