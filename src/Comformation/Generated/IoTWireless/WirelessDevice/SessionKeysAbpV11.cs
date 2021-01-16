using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice SessionKeysAbpV11
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-sessionkeysabpv11.html
    /// </summary>
    public class SessionKeysAbpV11
    {

        /// <summary>
        /// FNwkSIntKey
        /// The FNwkSIntKey value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FNwkSIntKey")]
        public Union<string, IntrinsicFunction> FNwkSIntKey { get; set; }

        /// <summary>
        /// SNwkSIntKey
        /// The SNwkSIntKey value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SNwkSIntKey")]
        public Union<string, IntrinsicFunction> SNwkSIntKey { get; set; }

        /// <summary>
        /// NwkSEncKey
        /// The NwkSEncKey value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NwkSEncKey")]
        public Union<string, IntrinsicFunction> NwkSEncKey { get; set; }

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
