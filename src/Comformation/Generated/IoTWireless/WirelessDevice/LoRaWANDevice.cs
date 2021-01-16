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
        /// The DevEUI value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DevEui")]
        public Union<string, IntrinsicFunction> DevEui { get; set; }

        /// <summary>
        /// DeviceProfileId
        /// The ID of the device profile for the new wireless device.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeviceProfileId")]
        public Union<string, IntrinsicFunction> DeviceProfileId { get; set; }

        /// <summary>
        /// ServiceProfileId
        /// The ID of the service profile.
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
        /// OtaaV10X
        /// OTAA device object for create APIs for v1. 0. x
        /// Required: No
        /// Type: OtaaV10X
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OtaaV10X")]
        public OtaaV10X OtaaV10X { get; set; }

        /// <summary>
        /// AbpV11
        /// ABP device object for create APIs for v1. 1
        /// Required: No
        /// Type: AbpV11
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AbpV11")]
        public AbpV11 AbpV11 { get; set; }

        /// <summary>
        /// AbpV10X
        /// LoRaWAN object for create APIs
        /// Required: No
        /// Type: AbpV10X
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AbpV10X")]
        public AbpV10X AbpV10X { get; set; }

    }
}
