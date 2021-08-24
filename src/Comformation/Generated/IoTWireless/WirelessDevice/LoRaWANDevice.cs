using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice LoRaWANDevice
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-lorawandevice.html
    /// </summary>
    public class LoRaWANDevice
    {

        /// <summary>
        /// DevEui
        /// 		
        /// The DevEUI value, with pattern of [a-f0-9]{16}.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DevEui")]
        public Union<string, IntrinsicFunction> DevEui { get; set; }

        /// <summary>
        /// DeviceProfileId
        /// The ID of the device profile for the new wireless device. The maximum length is 256 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceProfileId")]
        public Union<string, IntrinsicFunction> DeviceProfileId { get; set; }

        /// <summary>
        /// ServiceProfileId
        /// 		
        /// The ID of the service profile. The maximum length is 256 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceProfileId")]
        public Union<string, IntrinsicFunction> ServiceProfileId { get; set; }

        /// <summary>
        /// OtaaV11
        /// OTAA device object for v1. 1 for create APIs
        /// Required: No
        /// Type: OtaaV11
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OtaaV11")]
        public OtaaV11 OtaaV11 { get; set; }

        /// <summary>
        /// OtaaV10x
        /// OTAA device object for create APIs for v1. 0. x
        /// Required: No
        /// Type: OtaaV10x
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OtaaV10x")]
        public OtaaV10x OtaaV10x { get; set; }

        /// <summary>
        /// AbpV11
        /// 		
        /// ABP device object for create APIs for v1. 1, with pattern of [a-fA-F0-9]{8}.
        /// Required: No
        /// Type: AbpV11
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AbpV11")]
        public AbpV11 AbpV11 { get; set; }

        /// <summary>
        /// AbpV10x
        /// 		
        /// LoRaWAN object for create APIs, with pattern of [a-fA-F0-9]{32}.
        /// Required: No
        /// Type: AbpV10x
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AbpV10x")]
        public AbpV10x AbpV10x { get; set; }

    }
}
