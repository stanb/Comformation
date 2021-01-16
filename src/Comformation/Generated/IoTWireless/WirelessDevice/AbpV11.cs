using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice AbpV11
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-abpv11.html
    /// </summary>
    public class AbpV11
    {

        /// <summary>
        /// DevAddr
        /// The DevAddr value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DevAddr")]
        public Union<string, IntrinsicFunction> DevAddr { get; set; }

        /// <summary>
        /// SessionKeys
        /// Session keys for ABP v1. 1
        /// Required: Yes
        /// Type: SessionKeysAbpV11
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SessionKeys")]
        public SessionKeysAbpV11 SessionKeys { get; set; }

    }
}
