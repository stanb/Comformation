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
        /// 		
        /// The FNwkSIntKey value, with pattern of [a-fA-F0-9]{32}. The FNwkSIntKey is a secret key, which you
        /// should handle in a similar way as you would an application password. 			You can protect the
        /// FNwkSIntKey value by storing it in the AWS Secrets Manager and use the secretsmanager 	 			to
        /// reference this value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FNwkSIntKey")]
        public Union<string, IntrinsicFunction> FNwkSIntKey { get; set; }

        /// <summary>
        /// SNwkSIntKey
        /// 		
        /// The SNwkSIntKey value. The SNwkSIntKey is a secret key, which you should handle in a similar way as
        /// you would an application password. 			You can protect the SNwkSIntKey value by storing it in the AWS
        /// Secrets Manager and use the secretsmanager 	 			to reference this value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SNwkSIntKey")]
        public Union<string, IntrinsicFunction> SNwkSIntKey { get; set; }

        /// <summary>
        /// NwkSEncKey
        /// 		
        /// The NwkSEncKey value. The NwkSEncKey is a secret key, which you should handle in a similar way as
        /// you would an application password. 			You can protect the NwkSEncKey value by storing it in the AWS
        /// Secrets Manager and use the secretsmanager 	 			to reference this value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NwkSEncKey")]
        public Union<string, IntrinsicFunction> NwkSEncKey { get; set; }

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
