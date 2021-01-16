using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice SessionKeysAbpV10X
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-sessionkeysabpv10x.html
    /// </summary>
    public class SessionKeysAbpV10X
    {

        /// <summary>
        /// NwkSKey
        /// The NwkSKey value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NwkSKey")]
        public Union<string, IntrinsicFunction> NwkSKey { get; set; }

        /// <summary>
        /// AppSKey
        /// The AppSKey value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppSKey")]
        public Union<string, IntrinsicFunction> AppSKey { get; set; }

    }
}
