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
        /// 		
        /// The AppKey value, with pattern of [a-fA-F0-9]{32}. The AppKey is a secret key, which you should
        /// handle in a similar way as you would an application password. 			You can protect the AppKey value by
        /// storing it in the AWS Secrets Manager and use the secretsmanager 	 			to reference this value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppKey")]
        public Union<string, IntrinsicFunction> AppKey { get; set; }

        /// <summary>
        /// NwkKey
        /// 		
        /// The NwkKey value. The NwkKey is a secret key, which you should handle in a similar way as you would
        /// an application password. 			You can protect the NwkKey value by storing it in the AWS Secrets
        /// Manager and use the secretsmanager 	 			to reference this value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NwkKey")]
        public Union<string, IntrinsicFunction> NwkKey { get; set; }

        /// <summary>
        /// JoinEui
        /// 		
        /// The JoinEUI value , with pattern of [a-fA-F0-9]{16}.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JoinEui")]
        public Union<string, IntrinsicFunction> JoinEui { get; set; }

    }
}
