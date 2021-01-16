using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice AbpV10X
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-abpv10x.html
    /// </summary>
    public class AbpV10X
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
        /// Session keys for ABP v1. 0. x
        /// Required: Yes
        /// Type: SessionKeysAbpV10X
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SessionKeys")]
        public SessionKeysAbpV10X SessionKeys { get; set; }

    }
}
