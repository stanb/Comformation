using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice OtaaV11
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-otaav11.html
    /// </summary>
    public class OtaaV11
    {

        /// <summary>
        /// AppKey
        /// The AppKey value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppKey")]
        public Union<string, IntrinsicFunction> AppKey { get; set; }

        /// <summary>
        /// NwkKey
        /// The NwkKey value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NwkKey")]
        public Union<string, IntrinsicFunction> NwkKey { get; set; }

        /// <summary>
        /// JoinEui
        /// The JoinEUI value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JoinEui")]
        public Union<string, IntrinsicFunction> JoinEui { get; set; }

    }
}
