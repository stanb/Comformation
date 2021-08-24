using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice AbpV10x
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-abpv10x.html
    /// </summary>
    public class AbpV10x
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
        /// Type: SessionKeysAbpV10x
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SessionKeys")]
        public SessionKeysAbpV10x SessionKeys { get; set; }

    }
}
