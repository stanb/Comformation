using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessGateway
{
    /// <summary>
    /// AWS::IoTWireless::WirelessGateway LoRaWANGateway
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessgateway-lorawangateway.html
    /// </summary>
    public class LoRaWANGateway
    {

        /// <summary>
        /// GatewayEui
        /// The gateway&#39;s EUI value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GatewayEui")]
        public Union<string, IntrinsicFunction> GatewayEui { get; set; }

        /// <summary>
        /// RfRegion
        /// The frequency band (RFRegion) value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RfRegion")]
        public Union<string, IntrinsicFunction> RfRegion { get; set; }

    }
}
