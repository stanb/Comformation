using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.PartnerAccount
{
    /// <summary>
    /// AWS::IoTWireless::PartnerAccount SidewalkAccountInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-partneraccount-sidewalkaccountinfo.html
    /// </summary>
    public class SidewalkAccountInfo
    {

        /// <summary>
        /// AppServerPrivateKey
        /// 		
        /// The Sidewalk application server private key. The application server private key is a secret key,
        /// which you should handle in a similar way as you would an application password. 			You can protect
        /// the application server private key by storing the value in the AWS Secrets Manager and use the
        /// secretsmanager 	 			to reference this value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppServerPrivateKey")]
        public Union<string, IntrinsicFunction> AppServerPrivateKey { get; set; }

    }
}
