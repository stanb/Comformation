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
        /// 		
        /// The gateway&#39;s EUI value, with the pattern
        /// ^(([0-9A-Fa-f]{2}-){7}|([0-9A-Fa-f]{2}:){7}|([0-9A-Fa-f]{2}\s){7}|([0-9A-Fa-f]{2}){7})([0-9A-Fa-f]{2})$
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GatewayEui")]
        public Union<string, IntrinsicFunction> GatewayEui { get; set; }

        /// <summary>
        /// RfRegion
        /// 		
        /// The frequency band (RFRegion) value. Maximum length is 64.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RfRegion")]
        public Union<string, IntrinsicFunction> RfRegion { get; set; }

    }
}
