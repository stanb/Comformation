using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice OtaaV10X
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-otaav10x.html
    /// </summary>
    public class OtaaV10X
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
        /// AppEui
        /// The AppEUI value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppEui")]
        public Union<string, IntrinsicFunction> AppEui { get; set; }

    }
}
