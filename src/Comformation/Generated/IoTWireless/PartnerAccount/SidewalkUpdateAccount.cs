using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.PartnerAccount
{
    /// <summary>
    /// AWS::IoTWireless::PartnerAccount SidewalkUpdateAccount
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-partneraccount-sidewalkupdateaccount.html
    /// </summary>
    public class SidewalkUpdateAccount
    {

        /// <summary>
        /// AppServerPrivateKey
        /// The new Sidewalk application server private key.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppServerPrivateKey")]
        public Union<string, IntrinsicFunction> AppServerPrivateKey { get; set; }

    }
}
