using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.WirelessDevice
{
    /// <summary>
    /// AWS::IoTWireless::WirelessDevice SessionKeysAbpV10x
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-sessionkeysabpv10x.html
    /// </summary>
    public class SessionKeysAbpV10x
    {

        /// <summary>
        /// NwkSKey
        /// 		
        /// The NwkSKey value. The NwkSKey is a secret key, which you should handle in a similar way as you
        /// would an application password. 			You can protect the NwkSKey value by storing it in the AWS Secrets
        /// Manager and use the secretsmanager 	 			to reference this value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NwkSKey")]
        public Union<string, IntrinsicFunction> NwkSKey { get; set; }

        /// <summary>
        /// AppSKey
        /// 		
        /// The AppSKey value. The AppSKey is a secret key, which you should handle in a similar way as you
        /// would an application password. 			You can protect the AppSKey value by storing it in the AWS Secrets
        /// Manager and use the secretsmanager 	 			to reference this value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppSKey")]
        public Union<string, IntrinsicFunction> AppSKey { get; set; }

    }
}
