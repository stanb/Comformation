using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice OtaaV10x
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-otaav10x.html
    /// </summary>
    public class OtaaV10x
    {

        /// <summary>
        /// AppKey
        /// 		
        /// The AppKey value. TThe AppKey value is The AppKey is a secret key, which you should handle in a
        /// similar way as you would an application password. 			You can protect the AppKey value by storing it
        /// in the AWS Secrets Manager and use the secretsmanager 	 			to reference this value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppKey")]
        public Union<string, IntrinsicFunction> AppKey { get; set; }

        /// <summary>
        /// AppEui
        /// 		
        /// The AppEUI value, with pattern of [a-fA-F0-9]{16}.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppEui")]
        public Union<string, IntrinsicFunction> AppEui { get; set; }

    }
}
