using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.TaskDefinition
{
    /// <summary>
    /// AWS::IoTWireless::TaskDefinition LoRaWANUpdateGatewayTaskEntry
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawanupdategatewaytaskentry.html
    /// </summary>
    public class LoRaWANUpdateGatewayTaskEntry
    {

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
